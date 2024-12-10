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

namespace PracticaEmpresarial.Forms
{
    public partial class FrmUsuarioGestion : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        private DataTable ListaUsuarios { get; set; }


        public FrmUsuarioGestion()
        {
            InitializeComponent();
            MiUsuarioLocal = new Logica.Models.Usuario();
            ListaUsuarios = new DataTable();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtFiltro_MouseClick(object sender, MouseEventArgs e)
        {
            txtFiltro.SelectAll();
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

        private void FrmUsuarioGestion_Load(object sender, EventArgs e)
        {

            CargarComboRoles();

            LlenarListaUsuarios(checkActivos.Checked);

            LimpiarFormulario();
        }

        private void LimpiarFormulario(bool LimpiarBusqueda = true)
        {
           
            txtIDUser.Clear();
            txtFullName.Clear();
            txtCedula.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            cbRolUser.SelectedIndex = -1;
            txtCode.Visible = false;
            txtCode.Clear();
            lbCode.Visible = false;

            if (LimpiarBusqueda)
            {
                txtFiltro.Text = "Buscar...";
            }
            // al reinstanciar el objeto local se eliminan todos los datos de los atributos
            MiUsuarioLocal = new Logica.Models.Usuario();

            ActivarAgregar();

        }

        private void ActivarAgregar()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnDesactivar.Enabled = false;
            LblPassRequerido.Visible = true;
        }


        private void LlenarListaUsuarios(bool VerActivos, string FiltroBusqueda = "")
        {

            // el cuadro de busqueda tiene escrita la palabra "Buscar..." para no usar un label.
            // Debemos considerar esa palabra como NO válida y cualquier otro texto
            // como valido para el parametro de busqueda

            string Filtro = "";


            if (!string.IsNullOrEmpty(FiltroBusqueda) &&
                FiltroBusqueda != "Buscar...")
            {
                Filtro = FiltroBusqueda;

            }


            ListaUsuarios = MiUsuarioLocal.Listar(VerActivos, Filtro);

            DgvListaUsuarios.DataSource = ListaUsuarios;

            DgvListaUsuarios.ClearSelection();

        }

        private void CargarComboRoles() {

            DataTable DatosDeRoles = new DataTable();

            DatosDeRoles = MiUsuarioLocal.MiRol.Listar();

            cbRolUser.ValueMember = "IDUserRol";

            cbRolUser.DisplayMember = "Descripcion";
       
            cbRolUser.DataSource = DatosDeRoles;

            cbRolUser.SelectedIndex = -1;


        }

        private void checkActivos_Click(object sender, EventArgs e)
        {
            LlenarListaUsuarios(checkActivos.Checked);

            if (checkActivos.Checked)
            {
                btnDesactivar.Text = "       Desactivar";
               
                btnDesactivar.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            }
            else
            {

                btnDesactivar.Text = "       Activar";
               
                btnDesactivar.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltro.Text.Trim()) && txtFiltro.Text.Count() >= 2)
            {
                LlenarListaUsuarios(checkActivos.Checked, txtFiltro.Text.Trim());

            }
            else
            {
                LlenarListaUsuarios(checkActivos.Checked);

            }
        }

        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaUsuarios.SelectedRows.Count == 1)
            {
                LimpiarFormulario(false);

                DataGridViewRow MiFila = DgvListaUsuarios.SelectedRows[0];

                int CodigoUsuario = Convert.ToInt32(MiFila.Cells["CIDUser"].Value);

                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(CodigoUsuario);

                txtIDUser.Text = MiUsuarioLocal.IDUser.ToString();
                txtFullName.Text = MiUsuarioLocal.FullName;
                txtCedula.Text = MiUsuarioLocal.Cedula;
                txtEmail.Text = MiUsuarioLocal.Email;
                //txtContrasennia.Text = MiUsuarioLocal.Contrasennia;
                cbRolUser.SelectedValue = MiUsuarioLocal.MiRol.IDUserRol;

                if (!string.IsNullOrEmpty(MiUsuarioLocal.Code) || cbRolUser.Text == "Administrador")
                {
                    lbCode.Visible = true;
                    txtCode.Visible = true;
                    txtCode.Text = MiUsuarioLocal.Code;
                }
               

                ActivarEditaryEliminar();

            }
        }

        private void ActivarEditaryEliminar()
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
            btnDesactivar.Enabled = true;
            LblPassRequerido.Visible = false;
        }
        private bool ValidarDatosRequeridos(bool ValidarPassword = true)
        {
            // esta funcion valida los datos requeridos segun se diseño el modelo
            // logico y fisico de base de datos
            bool R = false;

            if (!string.IsNullOrEmpty(MiUsuarioLocal.FullName) &&
                !string.IsNullOrEmpty(MiUsuarioLocal.Cedula) &&
                !string.IsNullOrEmpty(MiUsuarioLocal.Email) &&
                MiUsuarioLocal.MiRol.IDUserRol > 0)
            {
                // La contraseña NO se debe validar si estamos en modo de edicion y no hemos escrito algo en 
                // la contraseña
                if (ValidarPassword && !string.IsNullOrEmpty(MiUsuarioLocal.Password))
                {
                    // si se cumplen los parematros de validacion se pasa el valor de R a true
                    R = true;
                }
                else
                {

                    // si se cumplen los parematros de validacion se pasa el valor de R a true
                    R = true;

                }


                // si se cumplen los parematros de validacion se pasa el valor de R a true
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(MiUsuarioLocal.FullName))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Nombre Completo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }

                if (string.IsNullOrEmpty(MiUsuarioLocal.Cedula))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Cedula", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }

                if (string.IsNullOrEmpty(MiUsuarioLocal.Email))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Email", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (string.IsNullOrEmpty(MiUsuarioLocal.Password))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Contraseña", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }

                if (MiUsuarioLocal.MiRol.IDUserRol == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar Rol de Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
            }

            return R;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                bool OkCedula = MiUsuarioLocal.ConsultarPorCedula(MiUsuarioLocal.Cedula);
                bool OkEmail = MiUsuarioLocal.ConsultarPorEmail();

                if (!OkCedula && !OkEmail)
                {
                    string Mensaje = string.Format("¿Desea agregar el usuario: {0}?", MiUsuarioLocal.FullName);
                    DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Continuar == DialogResult.Yes)
                    {
                        //1.6
                        if (MiUsuarioLocal.Agregar())
                        {
                            Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                            string accion = "Agregar: Nuevo Usuario: " + txtFullName.Text.Trim();
                            MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            MessageBoxCustom.Show("Usuario Agregado Correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaUsuarios(checkActivos.Checked);
                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error y no se ha guardado el usuario", ":(", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                            string accion = "Agregar Fallido: Nuevo Usuario";
                            MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                        }
                    }
                }
                else
                {
                    if (OkCedula)
                    {
                        MessageBoxCustom.Show("Ya existe un usuario con la cedula digitada", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    if (OkEmail)
                    {
                        MessageBoxCustom.Show("Ya existe un usuario con el email ingresado", "Error de Validacion", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFullName.Text))
            {
                MiUsuarioLocal.FullName = txtFullName.Text;

            }
            else
            {

                MiUsuarioLocal.FullName = "";
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCedula.Text.Trim()))
            {
                MiUsuarioLocal.Cedula = txtCedula.Text.Trim();

            }
            else
            {

                MiUsuarioLocal.Cedula = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                if (Commons.ObjetosGlobales.ValidarEmail(txtEmail.Text.Trim()))
                {
                    MiUsuarioLocal.Email = txtEmail.Text.Trim();
                }
                else
                {
                    MessageBoxCustom.Show("El formato del email no es correcto!!", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                }
            }
            else
            {
                MiUsuarioLocal.Email = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                if (Commons.ObjetosGlobales.ValidarContrasennia(txtPassword.Text.Trim()))
                {
                    MiUsuarioLocal.Password = txtPassword.Text.Trim();
                }
                else
                {
                    //"3. Debe contener al menos un caracter especial\n"
                    MessageBoxCustom.Show("El formato de la contraseña no es correcto!!\n" +
                        "1. Debe contener al menos una mayúscula y una minúscula\n" +
                        "2. Debe tener una longitud minima de 8 caracteres\n" +
                        "2. Debe contener al menos un numero impar\n",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtPassword.Focus();
                    txtPassword.SelectAll();
                }
            }
            else
            {

                MiUsuarioLocal.Password = "";
            }
        }

        private void cbRolUser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbRolUser.Text == "Administrador")
            {
                lbCode.Visible = true;
                txtCode.Visible = true;
            }
            else
            {
                lbCode.Visible = false;
                txtCode.Visible = false;
            }

            if (cbRolUser.SelectedIndex >= 0)
            {
                MiUsuarioLocal.MiRol.IDUserRol = Convert.ToInt32(cbRolUser.SelectedValue);
            }
            else
            {

                MiUsuarioLocal.MiRol.IDUserRol = 0;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos(false))
            {
                // si se cumplen los datos minimos se procede

                // uso un objeto temporal para no tocar el usuario local y poder evaluar
                // (si tiene datos en los atributos) que el usuario existe aun en BD

                Logica.Models.Usuario ObjUsuario = MiUsuarioLocal.ConsultarPorID(MiUsuarioLocal.IDUser);
                if (ObjUsuario.IDUser > 0)
                {
                    // si el id (o cualquier atrib obligatorio) tiene datos, se puede 
                    // asegurar que el usuario aun existe y proceder con el update

                    string Mensaje = string.Format("Desea Continuar con la Modificacion del Usuario: {0}?", MiUsuarioLocal.FullName);

                    DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {

                        if (MiUsuarioLocal.Editar())
                        {
                            Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                            string accion = "Actualizar: Se modificio el Usuario: " + MiUsuarioLocal.FullName; 
                            MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser,Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            // se muestra mensaje de exito y se actualiza la lista
                            MessageBoxCustom.Show("El Usuario se ha actualizado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaUsuarios(checkActivos.Checked);
                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error y no se actualizo el usuario!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                            string accion = "Actualizar Fallido: Se intento modificar el Usuario: " + MiUsuarioLocal.FullName;
                            MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser,Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);

                        }
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
           //Unicamente se toma el ID como no se puede tocar por el usuario no es necesario realizar más validaciones.
            Logica.Models.Usuario ObjUsuarioTemporal = MiUsuarioLocal.ConsultarPorID(MiUsuarioLocal.IDUser);

            if (ObjUsuarioTemporal.IDUser > 0)
            {
                if (checkActivos.Checked)
                {
                    string Mensaje = string.Format("Desea Continuar con la Desactivación del Usuario {0}?", MiUsuarioLocal.FullName);

                    DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Eliminar())
                        {
                            Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                            string accion = "Desactivación: ID Usuario " + txtIDUser.Text.Trim() + " realizada por el Usuario: " + Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName;
                            MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            // se muestra mensaje de exito y se actualiza la lista
                            MessageBoxCustom.Show("El Usuario se ha desactivado correctamente", "Atención", MessageBoxButtons.OK,MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaUsuarios(checkActivos.Checked);


                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error y no se desactivo el usuario!", "Atención", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                            string accion = "Se trato de desactivar de manera fallida un usuario. Intento del Usuario: " + Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName;
                            MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                        }
                    }

                }
                else
                {

                    string Mensaje = string.Format("Desea Continuar con la Activacion del Usuario {0}?", MiUsuarioLocal.FullName);

                    DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "???", MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Activar())
                        {
                            Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                            string accion = "Activación: ID Usuario " + txtIDUser.Text.Trim() + " realizada por el Usuario: " + Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName;
                            MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            // se muestra mensaje de exito y se actualiza la lista
                            MessageBoxCustom.Show("El Usuario se ha Activado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaUsuarios(checkActivos.Checked);

                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error y no se activo el usuario!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                            string accion = "Se trato de activar de manera fallida un usuario. Intento del Usuario: " + Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName;
                            MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                        }
                    }
                }
            }
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.SelectAll();
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode.Text.Trim()))
            {
                MiUsuarioLocal.Code = txtCode.Text.Trim();

            }
            else
            {

                MiUsuarioLocal.Code = "";
            }
        }
    }
}
