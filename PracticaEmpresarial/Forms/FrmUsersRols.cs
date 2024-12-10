using CustomMessageBox;
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
using PracticaEmpresarial.Commons;

namespace PracticaEmpresarial.Forms

{
    public partial class FrmUsersRols : Form
    {

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Logica.Models.UserRol MiRol { get; set; }
        private DataTable ListaRolesUsuario { get; set; }



        public FrmUsersRols()
        {
            InitializeComponent();

            MiRol = new Logica.Models.UserRol();
            ListaRolesUsuario = new DataTable();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsersRols_Load(object sender, EventArgs e)
        {

            LlenarListaUsuarios();

            LimpiarFormulario();


        }

        private void LlenarListaUsuarios()
        {

            ListaRolesUsuario = MiRol.Listar();

            DgvListaRolesUsuario.DataSource = ListaRolesUsuario;

            DgvListaRolesUsuario.ClearSelection();

        }

        private void LimpiarFormulario() {

            checkAgregar.Checked = false;
            checkConsultar.Checked = false;
            checkEditar.Checked = false;
            checkEliminar.Checked = false;
            checkIsAdmin.Checked = false;
            checkReport.Checked = false;
            checkChofer.Checked = false;
            checkVehiculo.Checked = false;
            checkMantenimientos.Checked = false;
            checkGastos.Checked = false;
            checkAutorizador.Checked = false;
            checkOrdenes.Checked = false;

            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;

            txtDescripcion.Clear();
            txtIDUserRol.Clear();
            
            MiRol = new Logica.Models.UserRol();
        
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void DgvListaRolesUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgvListaRolesUsuario.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = DgvListaRolesUsuario.SelectedRows[0];

                int CodigoUsuario = Convert.ToInt32(MiFila.Cells["CIDUserRol"].Value);

                MiRol = MiRol.ConsultarPorID(CodigoUsuario);

                txtIDUserRol.Text = MiRol.IDUserRol.ToString();
                txtDescripcion.Text = MiRol.Descripcion;

                if (MiRol.IsAdmin)
                {
                    checkAgregar.Checked = true;
                    checkEditar.Checked = true;
                    checkEliminar.Checked = true;
                    checkConsultar.Checked = true;
                    checkReport.Checked = true;
                    checkChofer.Checked = true;
                    checkVehiculo.Checked = true;
                    checkMantenimientos.Checked = true;
                    checkGastos.Checked = true;
                    checkAutorizador.Checked = true;
                    checkOrdenes.Checked = true;

                    checkIsAdmin.Checked = true;
                }
                else
                {
                    checkIsAdmin.Checked = false;
                    if (MiRol.PAgregar)
                    {
                        checkAgregar.Checked = true;
                    }
                    if (MiRol.PEditar)
                    {
                        checkEditar.Checked = true;
                    }
                    if (MiRol.PConsultar)
                    {
                        checkConsultar.Checked = true;
                    }
                    if (MiRol.PEliminar)
                    {
                        checkEliminar.Checked = true;
                    }
                    if (MiRol.PReport)
                    {
                        checkReport.Checked = true;
                    }
                    if (MiRol.PChofer)
                    {
                        checkChofer.Checked = true;
                    }
                    if (MiRol.PVehiculo)
                    {
                        checkVehiculo.Checked = true;
                    }
                    if (MiRol.PMantenimiento)
                    {
                        checkMantenimientos.Checked = true;
                    }
                    if (MiRol.PGasto)
                    {
                        checkGastos.Checked = true;
                    }
                    if (MiRol.IsAutorizador)
                    {
                        checkAutorizador.Checked = true;
                    }
                    if (MiRol.POrdenCompra)
                    {
                        checkOrdenes.Checked = true;
                    }
                }

                ActivarEditar();

            }

        }

        private void ActivarEditar() {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void checkIsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsAdmin.Checked)
            {
                MiRol.IsAdmin = true;
                MiRol.PAgregar=true;
                MiRol.PEditar = true;
                MiRol.PEliminar = true;
                MiRol.PReport = true;
                MiRol.PConsultar = true;
                MiRol.PChofer = true;
                MiRol.PVehiculo = true;
                MiRol.PGasto = true;
                MiRol.PMantenimiento = true;
                MiRol.IsAutorizador = true;
                MiRol.POrdenCompra = true;

                checkAgregar.Checked = true;
                checkAgregar.Enabled = false;
                checkEditar.Checked = true;
                checkEditar.Enabled = false;
                checkEliminar.Checked = true;
                checkEliminar.Enabled = false;
                checkConsultar.Checked = true;
                checkConsultar.Enabled = false;
                checkReport.Checked = true;
                checkReport.Enabled = false;
                checkChofer.Checked = true;
                checkChofer.Enabled = false;
                checkVehiculo.Checked = true;
                checkVehiculo.Enabled = false;
                checkGastos.Checked = true;
                checkGastos.Enabled = false;
                checkMantenimientos.Checked = true;
                checkMantenimientos.Enabled = false;
                checkAutorizador.Checked = true;
                checkAutorizador.Enabled = false;
                checkOrdenes.Checked = true;
                checkOrdenes.Enabled = false;

            }
            else
            {
                MiRol.IsAdmin = false;
                checkAgregar.Enabled = true;
                checkEditar.Enabled = true;
                checkEliminar.Enabled = true;
                checkConsultar.Enabled = true;
                checkReport.Enabled = true;
                checkIsAdmin.Enabled = true;
                checkChofer.Enabled = true;
                checkGastos.Enabled = true;
                checkVehiculo.Enabled = true;
                checkMantenimientos.Enabled = true;
                checkAutorizador.Enabled = true;
                checkOrdenes.Enabled = true;

                checkAgregar.Checked = false;
                checkEditar.Checked = false;
                checkEliminar.Checked = false;
                checkConsultar.Checked = false;
                checkReport.Checked = false;
                checkIsAdmin.Checked = false;
                checkChofer.Checked = false;
                checkVehiculo.Checked = false;
                checkGastos.Checked = false;
                checkMantenimientos.Checked = false;
                checkAutorizador.Checked = false;
                checkOrdenes.Checked = false;

            }


        }

        private bool ValidarDatosRequeridos()
        {
            // esta funcion valida los datos requeridos segun se diseño el modelo
            // logico y fisico de base de datos
            bool R = false;

            if (!string.IsNullOrEmpty(MiRol.Descripcion))
            {
                // La contraseña NO se debe validar si estamos en modo de edicion y no hemos escrito algo en 
                // la contraseña
                R = true;
            }
            else
            {
                //retroalimentar al usuario para indicar qué campo hace falta digitar
                if (string.IsNullOrEmpty(MiRol.Descripcion))
                {
                    MessageBoxCustom.Show("Tienes que agregar una descripcion", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return R;
                }
            }

            return R;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosRequeridos())
            {

                bool okDescripcion = MiRol.ConsultarPorDescripcion();

                if (!okDescripcion)
                {
                    string Mensaje = string.Format("¿Realmente deseas agregar este nuevo rol de usuario {0}?", MiRol.Descripcion);
                    DialogResult respuesta = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiRol.Agregar())
                        {
                            Logica.Models.Bitacora bitacora = new Logica.Models.Bitacora();

                            string accion = "Agregar: Nuevo Rol de Usuario: " + MiRol.Descripcion;

                            bitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser,
                                ObjetosGlobales.MiUsuarioDeSistema.FullName);

                            MessageBoxCustom.Show("Rol de Usuario Agregado Correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaUsuarios();

                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error agregando un rol de usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }


                }
                else
                {
                    if (okDescripcion)
                    {
                        MessageBox.Show("Ya existe un Rol de Usuario esa misma descripcion", 
                            "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }



        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                MiRol.Descripcion = txtDescripcion.Text;

            }
            else
            {
                MiRol.Descripcion = "";
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBoxCustom.Show("Solo se puede ingresar letras", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void checkReport_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReport.Checked)
            {
                MiRol.PReport = true;
            }
            else
            {
                MiRol.PReport = false;
            }
        }

        private void checkConsultar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkConsultar.Checked)
            {
                MiRol.PConsultar = true;
            }
            else
            {
                MiRol.PConsultar = false;
            }
        }

        private void checkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEliminar.Checked)
            {
                MiRol.PEliminar = true;
            }
            else
            {
                MiRol.PEliminar = false;
            }
        }

        private void checkEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditar.Checked)
            {
                MiRol.PEditar = true;
            }
            else
            {
                MiRol.PEditar = false;
            }
        }

        private void checkAgregar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAgregar.Checked)
            {
                MiRol.PAgregar = true;
            }
            else
            {
                MiRol.PAgregar = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                Logica.Models.UserRol objRol = MiRol.ConsultarPorID(MiRol.IDUserRol);

                if (objRol.IDUserRol > 0)
                {

                    string Mensaje = string.Format("¿Realmente deseas editar el rol de usuario: {0}?", MiRol.Descripcion);
                    DialogResult respuesta = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (respuesta == DialogResult.Yes) 
                    {
                        if (MiRol.Editar())
                        {
                            Logica.Models.Bitacora bitacora = new Logica.Models.Bitacora();

                            string accion = "Editar el Rol de Usuario: " + MiRol.Descripcion;

                            bitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser,
                                ObjetosGlobales.MiUsuarioDeSistema.FullName);

                            MessageBoxCustom.Show("Rol de Usuario Editado Correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaUsuarios();


                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error editando el rol de usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }   
                    
                    
                    
                    }




                }


            }
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

        private void checkChofer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChofer.Checked)
            {
                MiRol.PChofer = true;
            }
            else
            {
                MiRol.PChofer = false;
            }
        }

        private void checkVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVehiculo.Checked)
            {
                MiRol.PVehiculo = true;
            }
            else
            {
                MiRol.PVehiculo = false;
            }
        }

        private void checkMantenimientos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMantenimientos.Checked)
            {
                MiRol.PMantenimiento = true;
            }
            else
            {
                MiRol.PMantenimiento = false;
            }
        }

        private void checkGastos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGastos.Checked)
            {
                MiRol.PGasto = true;
            }
            else
            {
                MiRol.PGasto = false;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBoxCustom.Show("         ----- 𝗜𝗠𝗣𝗢𝗥𝗧𝗔𝗡𝗧𝗘 -----\nDeben existir lo siguiente:\n" +
               "• Administrador\n\n              𝗗𝗲𝗯𝗲 𝘀𝗲𝗿 𝗲𝘅𝗮𝗰𝘁𝗼"
               , "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkAutorizador_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAutorizador.Checked)
            {
                MiRol.IsAutorizador = true;
            }
            else
            {
                MiRol.IsAutorizador = false;
            }
        }

        private void checkOrdenes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOrdenes.Checked)
            {
                MiRol.POrdenCompra = true;
            }
            else
            {
                MiRol.POrdenCompra = false;
            }
        }
    }
}
