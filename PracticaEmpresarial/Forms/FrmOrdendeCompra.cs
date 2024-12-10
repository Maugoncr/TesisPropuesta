using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomMessageBox;
using Logica.Models;
using Microsoft.Win32.SafeHandles;
using PracticaEmpresarial.Commons;
using System.Drawing.Printing;

namespace PracticaEmpresarial.Forms
{
    public partial class FrmOrdendeCompra : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private OrdenCompra MiOrden { get; set; }
        private DataTable ListaOrdenesCompra { get; set; }

        public FrmOrdendeCompra()
        {
            InitializeComponent();
            MiOrden = new OrdenCompra();
            ListaOrdenesCompra = new DataTable();
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

        public void CargarCombos()
        {
            // Same for Companies
            DataTable DatosCompanies = new DataTable();

            DatosCompanies = MiOrden.MiCompanyOrden.ListarForCombo();

            cbCompany.ValueMember = "IDCompany";

            cbCompany.DisplayMember = "Nombre";

            cbCompany.DataSource = DatosCompanies;

            cbCompany.SelectedIndex = -1;

            // Same for Places

            DataTable DatosPlaces = new DataTable();

            DatosPlaces = MiOrden.MiPlaceOrden.Listar();

            cbPlace.ValueMember = "IDPlace";

            cbPlace.DisplayMember = "Descripcion";

            cbPlace.DataSource = DatosPlaces;

            cbPlace.SelectedIndex = -1;

            //Almost Same Users

            DataTable DatosUsuariosAutorizadores = new DataTable();

            DatosUsuariosAutorizadores = MiOrden.MiUsuarioOrden.ListarUsuariosAutorizados();

            cbUser.ValueMember = "IDUser";

            cbUser.DisplayMember = "FullName";

            cbUser.DataSource = DatosUsuariosAutorizadores;

            cbUser.SelectedIndex = -1;


        }

        private void FrmOrdendeCompra_Load(object sender, EventArgs e)
        {
            CargarCombos();
            LimpiarFormulario();
            LlenarListaOrdenes(checkActivos.Checked);
        }

        private void LlenarListaOrdenes(bool VerActivos, string FiltroBusqueda = "")
        {

            string Filtro = "";


            if (!string.IsNullOrEmpty(FiltroBusqueda) &&
                FiltroBusqueda != "Buscar...")
            {
                Filtro = FiltroBusqueda;

            }

            ListaOrdenesCompra = MiOrden.Listar(VerActivos,Filtro);

            DgvListaM.DataSource = ListaOrdenesCompra;

            DgvListaM.ClearSelection();

        }


        private void LimpiarFormulario(bool LimpiarBusqueda = true)
            {

                txtIDCarro.Clear();
                txtPlaca.Clear();
                txtIDOrdenCompra.Clear();
                txtCodigoOrden.Clear();
                txtDetalleOrdenCompra.ResetText();
                txtIDChofer.ResetText();
                txtNombreChofer.Clear();
                cbPlace.SelectedIndex = -1;
                cbCompany.SelectedIndex = -1;
                cbUser.SelectedIndex = -1;
                DTFechaOrdenCompra.ResetText();
                txtCosto.Clear();

                txtArchivo.Clear();
                txtArchivo2.Clear();

                checkIsGasto.Checked = false;
                checkIsMantenimiento.Checked = false;

        

                if (LimpiarBusqueda)
                {
                    txtFiltro.Text = "Buscar...";
                }
                // al reinstanciar el objeto local se eliminan todos los datos de los atributos
                MiOrden = new OrdenCompra();

                ActivarAgregar();

            }

        private void ActivarAgregar()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnDesactivar.Enabled = false;
            btnVerArchivo.Enabled = false;
            btnVerArchivo2.Enabled = false;
        }



        public static int IDChofer;
        public static string NombreChofer;
        private void btnBuscarChofer_Click(object sender, EventArgs e)
        {
            FrmSelectChofer.DesdeOrden = true;

            Form FormSelectChofer = new FrmSelectChofer();

            DialogResult result = FormSelectChofer.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtIDChofer.Text = IDChofer.ToString();
                txtNombreChofer.Text = NombreChofer;
            }
        }

        private void btnLimpiarChofer_Click(object sender, EventArgs e)
        {
            txtIDChofer.Clear();
            txtNombreChofer.Clear();
        }

        public static int IDCarro;
        public static string Placa;
        private void btnBuscarCarro_Click(object sender, EventArgs e)
        {
            FrmSelectVehiculos.DesdeOrden = true;

            Form FormSelectVehiculo = new FrmSelectVehiculos();

            DialogResult result = FormSelectVehiculo.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtIDCarro.Text = IDCarro.ToString();
                txtPlaca.Text = Placa;
            }
        }

        private void txtIDCarro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDCarro.Text.Trim()))
            {
                MiOrden.MiVehiculoOrden.IDCarro = Convert.ToInt32(txtIDCarro.Text.Trim());
            }
            else
            {
                MiOrden.MiVehiculoOrden.IDCarro = 0;
            }
        }

        private void txtIDChofer_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDChofer.Text.Trim()))
            {
                MiOrden.MiChoferOrden.IDChofer = Convert.ToInt32(txtIDChofer.Text.Trim());
            }
            else
            {
                MiOrden.MiChoferOrden.IDChofer = 0;
            }
        }

        private void btnLimpiarCarro_Click(object sender, EventArgs e)
        {
            txtIDCarro.Clear();
            txtPlaca.Clear();
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || e.KeyChar == 47)
            {
                MessageBoxCustom.Show("Solo se pueden ingresar números", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCosto.Text.Trim()))
            {
                MiOrden.Costo = Convert.ToDouble(txtCosto.Text.Trim());

                decimal numero = default(decimal);
                bool bln = decimal.TryParse(txtCosto.Text, out numero);
                if ((!(bln)))
                {
                    txtCosto.Clear();
                    return;
                }

                var cultureinfo = CultureInfo.GetCultureInfo("cr-CR");
                txtCosto.Tag = numero;
                txtCosto.Text = string.Format(cultureinfo, "{0:C2}", numero);

            }
            else
            {
                MiOrden.Costo = 0;
                txtCosto.Tag = null;
            }
        }

        private void txtCosto_Enter(object sender, EventArgs e)
        {
            txtCosto.Text = Convert.ToString(txtCosto.Tag);
        }

        private void checkActivos_Click(object sender, EventArgs e)
        {
            LlenarListaOrdenes(checkActivos.Checked);

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

        private void btnLimpiarArchivo2_Click(object sender, EventArgs e)
        {
            txtArchivo2.Clear();
            Evidencia2 = 0;
            btnVerArchivo2.Enabled = false;
        }

        private void btnLimpiarArchivo_Click(object sender, EventArgs e)
        {
            txtArchivo.Clear();
            Evidencia1 = 0;
            btnVerArchivo.Enabled = false;
        }

        public static bool ParaEvidencia1 = false;
        public static int Evidencia1 = 0;
        public static bool DesdeOrden = false;


        private void btnSelectArchivo_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.PuedesEditar() || ObjetosGlobales.PuedesAgregar())
            {
                ParaEvidencia1 = true;
                DesdeOrden = true;

                Form FormSeleccionar = new FrmGestionArchivos();

                DialogResult result = FormSeleccionar.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtArchivo.Text = Evidencia1.ToString();
                    btnVerArchivo.Enabled = true;
                }
            }
            else
            {
                MessageBoxCustom.Show("Permiso NO concedido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool ParaEvidencia2 = false;
        public static int Evidencia2 = 0;

        private void btnSelectArchivo2_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.PuedesEditar() || ObjetosGlobales.PuedesAgregar())
            {
                DesdeOrden = true;
                ParaEvidencia2 = true;

                Form FormSeleccionar = new FrmGestionArchivos();

                DialogResult result = FormSeleccionar.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtArchivo2.Text = Evidencia2.ToString();
                    btnVerArchivo2.Enabled = true;
                }
            }
            else
            {
                MessageBoxCustom.Show("Permiso NO concedido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtArchivo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArchivo.Text.Trim()))
            {
                MiOrden.MiArchivoOrden.IDImg = Convert.ToInt32(txtArchivo.Text.Trim());
                btnVerArchivo.Enabled = true;
            }
            else
            {
                MiOrden.MiArchivoOrden.IDImg = 0;
            }
        }

        private void txtArchivo2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArchivo2.Text.Trim()))
            {
                MiOrden.MiArchivoOrden2.IDImg = Convert.ToInt32(txtArchivo2.Text.Trim());
                btnVerArchivo2.Enabled = true;
            }
            else
            {
                MiOrden.MiArchivoOrden2.IDImg = 0;
            }
        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArchivo.Text) && txtArchivo.Text != "0")
            {
                int id = Convert.ToInt32(txtArchivo.Text);
                MiOrden.MiArchivoOrden.IDImg = id;
                var Lista = new List<Archivo>();
                Lista = MiOrden.MiArchivoOrden.FiltroArchivos();

                foreach (Archivo item in Lista)
                {
                    // Crear carpeta temporal donde guardamos el archivo
                    string direccion = AppDomain.CurrentDomain.BaseDirectory;
                    string carpeta = direccion + "/temp/";
                    string ubicacionCompleta = carpeta + item.Extension;

                    if (!Directory.Exists(carpeta))
                        Directory.CreateDirectory(carpeta);

                    if (File.Exists(ubicacionCompleta))
                        File.Delete(ubicacionCompleta);

                    File.WriteAllBytes(ubicacionCompleta, item.Documento);
                    Process.Start(ubicacionCompleta);

                }

            }
            else
            {
                if (string.IsNullOrEmpty(txtArchivo.Text))
                {
                    MessageBoxCustom.Show("No has seleccionado ningun archivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (txtArchivo.Text == "0")
                {
                    MessageBoxCustom.Show("No se ha incluido evidencia aún", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnVerArchivo2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArchivo2.Text) && txtArchivo2.Text != "0")
            {
                int id = Convert.ToInt32(txtArchivo2.Text);
                MiOrden.MiArchivoOrden2.IDImg = id;
                var Lista = new List<Archivo>();
                Lista = MiOrden.MiArchivoOrden2.FiltroArchivos();
                foreach (Archivo item in Lista)
                {
                    // Crear carpeta temporal donde guardamos el archivo
                    string direccion = AppDomain.CurrentDomain.BaseDirectory;
                    string carpeta = direccion + "/temp/";
                    string ubicacionCompleta = carpeta + item.Extension;
                    if (!Directory.Exists(carpeta))
                        Directory.CreateDirectory(carpeta);
                    if (File.Exists(ubicacionCompleta))
                        File.Delete(ubicacionCompleta);
                    File.WriteAllBytes(ubicacionCompleta, item.Documento);
                    Process.Start(ubicacionCompleta);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtArchivo2.Text))
                {
                    MessageBoxCustom.Show("No has seleccionado ningun archivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (txtArchivo2.Text == "0")
                {
                    MessageBoxCustom.Show("No se ha incluido evidencia aún", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtCodigoOrden_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoOrden.Text.Trim()))
            {
                MiOrden.Codigo = txtCodigoOrden.Text;
            }
            else
            {
                MiOrden.Codigo = "";
            }
        }

        private void txtDetalleOrdenCompra_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDetalleOrdenCompra.Text.Trim()))
            {
                MiOrden.DetalleOrdenCompra = txtDetalleOrdenCompra.Text;
            }
            else
            {
                MiOrden.DetalleOrdenCompra = "";
            }
        }

        private void DTFechaOrdenCompra_ValueChanged(object sender, EventArgs e)
        {
            MiOrden.FechaParaRealizar = DateTime.ParseExact(DTFechaOrdenCompra.Value.ToString
           ("dd MM yyyy", CultureInfo.InvariantCulture),
           "dd MM yyyy", CultureInfo.InvariantCulture);
        }

        private void checkIsGasto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsGasto.Checked)
            {
                MiOrden.IsGasto = true;
            }
            else
            {
                MiOrden.IsGasto = false;
            }
        }

        private void checkIsMantenimiento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsMantenimiento.Checked)
            {
                MiOrden.IsMantimiento = true;
            }
            else
            {
                MiOrden.IsMantimiento = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.PuedesOrdenesCompra() || ObjetosGlobales.PuedesAgregar() || ObjetosGlobales.EresAdmin())
            {
                if (ValidarDatosRequeridos())
                {

                    string Mensaje = string.Format("¿Desea agregar la orden de compra: {0}?", txtDetalleOrdenCompra.Text);
                    DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Continuar == DialogResult.Yes)
                    {
                        if (cbCompany.Text == "Arvaco")
                        {
                            MiOrden.Codigo = "AR-" + MiOrden.Codigo;
                        }
                        if (cbCompany.Text == "Coarsa")
                        {
                            MiOrden.Codigo = "CO-" + MiOrden.Codigo;
                        }
                        if (cbCompany.Text == "Personal")
                        {
                            MiOrden.Codigo = "PE-" + MiOrden.Codigo;
                        }

                        if (MiOrden.Agregar())
                        {
                            Bitacora MiBitacora = new Bitacora();
                            string accion = "Agregar: Nueva Orden Compra: " + txtCodigoOrden.Text;
                            MiBitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser,ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            MessageBoxCustom.Show("Orden de compra agregada Correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaOrdenes(checkActivos.Checked);
                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error y no se ha guardado la orden de compra", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Bitacora MiBitacora = new Bitacora();
                            string accion = "Agregar Fallido: Nueva Orden Compra";
                            MiBitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser, ObjetosGlobales.MiUsuarioDeSistema.FullName);
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

            if (!string.IsNullOrEmpty(MiOrden.Codigo) &&
                !string.IsNullOrEmpty(MiOrden.DetalleOrdenCompra) &&
                MiOrden.MiPlaceOrden.IDPlace > 0 && MiOrden.MiCompanyOrden.IDCompany > 0 && MiOrden.MiUsuarioOrden.IDUser > 0 &&
                MiOrden.FechaParaRealizar > DateTime.Today.Date.AddDays(-1) && MiOrden.Costo > 0 && MiOrden.IsGasto == true || MiOrden.IsMantimiento == true)
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(MiOrden.Codigo))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Codigo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }

                if (string.IsNullOrEmpty(MiOrden.DetalleOrdenCompra))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Detalle Orden de Compra", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiOrden.MiPlaceOrden.IDPlace == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar la tienda de servicio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiOrden.MiCompanyOrden.IDCompany == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar la compañia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiOrden.MiUsuarioOrden.IDUser == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar el usuario Autorizador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiOrden.IsMantimiento == false && MiOrden.IsGasto == false)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar si es una orden para un gasto, mantenimiento o ambos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiOrden.FechaParaRealizar >= DateTime.Today.Date.AddDays(-1))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar fecha para ejecutar la orden", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiOrden.Costo == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Costo Aproximado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
            }

            return R;
        }

        private bool ValidarDatosRequeridosEdicion()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(MiOrden.Codigo) &&
                !string.IsNullOrEmpty(MiOrden.DetalleOrdenCompra) &&
                MiOrden.MiPlaceOrden.IDPlace > 0 && MiOrden.MiCompanyOrden.IDCompany > 0 && MiOrden.MiUsuarioOrden.IDUser > 0 &&
                MiOrden.Costo > 0 && MiOrden.IsGasto == true || MiOrden.IsMantimiento == true)
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(MiOrden.Codigo))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Codigo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }

                if (string.IsNullOrEmpty(MiOrden.DetalleOrdenCompra))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Detalle Orden de Compra", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiOrden.MiPlaceOrden.IDPlace == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar la tienda de servicio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiOrden.MiCompanyOrden.IDCompany == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar la compañia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiOrden.MiUsuarioOrden.IDUser == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar el usuario Autorizador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiOrden.IsMantimiento == false && MiOrden.IsGasto == false)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar si es una orden para un gasto, mantenimiento o ambos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiOrden.Costo == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Costo Aproximado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
            }

            return R;
        }

        private void cbPlace_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbPlace.SelectedIndex >= 0)
            {
                MiOrden.MiPlaceOrden.IDPlace = Convert.ToInt32(cbPlace.SelectedValue);
            }
            else
            {

                MiOrden.MiPlaceOrden.IDPlace = 0;
            }
        }

        private void cbUser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbUser.SelectedIndex >= 0)
            {
                MiOrden.MiUsuarioOrden.IDUser = Convert.ToInt32(cbUser.SelectedValue);
            }
            else
            {

                MiOrden.MiUsuarioOrden.IDUser = 0;
            }
        }

        private void cbCompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCompany.SelectedIndex >= 0)
            {
                MiOrden.MiCompanyOrden.IDCompany = Convert.ToInt32(cbCompany.SelectedValue);
            }
            else
            {
                MiOrden.MiCompanyOrden.IDCompany= 0;
            }
        }

        private void DgvListaM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaM.SelectedRows.Count == 1)
            {
                LimpiarFormulario(false);

                DataGridViewRow MiFila = DgvListaM.SelectedRows[0];

                int CodigoUsuario = Convert.ToInt32(MiFila.Cells["CIDOrdenCompra"].Value);

                MiOrden = MiOrden.ConsultarPorID(CodigoUsuario);

                txtIDOrdenCompra.Text = MiOrden.IDOrdenCompra.ToString();
                txtCodigoOrden.Text = MiOrden.Codigo;
                txtDetalleOrdenCompra.Text = MiOrden.DetalleOrdenCompra;

                cbCompany.SelectedValue = MiOrden.MiCompanyOrden.IDCompany;
                cbPlace.SelectedValue = MiOrden.MiPlaceOrden.IDPlace;
                cbUser.SelectedValue = MiOrden.MiUsuarioOrden.IDUser;

                DTFechaOrdenCompra.Text = MiOrden.FechaParaRealizar.ToString();

                txtCosto.Text = MiOrden.Costo.ToString();
                txtCosto.Tag = MiOrden.Costo.ToString();

                checkIsGasto.Checked = MiOrden.IsGasto;
                checkIsMantenimiento.Checked = MiOrden.IsMantimiento;

                if (MiOrden.MiArchivoOrden.IDImg != 0)
                {
                    txtArchivo.Text = MiOrden.MiArchivoOrden.IDImg.ToString();
                }
                if (MiOrden.MiArchivoOrden2.IDImg != 0)
                {
                    txtArchivo2.Text = MiOrden.MiArchivoOrden2.IDImg.ToString();
                }

                if (MiOrden.MiVehiculoOrden.IDCarro > 0)
                {
                    txtIDCarro.Text = MiOrden.MiVehiculoOrden.IDCarro.ToString();
                    txtPlaca.Text = MiOrden.MiVehiculoOrden.Placa;
                }
                if (MiOrden.MiChoferOrden.IDChofer > 0)
                {
                    txtIDChofer.Text = MiOrden.MiChoferOrden.IDChofer.ToString();
                    txtNombreChofer.Text = MiOrden.MiChoferOrden.FullName;
                }

                ActivarEditaryEliminar();

            }
        }

        private void ActivarEditaryEliminar()
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
            btnDesactivar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin() || ObjetosGlobales.PuedesEditar() || ObjetosGlobales.PuedesOrdenesCompra())
            {
                if (ValidarDatosRequeridosEdicion())
                {

                    OrdenCompra OrdenTemp = MiOrden.ConsultarPorID(MiOrden.IDOrdenCompra);
                    if (OrdenTemp.IDOrdenCompra > 0)
                    {
                        string Mensaje = string.Format("Desea Continuar con la Modificacion de la orden de compra: {0} Codigo: {1}?", MiOrden.DetalleOrdenCompra, MiOrden.Codigo);

                        DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (Continuar == DialogResult.Yes)
                        {
                            if (MiOrden.Editar())
                            {
                                Bitacora MiBitacora = new Bitacora();
                                string accion = "Actualizar: Se modificio la Orden de Compra: " + MiOrden.Codigo;
                                MiBitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser, ObjetosGlobales.MiUsuarioDeSistema.FullName);
                                // se muestra mensaje de exito y se actualiza la lista
                                MessageBoxCustom.Show("La Orden de compra se ha actualizado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                                LlenarListaOrdenes(checkActivos.Checked);
                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error y no se actualizo la orden de compra!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Bitacora MiBitacora = new Bitacora();
                                string accion = "Actualizar Fallido: Se intento modificar la orden de compra: " + MiOrden.Codigo;
                                MiBitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser, ObjetosGlobales.MiUsuarioDeSistema.FullName);

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
                OrdenCompra ObjOrdenTemp = MiOrden.ConsultarPorID(MiOrden.IDOrdenCompra);

                if (ObjOrdenTemp.IDOrdenCompra > 0)
                {
                    if (checkActivos.Checked)
                    {
                        string Mensaje = string.Format("Desea Continuar con la Desactivación de la Orden de compra: {0}?", MiOrden.Codigo);

                        DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (Continuar == DialogResult.Yes)
                        {
                            if (MiOrden.Eliminar())
                            {
                                Bitacora MiBitacora = new Bitacora();
                                string accion = "Desactivación: Orden de Compra: " + txtCodigoOrden.Text.Trim() + " realizada por el Usuario: " + ObjetosGlobales.MiUsuarioDeSistema.FullName;
                                MiBitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser, ObjetosGlobales.MiUsuarioDeSistema.FullName);
                                // se muestra mensaje de exito y se actualiza la lista
                                MessageBoxCustom.Show("La Orden de compra se ha desactivado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                                LlenarListaOrdenes(checkActivos.Checked);


                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error y no se desactivo la orden de compra!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Bitacora MiBitacora = new Bitacora();
                                string accion = "Se trato de desactivar de manera fallida una Orden de Compra. Intento del Usuario: " + ObjetosGlobales.MiUsuarioDeSistema.FullName;
                                MiBitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser, ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            }
                        }

                    }
                    else
                    {

                        string Mensaje = string.Format("Desea Continuar con la Activacion de la orden de compra: {0}?", MiOrden.Codigo);

                        DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (Continuar == DialogResult.Yes)
                        {
                            if (MiOrden.Activar())
                            {
                                Bitacora MiBitacora = new Bitacora();
                                string accion = "Activación: Orden Compra Código: " + txtCodigoOrden.Text.Trim() + " realizada por el Usuario: " + ObjetosGlobales.MiUsuarioDeSistema.FullName;
                                MiBitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser, ObjetosGlobales.MiUsuarioDeSistema.FullName);
                                // se muestra mensaje de exito y se actualiza la lista
                                MessageBoxCustom.Show("El Vehiculo se ha Activado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                                LlenarListaOrdenes(checkActivos.Checked);

                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error y no se activo la Orden de Compra!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Bitacora MiBitacora = new Bitacora();
                                string accion = "Se trato de activar de manera fallida una Orden de Compra. Intento del Usuario: " + ObjetosGlobales.MiUsuarioDeSistema.FullName;
                                MiBitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser, ObjetosGlobales.MiUsuarioDeSistema.FullName);
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

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltro.Text.Trim()) && txtFiltro.Text.Count() >= 2)
            {
                LlenarListaOrdenes(checkActivos.Checked, txtFiltro.Text.Trim());

            }
            else
            {
                LlenarListaOrdenes(checkActivos.Checked);

            }
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.SelectAll();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportaraexcel(DgvListaM);
        }

        public void Exportaraexcel(DataGridView tabla)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.HeaderText;
            }
            int IndeceFila = 0;
            foreach (DataGridViewRow row in tabla.Rows)
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }

        private int SubdividirString(string cadenaTotal)
        {
            string R = cadenaTotal;
            int renglones = 1;

            if (R.Length <= 24)
            {
                renglones = 1;
            } 
            if (R.Length <= 48)
            {
                renglones = 2;
            } 
            if (R.Length <= 72)
            {
                renglones = 3;
            } 
            if (R.Length <= 96)
            {
                renglones = 4;
            }

            return renglones;
            
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial",14);
            int ancho = 300;
            int y = 20;

            int AlturaParaDetalle=25;
            int YParaCosto = 30;


            int calculo = SubdividirString(txtDetalleOrdenCompra.Text);
            switch (calculo)
            {
                case 1:
                    //25 de alto funciona
                    AlturaParaDetalle = 25;
                    YParaCosto = 30;
                    break;
                case 2:
                    // 50 alto, 60 para costo de espacio
                    AlturaParaDetalle = 50;
                    YParaCosto = 60;
                    break;
                case 3:
                    // 75 alto, 80 para costo de espacio
                    AlturaParaDetalle = 75;
                    YParaCosto = 80;
                    break;
                case 4:
                    AlturaParaDetalle = 100;
                    YParaCosto = 100;
                    break;
            }


            e.Graphics.DrawString("    --- Orden de Compra ---",font,Brushes.Black,new RectangleF(0,y += 20,ancho,25));
            e.Graphics.DrawString("• Num Orden: #" + txtCodigoOrden.Text,font,Brushes.Black,new RectangleF(0,y += 30,ancho,25));
            e.Graphics.DrawString("• Detalle:",font,Brushes.Black,new RectangleF(0,y += 25,ancho,25));
            
            // No son constantes cambia segun cantidad de caracteres tenga la orden

            e.Graphics.DrawString(txtDetalleOrdenCompra.Text,font,Brushes.Black,new RectangleF(0,y += 25, ancho ,AlturaParaDetalle));
            e.Graphics.DrawString("• Costo: ₡" + txtCosto.Text,font,Brushes.Black,new RectangleF(0,y += YParaCosto, ancho,25));
            
            
            e.Graphics.DrawString("        --- Más Detalles ---", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 25));
            e.Graphics.DrawString("• Lugar: " + cbPlace.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 25));
            e.Graphics.DrawString("• Fecha Programada: " + DTFechaOrdenCompra.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 25));
            e.Graphics.DrawString("• Fecha Impresión: " + DateTime.Today.Date.ToShortDateString(), font, Brushes.Black, new RectangleF(0, y += 30, ancho, 25));
            if (!string.IsNullOrEmpty(txtIDCarro.Text))
            {
                e.Graphics.DrawString("• Placa: " + txtPlaca.Text, font, Brushes.Black, new RectangleF(0, y += 40, ancho, 25));
            }
            if (!string.IsNullOrEmpty(txtIDChofer.Text))
            {
                e.Graphics.DrawString("• Chofer: " + txtNombreChofer.Text, font, Brushes.Black, new RectangleF(0, y += 25, ancho, 25));
            }
            e.Graphics.DrawString("           --- Gracias ---", font, Brushes.Black, new RectangleF(0, y += 50, ancho, 25));


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (DgvListaM.SelectedRows.Count > 0)
            {

                MiOrden.ImpresionMarcarFecha(Convert.ToInt32(DgvListaM.SelectedRows[0].Cells["CIDOrdenCompra"].Value));
                LimpiarFormulario();
                LlenarListaOrdenes(checkActivos.Checked);

                printDocument1 = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument1.PrinterSettings = ps;
                printDocument1.PrintPage += Imprimir;
                printDocument1.Print();

            }
            else
            {
                MessageBoxCustom.Show("Primero debes seleccionar cual Orden Imprimir", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }


    }
}
