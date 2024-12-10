using CustomMessageBox;
using PracticaEmpresarial.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEmpresarial.Forms
{
    public partial class FrmGestionVehiculos : Form
    {

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Logica.Models.Vehiculo MiVehiculo { get; set; }
        private DataTable ListaVehiculos { get; set; }
        public FrmGestionVehiculos()
        {
            InitializeComponent();
            MiVehiculo = new Logica.Models.Vehiculo();
            ListaVehiculos = new DataTable();

        }
        private void CargarComboRoles()
        {
            // Para los tipos de vehiculos
            DataTable DatosDeTipos = new DataTable();

            DatosDeTipos = MiVehiculo.MiTipo.Listar();

            cbTipoVehiculo.ValueMember = "IDTipo";

            cbTipoVehiculo.DisplayMember = "Descripcion";

            cbTipoVehiculo.DataSource = DatosDeTipos;

            cbTipoVehiculo.SelectedIndex = -1;

            // Same for choferes

            DataTable DatosChoferes = new DataTable();

            DatosChoferes = MiVehiculo.MiChofer.ListarForCombo();

            cbChofer.ValueMember = "IDChofer";

            cbChofer.DisplayMember = "FullName";

            cbChofer.DataSource = DatosChoferes;

            cbChofer.SelectedIndex = -1;

            // Same for Companies
            DataTable DatosCompanies = new DataTable();

            DatosCompanies = MiVehiculo.MiCompany.ListarForCombo();

            cbCompany.ValueMember = "IDCompany";

            cbCompany.DisplayMember = "Nombre";

            cbCompany.DataSource = DatosCompanies;

            cbCompany.SelectedIndex = -1;

        }

        private void FrmGestionVehiculos_Load(object sender, EventArgs e)
        {
            CargarComboRoles();

            LlenarListaVehiculos(checkActivos.Checked);

            LimpiarFormulario();
        }
        private void LlenarListaVehiculos(bool VerActivos, string FiltroBusqueda = "")
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


            ListaVehiculos = MiVehiculo.Listar(VerActivos, Filtro);

            DgvListaUsuarios.DataSource = ListaVehiculos;

            DgvListaUsuarios.ClearSelection();

        }

        private void LimpiarFormulario(bool LimpiarBusqueda = true)
        {

            txtIDCarro.Clear();
            txtPlaca.Clear();
            txtMarca.Clear();
            txtAnio.Clear();
            txtLicencia.ResetText();
            DpOilDate.ResetText();
            txtMarchamo.Clear();
            cbChofer.SelectedIndex = -1;
            cbTipoVehiculo.SelectedIndex = -1;
            cbCompany.SelectedIndex = -1;
            DateTimeRTV.ResetText();
            txtKilometraje.Clear();

            lbLicencia.Visible = false;
            txtLicencia.Visible = false;

            if (LimpiarBusqueda)
            {
                txtFiltro.Text = "Buscar...";
            }
            // al reinstanciar el objeto local se eliminan todos los datos de los atributos
            MiVehiculo = new Logica.Models.Vehiculo();

            ActivarAgregar();

        }
        private void ActivarAgregar()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnDesactivar.Enabled = false;

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.SelectAll();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltro.Text.Trim()) && txtFiltro.Text.Count() >= 2)
            {
                LlenarListaVehiculos(checkActivos.Checked, txtFiltro.Text.Trim());

            }
            else
            {
                LlenarListaVehiculos(checkActivos.Checked);

            }
        }

        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaUsuarios.SelectedRows.Count == 1)
            {
                LimpiarFormulario(false);

                DataGridViewRow MiFila = DgvListaUsuarios.SelectedRows[0];

                int CodigoUsuario = Convert.ToInt32(MiFila.Cells["CIDCarro"].Value);

                MiVehiculo = MiVehiculo.ConsultarPorID(CodigoUsuario);

                txtIDCarro.Text = MiVehiculo.IDCarro.ToString();
                txtPlaca.Text = MiVehiculo.Placa;
                txtMarca.Text = MiVehiculo.Marca;
                txtMarchamo.Text = MiVehiculo.Marchamo.ToString();
                txtAnio.Text = MiVehiculo.Anio;

                if (MiVehiculo.LicenciaCamionesVencimiento > DateTime.Today.Date)
                {
                    lbLicencia.Visible = true;
                    txtLicencia.Visible = true;
                    txtLicencia.Text = MiVehiculo.LicenciaCamionesVencimiento.ToString();
                }

                DpOilDate.Text = MiVehiculo.OilDate.ToString();
                DateTimeRTV.Text = MiVehiculo.RTV.ToString();
                txtKilometraje.Text = MiVehiculo.Kilometraje.ToString();

                cbCompany.SelectedValue = MiVehiculo.MiCompany.IDCompany;
                cbChofer.SelectedValue = MiVehiculo.MiChofer.IDChofer;
                cbTipoVehiculo.SelectedValue = MiVehiculo.MiTipo.IDTipo;


                ActivarEditaryEliminar();

            }
        }

        private void ActivarEditaryEliminar()
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
            btnDesactivar.Enabled = true;
            
        }

        private void checkActivos_Click(object sender, EventArgs e)
        {
            LlenarListaVehiculos(checkActivos.Checked);

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

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPlaca.Text.Trim()))
            {
                MiVehiculo.Placa = txtPlaca.Text.Trim();

            }
            else
            {

                MiVehiculo.Placa = "";
            }
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMarca.Text.Trim()))
            {
                MiVehiculo.Marca = txtMarca.Text.Trim();

            }
            else
            {

                MiVehiculo.Marca = "";
            }
        }

        private void txtAnio_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAnio.Text.Trim()) && txtAnio.Text.Length == 4)
            {
                MiVehiculo.Anio = txtAnio.Text.Trim();

            }
            else if (!string.IsNullOrEmpty(txtAnio.Text.Trim()))
            {
                MessageBoxCustom.Show("Formato de año Incorrecto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MiVehiculo.Anio = "";
            }
            else {
                MiVehiculo.Anio = "";
            }

        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBoxCustom.Show("Solo se pueden ingresar números", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtMarchamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBoxCustom.Show("Solo se pueden ingresar números", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtMarchamo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMarchamo.Text.Trim()) && txtMarchamo.Text.Length == 4)
            {
                MiVehiculo.Marchamo = Convert.ToInt32(txtMarchamo.Text);

            }
            else if (!string.IsNullOrEmpty(txtMarchamo.Text.Trim()))
            {
                MessageBoxCustom.Show("Formato de año Incorrecto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MiVehiculo.Marchamo = 0;
            }
            else {
                MiVehiculo.Marchamo = 0;
            }
        }

    

        private void cbTipoVehiculo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbTipoVehiculo.SelectedIndex >= 0)
            {
                MiVehiculo.MiTipo.IDTipo = Convert.ToInt32(cbTipoVehiculo.SelectedValue);
            }
            else
            {

                MiVehiculo.MiTipo.IDTipo = 0;
            }

            if (cbTipoVehiculo.Text == "Camion" || cbTipoVehiculo.Text == "Camión" ||
                    cbTipoVehiculo.Text == "Camiones")
            {
                lbLicencia.Visible = true;
                txtLicencia.Visible = true;
            }else
            {
                lbLicencia.Visible = false;
                txtLicencia.Visible = false;
                txtLicencia.ResetText();
                MiVehiculo.LicenciaCamionesVencimiento = DateTime.Today.Date;

            }

        }

        private void cbChofer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbChofer.SelectedIndex >= 0)
            {
                MiVehiculo.MiChofer.IDChofer = Convert.ToInt32(cbChofer.SelectedValue);
            }
            else
            {

                MiVehiculo.MiChofer.IDChofer = 0;
            }
        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            //string fecha = DateTime.Today.ToString("MM/yyyy", CultureInfo.InvariantCulture);
            //DateTime validar = DateTime.Parse("01/01/0001 12:00:00 a.m");
            if (txtLicencia.Visible == true)
            {
                if (MiVehiculo.LicenciaCamionesVencimiento > DateTime.Today.Date)
                {

                }
                else
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Vencimiento de la licencia para el camion", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
            }

            if (!string.IsNullOrEmpty(MiVehiculo.Placa) &&
                !string.IsNullOrEmpty(MiVehiculo.Marca) &&
                !string.IsNullOrEmpty(MiVehiculo.Anio) &&
                MiVehiculo.MiTipo.IDTipo > 0 && MiVehiculo.MiChofer.IDChofer > 0 && MiVehiculo.Marchamo > 0 &&
                MiVehiculo.RTV > DateTime.Today.Date && MiVehiculo.MiCompany.IDCompany > 0 && MiVehiculo.OilDate > DateTime.Today.Date
                && MiVehiculo.Kilometraje > 0)
            {
                    R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(MiVehiculo.Placa))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Placa", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }

                if (string.IsNullOrEmpty(MiVehiculo.Marca))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Marca", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }

                if (string.IsNullOrEmpty(MiVehiculo.Anio))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Año del Vehiculo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiVehiculo.MiTipo.IDTipo == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar el tipo de vehiculo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                } if (MiVehiculo.Kilometraje == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Kilometraje", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiVehiculo.MiChofer.IDChofer == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar el chofer", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }if (MiVehiculo.MiCompany.IDCompany == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar la compañia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiVehiculo.RTV < DateTime.Today.Date)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Proximo RTV", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiVehiculo.OilDate < DateTime.Today.Date)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Aproximado del proximo cambio de aceite", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }

            }

            return R;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin() || ObjetosGlobales.PuedesAgregar())
            {
                if (ValidarDatosRequeridos())
                {
                    bool OkPlaca = MiVehiculo.ConsultarPorPlaca(MiVehiculo.Placa);

                    if (!OkPlaca)
                    {
                        string Mensaje = string.Format("¿Desea agregar el vehiculo con la placa: {0}?", MiVehiculo.Placa);
                        DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (Continuar == DialogResult.Yes)
                        {
                            if (MiVehiculo.Agregar())
                            {
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Agregar: Nuevo Vehiculo: " + txtPlaca.Text.Trim();
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                                MessageBoxCustom.Show("Vehiculo Agregado Correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                                LlenarListaVehiculos(checkActivos.Checked);
                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error y no se ha guardado el vehiculo", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Agregar Fallido: Nuevo Vehiculo";
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            }
                        }
                    }
                    else
                    {
                        if (OkPlaca)
                        {
                            MessageBoxCustom.Show("Ya existe un vehiculo con la placa digitada", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            else
            {
                MessageBoxCustom.Show("Permiso de agregar NO concedido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DateTimeRTV_ValueChanged(object sender, EventArgs e)
        {
            if (DateTimeRTV.Value.Date > DateTime.Today.Date)
            {
                MiVehiculo.RTV = DateTime.ParseExact(DateTimeRTV.Value.ToString("MM yyyy", CultureInfo.InvariantCulture),
                    "MM yyyy", CultureInfo.InvariantCulture);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin() || ObjetosGlobales.PuedesEditar())
            {
                if (ValidarDatosRequeridos())
                {

                    Logica.Models.Vehiculo vehiculoTemp = MiVehiculo.ConsultarPorID(MiVehiculo.IDCarro);
                    if (vehiculoTemp.IDCarro > 0)
                    {

                        string Mensaje = string.Format("Desea Continuar con la Modificacion del vehiculo con placa: {0}?", MiVehiculo.Placa);

                        DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (Continuar == DialogResult.Yes)
                        {

                            if (MiVehiculo.Editar())
                            {
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Actualizar: Se modificio el vehiculo: " + MiVehiculo.Placa;
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                                // se muestra mensaje de exito y se actualiza la lista
                                MessageBoxCustom.Show("El vehiculo se ha actualizado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                                LlenarListaVehiculos(checkActivos.Checked);
                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error y no se actualizo el vehiculo!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Actualizar Fallido: Se intento modificar el vehiculo: " + MiVehiculo.Placa;
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
                Logica.Models.Vehiculo ObjVehiculoTemporal = MiVehiculo.ConsultarPorID(MiVehiculo.IDCarro);

                if (ObjVehiculoTemporal.IDCarro > 0)
                {
                    if (checkActivos.Checked)
                    {
                        string Mensaje = string.Format("Desea Continuar con la Desactivación del vehiculo placa: {0}?", MiVehiculo.Placa);

                        DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (Continuar == DialogResult.Yes)
                        {
                            if (MiVehiculo.Eliminar())
                            {
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Desactivación: Vehiculo Placa: " + txtPlaca.Text.Trim() + " realizada por el Usuario: " + Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName;
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                                // se muestra mensaje de exito y se actualiza la lista
                                MessageBoxCustom.Show("El Vehiculo se ha desactivado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                                LlenarListaVehiculos(checkActivos.Checked);


                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error y no se desactivo el vehiculo!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Se trato de desactivar de manera fallida un vehiculo. Intento del Usuario: " + Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName;
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            }
                        }

                    }
                    else
                    {

                        string Mensaje = string.Format("Desea Continuar con la Activacion del vehiculo placa: {0}?", MiVehiculo.Placa);

                        DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "???", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (Continuar == DialogResult.Yes)
                        {
                            if (MiVehiculo.Activar())
                            {
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Activación: Vehiculo Placa: " + txtPlaca.Text.Trim() + " realizada por el Usuario: " + Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName;
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                                // se muestra mensaje de exito y se actualiza la lista
                                MessageBoxCustom.Show("El Vehiculo se ha Activado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                                LlenarListaVehiculos(checkActivos.Checked);

                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error y no se activo el vehiculo!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Se trato de activar de manera fallida un vehiculo. Intento del Usuario: " + Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName;
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

        private void DpOilDate_ValueChanged(object sender, EventArgs e)
        {
          
            if (DpOilDate.Value.Date > DateTime.Today.Date)
            {
                MiVehiculo.OilDate = DateTime.ParseExact(DpOilDate.Value.ToString("MM yyyy", CultureInfo.InvariantCulture),
                    "MM yyyy", CultureInfo.InvariantCulture);
            }

        }

        private void txtLicencia_ValueChanged(object sender, EventArgs e)
        {
            if (txtLicencia.Value.Date > DateTime.Today.Date)
            {
                MiVehiculo.LicenciaCamionesVencimiento = DateTime.ParseExact(txtLicencia.Value.ToString("MM yyyy", CultureInfo.InvariantCulture),
                    "MM yyyy", CultureInfo.InvariantCulture);
            }
        }

        private void cbCompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCompany.SelectedIndex >= 0)
            {
                MiVehiculo.MiCompany.IDCompany = Convert.ToInt32(cbCompany.SelectedValue);
            }
            else
            {

                MiVehiculo.MiCompany.IDCompany = 0;
            }
        }

     

        private void checkArvaco_CheckedChanged(object sender, EventArgs e)
        {
            if (checkArvaco.Checked)
            {
                checkCoarsa.Enabled = false;
                checkCoarsa.Checked = false;
                txtFiltro.Text = "Arvaco";
            }
            else
            {
                checkCoarsa.Enabled = true;
                txtFiltro.Text = "Buscar...";
            }
        }

        private void checkCoarsa_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkCoarsa.Checked)
            {
                checkArvaco.Enabled = false;
                checkArvaco.Checked = false;
                txtFiltro.Text = "Coarsa";
            }
            else
            {
                checkArvaco.Enabled = true;
                txtFiltro.Text = "Buscar...";
            }
        }

        private void txtKilometraje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBoxCustom.Show("Solo se pueden ingresar números", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtKilometraje_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKilometraje.Text.Trim()))
            {
                MiVehiculo.Kilometraje = Convert.ToInt32(txtKilometraje.Text.Trim());
            }
            else
            {
                MiVehiculo.Kilometraje = 0;
            }
        }
    }
}
