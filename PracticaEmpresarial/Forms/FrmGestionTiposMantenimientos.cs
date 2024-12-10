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
    public partial class FrmGestionTiposMantenimientos : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Logica.Models.TipoMantenimiento MiTipo { get; set; }
        private DataTable ListaTiposMante { get; set; }

        public FrmGestionTiposMantenimientos()
        {
            InitializeComponent();
            MiTipo = new Logica.Models.TipoMantenimiento();
            ListaTiposMante = new DataTable();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            
            if (ObjetosGlobales.TrabajandoConPermiso == true)
            {
                ObjetosGlobales.TrabajandoConPermiso = false;
                ObjetosGlobales.MiAdministradorPermiso = new Logica.Models.Usuario();
                this.Close();
            }

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmGestionTiposMantenimientos_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
            LlenarListaTipos();
        }

        private void LimpiarFormulario()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            txtDetalle.Clear();
            txtIDTipoMantenimiento.Clear();

            MiTipo = new Logica.Models.TipoMantenimiento();

        }

        private void LlenarListaTipos()
        {
            ListaTiposMante = MiTipo.Listar();
            DgvListaTipos.DataSource = ListaTiposMante;
            DgvListaTipos.ClearSelection();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            LlenarListaTipos();
        }

        private void txtDetalle_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDetalle.Text))
            {
                MiTipo.Detalle = txtDetalle.Text;

            }
            else
            {
                MiTipo.Detalle = "";
            }
        }

        private void DgvListaTipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaTipos.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = DgvListaTipos.SelectedRows[0];

                int CodigoPlace = Convert.ToInt32(MiFila.Cells["CIDTipoMantenimiento"].Value);

                MiTipo = MiTipo.ConsultarPorID(CodigoPlace);

                txtIDTipoMantenimiento.Text = MiTipo.IDTipoMantenimiento.ToString();
                txtDetalle.Text = MiTipo.Detalle;

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

            if (!string.IsNullOrEmpty(MiTipo.Detalle))
            {
                R = true;
            }
            else
            {

                if (string.IsNullOrEmpty(MiTipo.Detalle))
                {
                    MessageBoxCustom.Show("Tienes que agregar el tipo de mantenimiento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    string Mensaje = string.Format("¿Realmente deseas agregar este nuevo tipo de mantenimiento: {0}?", MiTipo.Detalle);
                    DialogResult respuesta = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiTipo.Agregar())
                        {
                            Logica.Models.Bitacora bitacora = new Logica.Models.Bitacora();

                            if (ObjetosGlobales.TrabajandoConPermiso)
                            {
                                string accion = "Agregar con Permiso: Nuevo Tipo Mantenimiento: " + MiTipo.Detalle + " Permiso: "
                                    + ObjetosGlobales.MiAdministradorPermiso.FullName;
                                bitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser,
                                ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            }
                            else
                            {
                                string accion = "Agregar: Nuevo Tipo Mantenimiento: " + MiTipo.Detalle;
                                bitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser,
                                ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            }

                            MessageBoxCustom.Show("Tipo Mantenimiento Agregado Correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaTipos();
                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error agregando el tipo de mantenimiento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (okDescripcion)
                    {
                        MessageBox.Show("Ya existe ese tipo de mantenimiento registrado",
                            "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                Logica.Models.TipoMantenimiento objRol = MiTipo.ConsultarPorID(MiTipo.IDTipoMantenimiento);

                if (objRol.IDTipoMantenimiento > 0)
                {

                    string Mensaje = string.Format("¿Realmente deseas editar el tipo de mantenimiento: {0}?", MiTipo.IDTipoMantenimiento);
                    DialogResult respuesta = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiTipo.Editar())
                        {
                            Logica.Models.Bitacora bitacora = new Logica.Models.Bitacora();

                            string accion = "Editar el Tipo Mantenimiento: " + MiTipo.Detalle;

                            bitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser,
                                ObjetosGlobales.MiUsuarioDeSistema.FullName);

                            MessageBoxCustom.Show("Tipo de Mantenimiento Editado Correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaTipos();
                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error editando el tipo de mantenimiento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBoxCustom.Show("         ----- 𝗜𝗠𝗣𝗢𝗥𝗧𝗔𝗡𝗧𝗘 -----\nDeben existir los siguientes:\n" +
                "• Combustible\n• Revisión Técnica\n• Cambio de Aceite\n• Pago Marchamo\n\n              𝗗𝗲𝗯𝗲 𝘀𝗲𝗿 𝗲𝘅𝗮𝗰𝘁𝗼"
                , "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
