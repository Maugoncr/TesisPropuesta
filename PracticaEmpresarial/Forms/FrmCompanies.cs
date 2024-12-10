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
    public partial class FrmCompanies : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Logica.Models.Company MiCompany { get; set; }

        private DataTable ListaCompanies { get; set; }
        public FrmCompanies()
        {
            InitializeComponent();
            MiCompany = new Logica.Models.Company();
            ListaCompanies = new DataTable();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCompanies_Load(object sender, EventArgs e)
        {
            LlenarListaUsuarios();

            LimpiarFormulario();
        }

        private void LimpiarFormulario(bool LimpiarBusqueda = true)
        {

            txtIDCompany.Clear();
            txtCedulaJ.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();

            if (LimpiarBusqueda)
            {
                txtFiltro.Text = "Buscar...";
            }
            // al reinstanciar el objeto local se eliminan todos los datos de los atributos
            MiCompany = new Logica.Models.Company();

            ActivarAgregar();

        }

        private void ActivarAgregar()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LlenarListaUsuarios( string FiltroBusqueda = "")
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


            ListaCompanies = MiCompany.Listar(Filtro);

            DgvListaCompanies.DataSource = ListaCompanies;

            DgvListaCompanies.ClearSelection();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltro.Text.Trim()) && txtFiltro.Text.Count() >= 2)
            {
                LlenarListaUsuarios(txtFiltro.Text.Trim());

            }
            else
            {
                LlenarListaUsuarios();

            }
        }

        private void DgvListaCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaCompanies.SelectedRows.Count == 1)
            {
                LimpiarFormulario(false);

                DataGridViewRow MiFila = DgvListaCompanies.SelectedRows[0];

                int CodigoUsuario = Convert.ToInt32(MiFila.Cells["CIDCompany"].Value);

                MiCompany = MiCompany.ConsultarPorID(CodigoUsuario);

                txtIDCompany.Text = MiCompany.IDCompany.ToString();
                txtNombre.Text = MiCompany.Nombre;
                txtCedulaJ.Text = MiCompany.CedulaJ;
                txtEmail.Text = MiCompany.Email;
                txtDireccion.Text = MiCompany.Direccion;
                txtTelefono.Text = MiCompany.Telefono;
                ActivarEditaryEliminar();

            }
        }

        private void ActivarEditaryEliminar()
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosRequeridos())
            {
                bool OkCedulaJ = MiCompany.ConsultarPorCedula(MiCompany.CedulaJ);

                if (!OkCedulaJ)
                {
                    string Mensaje = string.Format("¿Desea agregar la compañia: {0}?", MiCompany.Nombre);
                    DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Continuar == DialogResult.Yes)
                    {
                        //1.6
                        if (MiCompany.Agregar())
                        {
                            Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                            string accion = "Agregar: Nueva Compañia: " + txtNombre.Text.Trim();
                            MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            MessageBoxCustom.Show("Compañia Agregada Correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaUsuarios();
                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error y no se ha guardado la compañia", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                            string accion = "Agregar Fallido: Nueva Compañia";
                            MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                        }
                    }
                }
                else
                {
                    if (OkCedulaJ)
                    {
                        MessageBoxCustom.Show("Ya existe una empresa registrada bajo la misma cedula juridica", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private bool ValidarDatosRequeridos(bool ValidarPassword = true)
        {
            // esta funcion valida los datos requeridos segun se diseño el modelo
            // logico y fisico de base de datos
            bool R = false;

            if (!string.IsNullOrEmpty(MiCompany.Nombre) &&
                !string.IsNullOrEmpty(MiCompany.CedulaJ) &&
                !string.IsNullOrEmpty(MiCompany.Telefono) &&
                !string.IsNullOrEmpty(MiCompany.Direccion))
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(MiCompany.Nombre))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (string.IsNullOrEmpty(MiCompany.CedulaJ))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Cedula Juridica", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (string.IsNullOrEmpty(MiCompany.Direccion))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Direccion", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (string.IsNullOrEmpty(MiCompany.Telefono))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Telefono", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }

                
            }

            return R;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {
                Logica.Models.Company ObjUsuario = MiCompany.ConsultarPorID(MiCompany.IDCompany);
                if (ObjUsuario.IDCompany > 0)
                {
                    string Mensaje = string.Format("Desea Continuar con la Modificacion de la Compañia: {0}?", MiCompany.Nombre);

                    DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {

                        if (MiCompany.Editar())
                        {
                            Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                            string accion = "Actualizar: Se modificio la Compañia: " + txtNombre.Text;
                            MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            // se muestra mensaje de exito y se actualiza la lista
                            MessageBoxCustom.Show("La Compañia se ha actualizado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaUsuarios();
                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error y no se actualizo la compañia!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                            string accion = "Actualizar Fallido: Se intento modificar la Compañia: " + MiCompany.Nombre;
                            MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);

                        }
                    }
                }
            }
        }

        private void txtCedulaJ_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCedulaJ.Text.Trim()))
            {
                MiCompany.CedulaJ = txtCedulaJ.Text.Trim();

            }
            else
            {

                MiCompany.CedulaJ = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                MiCompany.Nombre = txtNombre.Text.Trim();

            }
            else
            {

                MiCompany.Nombre = "";
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTelefono.Text.Trim()))
            {
                MiCompany.Telefono = txtTelefono.Text.Trim();

            }
            else
            {

                MiCompany.Telefono = "";
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDireccion.Text))
            {
                MiCompany.Direccion = txtDireccion.Text;

            }
            else
            {

                MiCompany.Direccion = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                if (Commons.ObjetosGlobales.ValidarEmail(txtEmail.Text.Trim()))
                {
                    MiCompany.Email = txtEmail.Text.Trim();
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
                MiCompany.Email = "";
            }
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.SelectAll();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBoxCustom.Show("         ----- 𝗜𝗠𝗣𝗢𝗥𝗧𝗔𝗡𝗧𝗘 -----\nDeben existir lo siguiente:\n" +
              "• Coarsa\n• Arvaco\n•Personal\n\n              𝗗𝗲𝗯𝗲 𝘀𝗲𝗿 𝗲𝘅𝗮𝗰𝘁𝗼"
              , "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
