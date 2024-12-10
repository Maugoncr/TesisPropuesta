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
    public partial class FrmTipoVehiculo : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Logica.Models.TipoVehiculo MiTipo { get; set; }
        private DataTable ListaTipos { get; set; }

        public FrmTipoVehiculo()
        {
            InitializeComponent();
            MiTipo = new Logica.Models.TipoVehiculo();
            ListaTipos = new DataTable();
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

        private void DgvListaTipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaTipos.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = DgvListaTipos.SelectedRows[0];

                int CodigoPlace = Convert.ToInt32(MiFila.Cells["CIDTipo"].Value);

                MiTipo = MiTipo.ConsultarPorID(CodigoPlace);

                txtIDTipo.Text = MiTipo.IDTipo.ToString();
                txtDescripcion.Text = MiTipo.Descripcion;

                ActivarEditar();

            }
        }

        private void ActivarEditar()
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void LimpiarFormulario()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            txtDescripcion.Clear();
            txtIDTipo.Clear();

            MiTipo = new Logica.Models.TipoVehiculo();

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmTipoVehiculo_Load(object sender, EventArgs e)
        {
            LlenarListaUsuarios();

            LimpiarFormulario();

        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                MiTipo.Descripcion = txtDescripcion.Text.Trim();

            }
            else
            {
                MiTipo.Descripcion = "";
            }
        }

        private void LlenarListaUsuarios()
        {

            ListaTipos = MiTipo.Listar();
            DgvListaTipos.DataSource = ListaTipos;
            DgvListaTipos.ClearSelection();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            LlenarListaUsuarios();
        }

        private bool ValidarDatosRequeridos()
        {

            bool R = false;

            if (!string.IsNullOrEmpty(MiTipo.Descripcion))
            {
                R = true;
            }
            else
            {

                if (string.IsNullOrEmpty(MiTipo.Descripcion))
                {
                    MessageBoxCustom.Show("Tienes que agregar un tipo de vehiculo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return R;
                }
            }

            return R;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {

                bool okDescripcion = MiTipo.ConsultarPorDescripcion();

                if (!okDescripcion)
                {
                    string Mensaje = string.Format("¿Realmente deseas agregar este nuevo tipo de vehiculo: {0}?", MiTipo.Descripcion);
                    DialogResult respuesta = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiTipo.Agregar())
                        {
                            Logica.Models.Bitacora bitacora = new Logica.Models.Bitacora();

                            string accion = "Agregar: Nuevo Tipo Vehiculo: " + MiTipo.Descripcion;

                            bitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser,
                                ObjetosGlobales.MiUsuarioDeSistema.FullName);

                            MessageBoxCustom.Show("Tipo Vehiculo Agregado Correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaUsuarios();

                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error agregando el tipo de vehiculo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }


                }
                else
                {
                    if (okDescripcion)
                    {
                        MessageBox.Show("Ya existe ese tipo de vehiculo registrado",
                            "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                Logica.Models.TipoVehiculo objRol = MiTipo.ConsultarPorID(MiTipo.IDTipo);

                if (objRol.IDTipo > 0)
                {

                    string Mensaje = string.Format("¿Realmente deseas editar el tipo de vehiculo: {0}?", MiTipo.Descripcion);
                    DialogResult respuesta = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiTipo.Editar())
                        {
                            Logica.Models.Bitacora bitacora = new Logica.Models.Bitacora();

                            string accion = "Editar el Tipo Vehiculo: " + MiTipo.Descripcion;

                            bitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser,
                                ObjetosGlobales.MiUsuarioDeSistema.FullName);

                            MessageBoxCustom.Show("Tipo de Vehiculo Editado Correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaUsuarios();


                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error editando el tipo de vehiculo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }




                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBoxCustom.Show("         ----- 𝗜𝗠𝗣𝗢𝗥𝗧𝗔𝗡𝗧𝗘 -----\nDeben existir lo siguiente:\n" +
               "• Camión/Camion/Camiones\n\n              𝗗𝗲𝗯𝗲 𝘀𝗲𝗿 𝗲𝘅𝗮𝗰𝘁𝗼"
               , "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
