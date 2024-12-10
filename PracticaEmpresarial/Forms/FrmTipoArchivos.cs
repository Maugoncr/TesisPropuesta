using CustomMessageBox;
using PracticaEmpresarial.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEmpresarial.Forms
{
    public partial class FrmTipoArchivos : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Logica.Models.TipoArchivo MiTipoArchivo { get; set; }
        private DataTable ListaTiposArchivos { get; set; }


        public FrmTipoArchivos()
        {
            InitializeComponent();
            MiTipoArchivo = new Logica.Models.TipoArchivo();
            ListaTiposArchivos= new DataTable();

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void FrmTipoArchivos_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
            LlenarListaTipos();
        }

        private void LimpiarFormulario()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            txtDescripcion.Clear();
            txtIDTipoArchivo.Clear();

            MiTipoArchivo = new Logica.Models.TipoArchivo();

        }

        private void LlenarListaTipos()
        {
            ListaTiposArchivos = MiTipoArchivo.Listar();
            DgvListaLugares.DataSource = ListaTiposArchivos;
            DgvListaLugares.ClearSelection();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            LlenarListaTipos();
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MiTipoArchivo.DescripcionTipoArchivo = txtDescripcion.Text;

            }
            else
            {
                MiTipoArchivo.DescripcionTipoArchivo = "";
            }
        }

        private void DgvListaLugares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaLugares.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = DgvListaLugares.SelectedRows[0];

                int CodigoPlace = Convert.ToInt32(MiFila.Cells["CIDTipoArchivo"].Value);

                MiTipoArchivo = MiTipoArchivo.ConsultarPorID(CodigoPlace);

                txtIDTipoArchivo.Text = MiTipoArchivo.IDTipoArchivo.ToString();
                txtDescripcion.Text = MiTipoArchivo.DescripcionTipoArchivo;

                ActivarEditar();

            }
        }

        private void ActivarEditar()
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
        }

        private bool ValidarDatosRequeridos()
        {

            bool R = false;

            if (!string.IsNullOrEmpty(MiTipoArchivo.DescripcionTipoArchivo))
            {
                R = true;
            }
            else
            {

                if (string.IsNullOrEmpty(MiTipoArchivo.DescripcionTipoArchivo))
                {
                    MessageBoxCustom.Show("Tienes que agregar el tipo de archivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return R;
                }
            }

            return R;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {

                bool okDescripcion = MiTipoArchivo.ConsultarPorDescripcion();

                if (!okDescripcion)
                {
                    string Mensaje = string.Format("¿Realmente deseas agregar este nuevo tipo de mantenimiento: {0}?", MiTipoArchivo.DescripcionTipoArchivo);
                    DialogResult respuesta = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiTipoArchivo.Agregar())
                        {
                            Logica.Models.Bitacora bitacora = new Logica.Models.Bitacora();

                                string accion = "Agregar: Nuevo Tipo Archivo: " + MiTipoArchivo.DescripcionTipoArchivo;
                                bitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser,
                                ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            

                            MessageBoxCustom.Show("Tipo Archivo Agregado Correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaTipos();
                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error agregando el tipo de archivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (okDescripcion)
                    {
                        MessageBox.Show("Ya existe ese tipo de archivo registrado",
                            "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                Logica.Models.TipoArchivo objRol = MiTipoArchivo.ConsultarPorID(MiTipoArchivo.IDTipoArchivo);

                if (objRol.IDTipoArchivo > 0)
                {

                    string Mensaje = string.Format("¿Realmente deseas editar el tipo de archivo: {0}?", MiTipoArchivo.IDTipoArchivo);
                    DialogResult respuesta = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiTipoArchivo.Editar())
                        {
                            Logica.Models.Bitacora bitacora = new Logica.Models.Bitacora();

                            string accion = "Editar el Tipo Archivo: " + MiTipoArchivo.DescripcionTipoArchivo;

                            bitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser,
                                ObjetosGlobales.MiUsuarioDeSistema.FullName);

                            MessageBoxCustom.Show("Tipo de Archivo Editado Correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaTipos();
                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error editando el tipo de archivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
