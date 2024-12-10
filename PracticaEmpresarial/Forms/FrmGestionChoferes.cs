using CustomMessageBox;
using PracticaEmpresarial.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEmpresarial.Forms
{
    public partial class FrmGestionChoferes : Form
    {
        private Logica.Models.Chofer MiChofer { get; set; }

        private DataTable ListaChoferes { get; set; }

        public FrmGestionChoferes()
        {
            InitializeComponent();
            ListaChoferes = new DataTable();
            MiChofer = new Logica.Models.Chofer();
        }

        private void FrmGestionChoferes_Load(object sender, EventArgs e)
        {
            LlenarListaUsuarios(checkActivos.Checked);

            LimpiarFormulario();
        }

        private void LlenarListaUsuarios(bool VerActivos, string FiltroBusqueda = "")
        {
            string Filtro = "";


            if (!string.IsNullOrEmpty(FiltroBusqueda) &&
                FiltroBusqueda != "Buscar...")
            {
                Filtro = FiltroBusqueda;

            }


            ListaChoferes = MiChofer.Listar(VerActivos, Filtro);

            DgvListaChoferes.DataSource = ListaChoferes;

            DgvListaChoferes.ClearSelection();

        }


        private void LimpiarFormulario(bool LimpiarBusqueda = true)
        {

            txtIDChofer.Clear();
            txtFullName.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtCodigoEmpleado.Clear();

            if (LimpiarBusqueda)
            {
                txtFiltro.Text = "Buscar...";
            }
            // al reinstanciar el objeto local se eliminan todos los datos de los atributos
            MiChofer = new Logica.Models.Chofer();
            ActivarAgregar();

        }

        private void ActivarAgregar()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnDesactivar.Enabled = false;
        }

        private void DgvListaChoferes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaChoferes.SelectedRows.Count == 1)
            {
                LimpiarFormulario(false);

                DataGridViewRow MiFila = DgvListaChoferes.SelectedRows[0];

                int CodigoUsuario = Convert.ToInt32(MiFila.Cells["CIDChofer"].Value);

                MiChofer = MiChofer.ConsultarPorID(CodigoUsuario);

                txtIDChofer.Text = MiChofer.IDChofer.ToString();
                txtFullName.Text = MiChofer.FullName;
                txtCedula.Text = MiChofer.Cedula;
                txtEmail.Text = MiChofer.Email;
                txtTelefono.Text = MiChofer.Telefono;
                txtCodigoEmpleado.Text = MiChofer.CodigoEmpleado;
              

                ActivarEditaryEliminar();

            }
        }
        private void ActivarEditaryEliminar()
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
            btnDesactivar.Enabled = true;
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin() || ObjetosGlobales.PuedesAgregar())
            {
                if (ValidarDatosRequeridos())
                {
                    bool OkCedula = MiChofer.ConsultarPorCedula(MiChofer.Cedula);

                    if (!OkCedula)
                    {
                        string Mensaje = string.Format("¿Desea agregar el usuario: {0}?", MiChofer.FullName);
                        DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (Continuar == DialogResult.Yes)
                        {

                            if (MiChofer.Agregar())
                            {
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Agregar: Nuevo Chofer: " + txtFullName.Text.Trim();
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                                MessageBoxCustom.Show("Chofer Agregado Correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                                LlenarListaUsuarios(checkActivos.Checked);
                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error y no se ha guardado el chofer", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Agregar Fallido: Nuevo Chofer";
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            }
                        }
                    }
                    else
                    {
                        if (OkCedula)
                        {
                            MessageBoxCustom.Show("Ya existe un chofer con la cedula digitada", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            else
            {
                MessageBoxCustom.Show("Permiso de agregar NO concedido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(MiChofer.FullName) &&
                !string.IsNullOrEmpty(MiChofer.Cedula) &&
                !string.IsNullOrEmpty(MiChofer.Telefono))
            {
                R= true;
            }
            else
            {
                if (string.IsNullOrEmpty(MiChofer.FullName))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Nombre Completo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }

                if (string.IsNullOrEmpty(MiChofer.Cedula))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Cedula", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }

                if (string.IsNullOrEmpty(MiChofer.Telefono))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Telefono", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
               
            }

            return R;
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCedula.Text.Trim()))
            {
                MiChofer.Cedula = txtCedula.Text.Trim();

            }
            else
            {

                MiChofer.Cedula = "";
            }
        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFullName.Text))
            {
                MiChofer.FullName = txtFullName.Text;

            }
            else
            {

                MiChofer.FullName = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MiChofer.Email = txtEmail.Text.Trim();

            }
            else
            {

                MiChofer.Email = "";
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTelefono.Text.Trim()))
            {
                MiChofer.Telefono = txtTelefono.Text.Trim();

            }
            else
            {

                MiChofer.Telefono = "";
            }
        }

        private void txtCodigoEmpleado_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoEmpleado.Text.Trim()))
            {
                MiChofer.CodigoEmpleado = txtCodigoEmpleado.Text.Trim();
            }
            else
            {

                MiChofer.CodigoEmpleado = "";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin() || ObjetosGlobales.PuedesEditar())
            {
                if (ValidarDatosRequeridos())
                {
                    Logica.Models.Chofer ObjUsuario = MiChofer.ConsultarPorID(MiChofer.IDChofer);
                    if (ObjUsuario.IDChofer > 0)
                    {
                        string Mensaje = string.Format("Desea Continuar con la Modificacion del Chofer: {0}?", MiChofer.FullName);

                        DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (Continuar == DialogResult.Yes)
                        {

                            if (MiChofer.Editar())
                            {
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Actualizar: Se modificio el Chofer: " + MiChofer.FullName;
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                                // se muestra mensaje de exito y se actualiza la lista
                                MessageBoxCustom.Show("El Chofer se ha actualizado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                                LlenarListaUsuarios(checkActivos.Checked);
                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error y no se actualizo el chofer!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Actualizar Fallido: Se intento modificar el Chofer: " + MiChofer.FullName;
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);

                            }
                        }
                    }
                }
            }
            else
            {
                MessageBoxCustom.Show("Permiso de editar NO concedido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin() || ObjetosGlobales.PuedesEliminar())
            {
                Logica.Models.Chofer ObjUsuarioTemporal = MiChofer.ConsultarPorID(MiChofer.IDChofer);

                if (ObjUsuarioTemporal.IDChofer > 0)
                {
                    if (checkActivos.Checked)
                    {
                        string Mensaje = string.Format("Desea Continuar con la Desactivación del Chofer: {0}?", MiChofer.FullName);

                        DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (Continuar == DialogResult.Yes)
                        {
                            if (MiChofer.Eliminar())
                            {
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Desactivación: ID Chofer " + txtIDChofer.Text.Trim() + " realizada por el Usuario: " + Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName;
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                                // se muestra mensaje de exito y se actualiza la lista
                                MessageBoxCustom.Show("El Chofer se ha desactivado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                                LlenarListaUsuarios(checkActivos.Checked);


                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error y no se desactivo el chofer!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Se trato de desactivar de manera fallida un chofer. Intento del Usuario: " + Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName;
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            }
                        }

                    }
                    else
                    {

                        string Mensaje = string.Format("Desea Continuar con la Activacion del Chofer {0}?", MiChofer.FullName);

                        DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "???", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (Continuar == DialogResult.Yes)
                        {
                            if (MiChofer.Activar())
                            {
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Activación: ID Chofer " + txtIDChofer.Text.Trim() + " realizada por el Usuario: " + Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName;
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                                // se muestra mensaje de exito y se actualiza la lista
                                MessageBoxCustom.Show("El Chofer se ha Activado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                                LlenarListaUsuarios(checkActivos.Checked);

                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error y no se activo el chofer!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Se trato de activar de manera fallida un chofer. Intento del Usuario: " + Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName;
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBoxCustom.Show("Permiso NO concedido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
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

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.SelectAll();
        }
    }
}
