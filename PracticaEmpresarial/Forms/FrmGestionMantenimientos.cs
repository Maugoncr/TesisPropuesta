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
using PracticaEmpresarial.Commons;

namespace PracticaEmpresarial.Forms
{
    public partial class FrmGestionMantenimientos : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //INICIALIZADORES
        private Mantenimiento MiMantenimiento { get; set; }
        private DataTable ListaMantenimientos { get; set; }

        public FrmGestionMantenimientos()
        {
            InitializeComponent();

            MiMantenimiento = new Mantenimiento();

            ListaMantenimientos = new DataTable();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGestionMantenimientos_Load(object sender, EventArgs e)
        {
            CargarCombos();
            LlenarListaMantenimientos();
            LimpiarFormulario();
        }

        private void LlenarListaMantenimientos(string FiltroBusqueda = "")
        {

            string Filtro = "";


            if (!string.IsNullOrEmpty(FiltroBusqueda) &&
                FiltroBusqueda != "Buscar...")
            {
                Filtro = FiltroBusqueda;

            }

            ListaMantenimientos = MiMantenimiento.Listar(Filtro);

            DgvListaM.DataSource = ListaMantenimientos;

            DgvListaM.ClearSelection();

        }



        private void CargarCombos()
        {

            DataTable DatosDeTipos = new DataTable();

            DatosDeTipos = MiMantenimiento.MiPlaceDelMantenimiento.Listar();

            cbPlace.ValueMember = "IDPlace";

            cbPlace.DisplayMember = "Descripcion";

            cbPlace.DataSource = DatosDeTipos;

            cbPlace.SelectedIndex = -1;

            // Para compañias

            DataTable DatosCompany = new DataTable();

            DatosCompany = MiMantenimiento.MiCompanyDelMantenimiento.ListarForCombo();

            cbCompany.ValueMember = "IDCompany";

            cbCompany.DisplayMember = "Nombre";

            cbCompany.DataSource = DatosCompany;

            cbCompany.SelectedIndex = -1;

            // Para TiposMantenimiento

            DataTable DatosTipoM = new DataTable();

            DatosTipoM = MiMantenimiento.MiTipoMantenimientoDelMantenimiento.Listar();

            cbTipoMantenimiento.ValueMember = "IDTipoMantenimiento";

            cbTipoMantenimiento.DisplayMember = "Detalle";

            cbTipoMantenimiento.DataSource = DatosTipoM;

            cbTipoMantenimiento.SelectedIndex = -1;

        }



        private void cbTipoMantenimiento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbTipoMantenimiento.SelectedIndex >= 0)
            {
                MiMantenimiento.MiTipoMantenimientoDelMantenimiento.IDTipoMantenimiento
                    = Convert.ToInt32(cbTipoMantenimiento.SelectedValue);
            }
            else
            {
                MiMantenimiento.MiTipoMantenimientoDelMantenimiento.IDTipoMantenimiento = 0;
            }

            if (cbTipoMantenimiento.Text == "Combustible")
            {
                CambiarDesign(2);
            }
            else if (cbTipoMantenimiento.Text == "Revisión Técnica")
            {
                CambiarDesign(3);
            }
            else if (cbTipoMantenimiento.Text == "Pago Marchamo")
            {
                CambiarDesign(4);
            }
            else if (cbTipoMantenimiento.Text == "Cambio de Aceite")
            {
                CambiarDesign(5);
            }
            else
            {
                CambiarDesign(1);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtArchivo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArchivo.Text.Trim()))
            {
                MiMantenimiento.MiArchivoDelMantenimiento.IDImg = Convert.ToInt32(txtArchivo.Text.Trim());
                btnVerArchivo.Enabled = true;
            }
            else
            {
                MiMantenimiento.MiArchivoDelMantenimiento.IDImg = 0;
            }
        }

        private void txtArchivo2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArchivo2.Text.Trim()))
            {
                MiMantenimiento.MiArchivo2DelMantenimiento.IDImg = Convert.ToInt32(txtArchivo2.Text.Trim());
                btnVerArchivo2.Enabled = true;
            }
            else
            {
                MiMantenimiento.MiArchivo2DelMantenimiento.IDImg = 0;
            }
        }

        public static bool ParaEvidencia1 = false;
        public static int Evidencia1 = 0;
        public static bool DesdeMantenimientos = false;


        private void btnSelectArchivo_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.PuedesEditar() || ObjetosGlobales.PuedesAgregar())
            {
                ParaEvidencia1 = true;
                DesdeMantenimientos = true;

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
                DesdeMantenimientos = true;
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

        private void btnLimpiarArchivo_Click(object sender, EventArgs e)
        {
            txtArchivo.Clear();
            Evidencia1 = 0;
            btnVerArchivo.Enabled = false;
        }

        private void btnLimpiarArchivo2_Click(object sender, EventArgs e)
        {
            txtArchivo2.Clear();
            Evidencia2 = 0;
            btnVerArchivo2.Enabled = false;
        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArchivo.Text) && txtArchivo.Text != "0")
            {
                int id = Convert.ToInt32(txtArchivo.Text);
                MiMantenimiento.MiArchivoDelMantenimiento.IDImg = id;
                var Lista = new List<Archivo>();
                Lista = MiMantenimiento.MiArchivoDelMantenimiento.FiltroArchivos();

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
                MiMantenimiento.MiArchivo2DelMantenimiento.IDImg = id;
                var Lista = new List<Archivo>();
                Lista = MiMantenimiento.MiArchivo2DelMantenimiento.FiltroArchivos();
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

        


        public static int IDChofer;
        public static string NombreChofer;

        private void btnBuscarChofer_Click(object sender, EventArgs e)
        {

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

        private void txtIDChofer_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDChofer.Text.Trim()))
            {
                MiMantenimiento.MiChoferDelMantenimiento.IDChofer = Convert.ToInt32(txtIDChofer.Text.Trim());
            }
            else
            {
                MiMantenimiento.MiChoferDelMantenimiento.IDChofer = 0;
            }
        }


        public static int IDCarro;
        public static string Placa;
        public static string TipoVehiculo;
        public static int Kilometraje;

        private void btnBuscarCarro_Click(object sender, EventArgs e)
        {
            Form FormSelectVehiculo = new FrmSelectVehiculos();

            DialogResult result = FormSelectVehiculo.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtIDCarro.Text = IDCarro.ToString();
                txtPlaca.Text = Placa;
                txtTipoVehiculo.Text = TipoVehiculo;
                txtKilometrajeAntes.Text = Kilometraje.ToString();
            }
        }


        //DISEÑOS DEL MANTENIMIENTO
        public string ValidarSegunDiseño = "Default";

        public void CambiarDesign(int opcion)
        {
            // Default or others used when the software started
            if (opcion == 1)
            {
                ValidarSegunDiseño = "Default";
                btnCalculator.Visible = false;

                lbKmRecorridos.Visible = false;
                txtKilometrosRecorridos.Visible = false;

                lbCostoKm.Visible = false;
                txtCostoKm.Visible = false;

                lbCostoLitro.Visible = false;
                txtCostoLitro.Visible = false;

                lbCambioAceite.Visible = false;
                DpOilDate.Visible = false;

                lbProximoRTV.Visible = false;
                DateTimeRTV.Visible = false;

                lbProximoMarchamo.Visible = false;
                txtMarchamo.Visible = false;

                lbLitros.Visible = false;
                txtLitros.Visible = false;
            }
            // Combustible
            else if (opcion == 2)
            {
                ValidarSegunDiseño = "Combustible";
                btnCalculator.Visible = true;

                lbKmRecorridos.Visible = true;
                txtKilometrosRecorridos.Visible = true;

                lbCostoKm.Visible = true;
                txtCostoKm.Visible = true;

                lbCostoLitro.Visible = true;
                txtCostoLitro.Visible = true;

                lbLitros.Visible = true;
                txtLitros.Visible = true;

                lbCambioAceite.Visible = false;
                DpOilDate.Visible = false;

                lbProximoRTV.Visible = false;
                DateTimeRTV.Visible = false;

                lbProximoMarchamo.Visible = false;
                txtMarchamo.Visible = false;
            }
            // RTV
            else if (opcion == 3)
            {
                ValidarSegunDiseño = "RTV";
                btnCalculator.Visible = false;

                lbKmRecorridos.Visible = false;
                txtKilometrosRecorridos.Visible = false;

                lbCostoKm.Visible = false;
                txtCostoKm.Visible = false;

                lbCostoLitro.Visible = false;
                txtCostoLitro.Visible = false;

                lbCambioAceite.Visible = false;
                DpOilDate.Visible = false;

                lbProximoRTV.Visible = true;
                DateTimeRTV.Visible = true;

                lbProximoMarchamo.Visible = false;
                txtMarchamo.Visible = false;

                lbLitros.Visible = false;
                txtLitros.Visible = false;
            }
            // Marchamo
            else if (opcion == 4)
            {
                ValidarSegunDiseño = "Marchamo";
                btnCalculator.Visible = false;

                lbKmRecorridos.Visible = false;
                txtKilometrosRecorridos.Visible = false;

                lbCostoKm.Visible = false;
                txtCostoKm.Visible = false;

                lbCostoLitro.Visible = false;
                txtCostoLitro.Visible = false;

                lbCambioAceite.Visible = false;
                DpOilDate.Visible = false;

                lbProximoRTV.Visible = false;
                DateTimeRTV.Visible = false;

                lbProximoMarchamo.Visible = true;
                txtMarchamo.Visible = true;

                lbLitros.Visible = false;
                txtLitros.Visible = false;
            }
            //Aceite
            else if (opcion == 5)
            {
                ValidarSegunDiseño = "CambioDeAceite";
                btnCalculator.Visible = false;

                lbKmRecorridos.Visible = false;
                txtKilometrosRecorridos.Visible = false;

                lbCostoKm.Visible = false;
                txtCostoKm.Visible = false;

                lbCostoLitro.Visible = false;
                txtCostoLitro.Visible = false;

                lbCambioAceite.Visible = true;
                DpOilDate.Visible = true;

                lbProximoRTV.Visible = false;
                DateTimeRTV.Visible = false;

                lbProximoMarchamo.Visible = false;
                txtMarchamo.Visible = false;

                lbLitros.Visible = false;
                txtLitros.Visible = false;

            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltro.Text.Trim()) && txtFiltro.Text.Count() >= 2)
            {
                LlenarListaMantenimientos(txtFiltro.Text.Trim());
            }
            else
            {
                LlenarListaMantenimientos();
            }
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.SelectAll();
        }

        private void LimpiarFormulario(bool LimpiarBusqueda = true)
        {

            txtIDCarro.Clear();
            txtPlaca.Clear();
            txtKilometrajeAntes.Clear();
            txtTipoVehiculo.Clear();
            txtKilometrosRecorridos.Clear();
            txtCostoKm.Clear();
            txtCostoLitro.Clear();
            txtIDChofer.Clear();
            txtNombreChofer.Clear();
            txtIDMantenimiento.Clear();
            txtConsecutivo.Clear();
            txtOrdenCompra.Clear();
            txtArchivo.Clear();
            txtArchivo2.Clear();
            txtDetalle.Clear();
            txtCosto.Clear();
            txtCosto.Tag = null;
            txtLitros.Clear();
            txtMarchamo.Clear();
            txtKilometrajeNuevo.Clear();

            DpOilDate.ResetText();
            DateTimeRTV.ResetText();
            DTFechaMantenimiento.ResetText();

            cbPlace.SelectedIndex = -1;
            cbCompany.SelectedIndex = -1;
            cbTipoMantenimiento.SelectedIndex = -1;

            checkDesactivarOrden.Checked = false;


            if (LimpiarBusqueda)
            {
                txtFiltro.Text = "Buscar...";
            }
            // al reinstanciar el objeto local se eliminan todos los datos de los atributos
            MiMantenimiento = new Mantenimiento();

            ActivarAgregar();
            CambiarDesign(1);

        }

        private void ActivarAgregar()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnVerArchivo.Enabled = false;
            btnVerArchivo2.Enabled = false;
            PaseParaEditar = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        public bool PaseParaEditar = false;
        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            //Valido este seleccionado un tipo de mantenimiento
            if (cbTipoMantenimiento.SelectedIndex >= 0)
            {
                switch (ValidarSegunDiseño) 
                {
                    case "Default":
                        if (MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro > 0 &&
                            MiMantenimiento.MiChoferDelMantenimiento.IDChofer > 0 &&
                            MiMantenimiento.MiPlaceDelMantenimiento.IDPlace > 0 &&
                            MiMantenimiento.MiCompanyDelMantenimiento.IDCompany > 0 &&
                            !string.IsNullOrEmpty(MiMantenimiento.Consecutivo) &&
                            MiMantenimiento.MiOrdenCompraDelMantenimiento.IDOrdenCompra > 0 &&
                            MiMantenimiento.Costo > 0 && MiMantenimiento.Kilometraje > 0)
                       
                        {
                            if (MiMantenimiento.Kilometraje > Convert.ToInt32(txtKilometrajeAntes.Text) || PaseParaEditar)
                            {
                                R = true;
                                return R;
                            }
                            else
                            {
                                MessageBoxCustom.Show("Kilometraje menor al actual", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return R;
                            }
                        }
                        else
                        {
                            //se dice al usuario que le falta
                            if (string.IsNullOrEmpty(MiMantenimiento.Consecutivo))
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Num Factura", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.Costo == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Costo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.Kilometraje == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Nuevo Kilometraje", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiCompanyDelMantenimiento.IDCompany == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar Compañia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiPlaceDelMantenimiento.IDPlace == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar tienda de servicio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiChoferDelMantenimiento.IDChofer == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar chofer", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar vehiculo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiOrdenCompraDelMantenimiento.IDOrdenCompra == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar Orden Compra", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }

                        }
                        break;
                    case "Combustible":
                        if (MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro > 0 &&
                           MiMantenimiento.MiChoferDelMantenimiento.IDChofer > 0 &&
                           MiMantenimiento.MiPlaceDelMantenimiento.IDPlace > 0 &&
                           MiMantenimiento.MiCompanyDelMantenimiento.IDCompany > 0 &&
                           !string.IsNullOrEmpty(MiMantenimiento.Consecutivo) &&
                            MiMantenimiento.MiOrdenCompraDelMantenimiento.IDOrdenCompra > 0 &&
                           MiMantenimiento.Costo > 0 && MiMantenimiento.Kilometraje > 0 &&
                           MiMantenimiento.Litro > 0 && MiMantenimiento.Recorrido > 0 &&
                           MiMantenimiento.CostoKm > 0 && MiMantenimiento.CostoLitro > 0
                           )
                        {
                            if (MiMantenimiento.Kilometraje > Convert.ToInt32(txtKilometrajeAntes.Text) || PaseParaEditar)
                            {
                                R = true;
                                return R;
                            }
                            else
                            {
                                MessageBoxCustom.Show("Kilometraje menor al actual", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return R;
                            }
                        }
                        else
                        {
                            //se dice al usuario que le falta
                            if (string.IsNullOrEmpty(MiMantenimiento.Consecutivo))
                            {
                           
                                MessageBoxCustom.Show("Faltan datos!\n•Num Factura", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.Costo == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Costo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.Kilometraje == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Nuevo Kilometraje", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiCompanyDelMantenimiento.IDCompany == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar Compañia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiPlaceDelMantenimiento.IDPlace == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar tienda de servicio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiChoferDelMantenimiento.IDChofer == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar chofer", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar vehiculo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.Litro == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Litros de gasolina", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.Recorrido == 0 || MiMantenimiento.CostoKm == 0 || MiMantenimiento.CostoLitro == 0)
                            {
                                MessageBoxCustom.Show("• Debes presionar el boton de calcular\n'Icono de calculadora'", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiOrdenCompraDelMantenimiento.IDOrdenCompra == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar Orden Compra", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }

                        }
                        break;
                    case "RTV":
                        if (MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro > 0 &&
                           MiMantenimiento.MiChoferDelMantenimiento.IDChofer > 0 &&
                           MiMantenimiento.MiPlaceDelMantenimiento.IDPlace > 0 &&
                           MiMantenimiento.MiCompanyDelMantenimiento.IDCompany > 0 &&
                           !string.IsNullOrEmpty(MiMantenimiento.Consecutivo) &&
                           MiMantenimiento.MiOrdenCompraDelMantenimiento.IDOrdenCompra > 0 &&
                           MiMantenimiento.Costo > 0 && MiMantenimiento.Kilometraje > 0 &&
                           MiMantenimiento.DateRTV > DateTime.Today.Date)
                        {
                            if (MiMantenimiento.Kilometraje > Convert.ToInt32(txtKilometrajeAntes.Text) || PaseParaEditar)
                            {
                                R = true;
                                return R;
                            }
                            else
                            {
                                MessageBoxCustom.Show("Kilometraje menor al actual", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return R;
                            }
                        }
                        else
                        {
                            //se dice al usuario que le falta
                            if (string.IsNullOrEmpty(MiMantenimiento.Consecutivo))
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Num Factura", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.Costo == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Costo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.Kilometraje == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Nuevo Kilometraje", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiCompanyDelMantenimiento.IDCompany == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar Compañia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiPlaceDelMantenimiento.IDPlace == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar tienda de servicio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiChoferDelMantenimiento.IDChofer == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar chofer", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar vehiculo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.DateRTV <= DateTime.Today.Date)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Elegir proxima Revisión Técnica", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiOrdenCompraDelMantenimiento.IDOrdenCompra == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar Orden Compra", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }

                        }
                        break;
                    case "Marchamo":
                        if (MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro > 0 &&
                           MiMantenimiento.MiChoferDelMantenimiento.IDChofer > 0 &&
                           MiMantenimiento.MiPlaceDelMantenimiento.IDPlace > 0 &&
                           MiMantenimiento.MiCompanyDelMantenimiento.IDCompany > 0 &&
                           !string.IsNullOrEmpty(MiMantenimiento.Consecutivo) &&
                           MiMantenimiento.MiOrdenCompraDelMantenimiento.IDOrdenCompra > 0 &&
                           MiMantenimiento.Costo > 0 && MiMantenimiento.Kilometraje > 0 &&
                           MiMantenimiento.Marchamo > 0)
                        {
                            if (MiMantenimiento.Kilometraje > Convert.ToInt32(txtKilometrajeAntes.Text) || PaseParaEditar)
                            {
                                R = true;
                                return R;
                            }
                            else
                            {
                                MessageBoxCustom.Show("Kilometraje menor al actual", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return R;
                            }
                        }
                        else
                        {
                            //se dice al usuario que le falta
                            if (string.IsNullOrEmpty(MiMantenimiento.Consecutivo))
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Num Factura", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.Costo == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Costo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.Kilometraje == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Nuevo Kilometraje", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiCompanyDelMantenimiento.IDCompany == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar Compañia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiPlaceDelMantenimiento.IDPlace == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar tienda de servicio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiChoferDelMantenimiento.IDChofer == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar chofer", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar vehiculo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.Marchamo == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Proximo Marchamo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiOrdenCompraDelMantenimiento.IDOrdenCompra == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar Orden Compra", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }

                        }
                        break;
                    case "CambioDeAceite":
                        if (MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro > 0 &&
                           MiMantenimiento.MiChoferDelMantenimiento.IDChofer > 0 &&
                           MiMantenimiento.MiPlaceDelMantenimiento.IDPlace > 0 &&
                           MiMantenimiento.MiCompanyDelMantenimiento.IDCompany > 0 &&
                           !string.IsNullOrEmpty(MiMantenimiento.Consecutivo) &&
                           MiMantenimiento.MiOrdenCompraDelMantenimiento.IDOrdenCompra > 0 &&
                           MiMantenimiento.Costo > 0 && MiMantenimiento.Kilometraje > 0 &&
                            MiMantenimiento.OilDate > DateTime.Today.Date)
                        {
                            if (MiMantenimiento.Kilometraje > Convert.ToInt32(txtKilometrajeAntes.Text) || PaseParaEditar)
                            {
                                R = true;
                                return R;
                            }
                            else
                            {
                                MessageBoxCustom.Show("Kilometraje menor al actual", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return R;
                            }
                        }
                        else
                        {
                            //se dice al usuario que le falta
                            if (string.IsNullOrEmpty(MiMantenimiento.Consecutivo))
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Num Factura", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.Costo == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Costo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.Kilometraje == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Nuevo Kilometraje", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiCompanyDelMantenimiento.IDCompany == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar Compañia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiPlaceDelMantenimiento.IDPlace == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar tienda de servicio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiChoferDelMantenimiento.IDChofer == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar chofer", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar vehiculo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.OilDate <= DateTime.Today.Date)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Elegir proximo cambio de aceite", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                            if (MiMantenimiento.MiOrdenCompraDelMantenimiento.IDOrdenCompra == 0)
                            {
                                MessageBoxCustom.Show("Faltan datos!\n•Seleccionar Orden Compra", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return R;
                            }
                        }
                        break;
                }
            }
            else
            {
                MessageBoxCustom.Show("Faltan datos!\n•Tipo de Mantenimiento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return R;
            }

            return R;
        }

        private void txtIDCarro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDCarro.Text.Trim()))
            {
                MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro = Convert.ToInt32(txtIDCarro.Text.Trim());
            }
            else
            {
                MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro = 0;
            }
        }

        private void btnLimpiarCarro_Click(object sender, EventArgs e)
        {
            txtIDCarro.Clear();
            txtPlaca.Clear();
            txtKilometrajeAntes.Clear();
            txtTipoVehiculo.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin() || ObjetosGlobales.PuedesAgregar())
            {
                if (ValidarDatosRequeridos())
                {
                    if (cbCompany.Text == "Arvaco")
                    {
                        MiMantenimiento.Consecutivo = "AR-" + MiMantenimiento.Consecutivo;
                    }
                    if (cbCompany.Text == "Coarsa")
                    {
                        MiMantenimiento.Consecutivo = "CO-" + MiMantenimiento.Consecutivo;
                    }
                    if (cbCompany.Text == "Personal")
                    {
                        MiMantenimiento.Consecutivo = "PE-" + MiMantenimiento.Consecutivo;
                    }

                    string Mensaje = string.Format("¿Desea agregar el Mantenimiento de tipo: {0}?", cbTipoMantenimiento.Text);
                    DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Continuar == DialogResult.Yes)
                    {
                        MiMantenimiento.FechaRegistro = DateTime.Today.Date;
                        MiMantenimiento.FechaMantenimiento = DTFechaMantenimiento.Value.Date;
                        if (MiMantenimiento.Agregar())
                        {
                            Bitacora MiBitacora = new Bitacora();
                            string accion = "Agregar: Nuevo Mantenimiento: " + cbTipoMantenimiento.Text;
                            MiBitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser, ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            MessageBoxCustom.Show("Mantenimiento Agregado Correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (checkDesactivarOrden.Checked)
                            {
                                MiMantenimiento.MiOrdenCompraDelMantenimiento.EliminarComoUsada(MiMantenimiento.MiOrdenCompraDelMantenimiento.IDOrdenCompra);

                            }
                            LimpiarFormulario();
                            LlenarListaMantenimientos();
                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error y no se ha guardado el mantenimiento", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Bitacora MiBitacora = new Bitacora();
                            string accion = "Agregar Fallido: Nuevo Mantenimiento";
                            MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                        }
                    }
                }
            }
            else
            {
                MessageBoxCustom.Show("Permiso de agregar NO concedido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbPlace_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbPlace.SelectedIndex >= 0)
            {
                MiMantenimiento.MiPlaceDelMantenimiento.IDPlace = Convert.ToInt32(cbPlace.SelectedValue);
            }
            else
            {

                MiMantenimiento.MiPlaceDelMantenimiento.IDPlace = 0;
            }
        }

        private void cbCompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCompany.SelectedIndex >= 0)
            {
                MiMantenimiento.MiCompanyDelMantenimiento.IDCompany = Convert.ToInt32(cbCompany.SelectedValue);
            }
            else
            {

                MiMantenimiento.MiCompanyDelMantenimiento.IDCompany = 0;
            }
        }

        private void txtConsecutivo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtConsecutivo.Text.Trim()))
            {
                MiMantenimiento.Consecutivo = txtConsecutivo.Text.Trim();
            }
            else
            {
                MiMantenimiento.Consecutivo = "";
            }
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCosto.Text.Trim()))
            {
                MiMantenimiento.Costo = Convert.ToDouble(txtCosto.Text.Trim());

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
                MiMantenimiento.Costo = 0;
                txtCosto.Tag = null;
            }
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

        private void txtCosto_Enter(object sender, EventArgs e)
        {
            txtCosto.Text = Convert.ToString(txtCosto.Tag);
        }

        private void txtKilometrajeNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || e.KeyChar == 47)
            {
                MessageBoxCustom.Show("Solo se pueden ingresar números", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtKilometrajeNuevo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKilometrajeNuevo.Text.Trim()))
            {
                MiMantenimiento.Kilometraje = Convert.ToInt32(txtKilometrajeNuevo.Text.Trim());
                btnCalculator.Enabled = true;
            }
            else
            {
                MiMantenimiento.Kilometraje = 0;
                btnCalculator.Enabled = false;
            }
        }

        private void txtLitros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || e.KeyChar == 47)
            {
                MessageBoxCustom.Show("Solo se pueden ingresar números", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtLitros_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLitros.Text.Trim()))
            {
                MiMantenimiento.Litro = Convert.ToDouble(txtLitros.Text.Trim());
            }
            else
            {
                MiMantenimiento.Litro = 0;
            }
        }

        private void DpOilDate_ValueChanged(object sender, EventArgs e)
        {
            if (DpOilDate.Value.Date > DateTime.Today.Date)
            {
                MiMantenimiento.OilDate = DateTime.ParseExact(DpOilDate.Value.ToString("MM yyyy", CultureInfo.InvariantCulture),
                    "MM yyyy", CultureInfo.InvariantCulture);
            }
        }

        private void DateTimeRTV_ValueChanged(object sender, EventArgs e)
        {
            if (DateTimeRTV.Value.Date > DateTime.Today.Date)
            {
                MiMantenimiento.DateRTV = DateTime.ParseExact(DateTimeRTV.Value.ToString("MM yyyy", CultureInfo.InvariantCulture),
                    "MM yyyy", CultureInfo.InvariantCulture);
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
                MiMantenimiento.Marchamo = Convert.ToInt32(txtMarchamo.Text);

            }
            else if (!string.IsNullOrEmpty(txtMarchamo.Text.Trim()))
            {
                MessageBoxCustom.Show("Formato de año Incorrecto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MiMantenimiento.Marchamo = 0;
            }
            else
            {
                MiMantenimiento.Marchamo = 0;
            }
        }

        private void DTFechaMantenimiento_ValueChanged(object sender, EventArgs e)
        {
            MiMantenimiento.FechaMantenimiento = DateTime.ParseExact(DTFechaMantenimiento.Value.ToString
            ("dd MM yyyy", CultureInfo.InvariantCulture),
            "dd MM yyyy", CultureInfo.InvariantCulture);
        }

        private void txtDetalle_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDetalle.Text.Trim()))
            {
                MiMantenimiento.Detalles = txtDetalle.Text;
            }
            else
            {
                MiMantenimiento.Detalles = "";
            }
        }

        private void txtKilometrosRecorridos_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKilometrosRecorridos.Text.Trim()))
            {
                MiMantenimiento.Recorrido =Convert.ToInt32(txtKilometrosRecorridos.Text.Trim());
            }
            else
            {
                MiMantenimiento.Recorrido = 0;
            }
        }

        private void txtCostoKm_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCostoKm.Text.Trim()))
            {
                MiMantenimiento.CostoKm = Convert.ToDouble(txtCostoKm.Text.Trim());
            }
            else
            {
                MiMantenimiento.CostoKm = 0;
            }
        }

        private void txtCostoLitro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCostoLitro.Text.Trim()))
            {
                MiMantenimiento.CostoLitro = Convert.ToDouble(txtCostoLitro.Text.Trim());
            }
            else
            {
                MiMantenimiento.CostoLitro = 0;
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            if (MiMantenimiento.Kilometraje > 0 && MiMantenimiento.Costo > 0 && MiMantenimiento.Litro > 0 
                && !string.IsNullOrEmpty(txtKilometrajeAntes.Text.Trim()) )
            {
                int kmantes = Convert.ToInt32(txtKilometrajeAntes.Text.Trim());
                if (MiMantenimiento.Kilometraje > kmantes || PaseParaEditar)
                {
                    int kmRecorrido = MiMantenimiento.Kilometraje - kmantes;
                    MiMantenimiento.CostoKm = MiMantenimiento.Costo / kmRecorrido;
                    MiMantenimiento.CostoLitro = MiMantenimiento.Costo / MiMantenimiento.Litro;
                    txtKilometrosRecorridos.Text = kmRecorrido.ToString();
                    txtCostoKm.Text = MiMantenimiento.CostoKm.ToString();
                    txtCostoLitro.Text = MiMantenimiento.CostoLitro.ToString();
                }
                else
                {
                    MessageBoxCustom.Show("Estas ingresando un Kilometraje menor al actual.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtKilometrajeAntes.Focus();
                    txtKilometrajeAntes.SelectAll();
                }
            }
            else
            {
                MessageBoxCustom.Show("Debes cumplir con los siguiente.\n• Kilometraje Actual\n• Costo\n• Litros\n• Seleccionar el vehículo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvListaM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaM.SelectedRows.Count == 1)
            {
                LimpiarFormulario(false);

                DataGridViewRow MiFila = DgvListaM.SelectedRows[0];

                int CodigoUsuario = Convert.ToInt32(MiFila.Cells["CIDMantenimiento"].Value);

                MiMantenimiento = MiMantenimiento.ConsultarPorID(CodigoUsuario);

                cbTipoMantenimiento.SelectedValue = MiMantenimiento.MiTipoMantenimientoDelMantenimiento.IDTipoMantenimiento;
                txtIDMantenimiento.Text = MiMantenimiento.IDMantenimiento.ToString();
                txtConsecutivo.Text = MiMantenimiento.Consecutivo;
                
                txtOrdenCompra.Text = MiMantenimiento.MiOrdenCompraDelMantenimiento.IDOrdenCompra.ToString();
                
                cbPlace.SelectedValue = MiMantenimiento.MiPlaceDelMantenimiento.IDPlace;
                cbCompany.SelectedValue = MiMantenimiento.MiCompanyDelMantenimiento.IDCompany;
                txtCosto.Text = MiMantenimiento.Costo.ToString();
                txtCosto.Tag = MiMantenimiento.Costo.ToString();
                txtKilometrajeNuevo.Text = MiMantenimiento.Kilometraje.ToString();
                if (MiMantenimiento.MiArchivoDelMantenimiento.IDImg != 0)
                {
                    txtArchivo.Text = MiMantenimiento.MiArchivoDelMantenimiento.IDImg.ToString();
                }
                if (MiMantenimiento.MiArchivo2DelMantenimiento.IDImg != 0)
                {
                    txtArchivo2.Text = MiMantenimiento.MiArchivo2DelMantenimiento.IDImg.ToString();
                }
                if (!string.IsNullOrEmpty(MiMantenimiento.Detalles))
                {
                    txtDetalle.Text = MiMantenimiento.Detalles;
                }
                if (MiMantenimiento.Litro > 0)
                {
                    txtLitros.Text = MiMantenimiento.Litro.ToString();
                }
                if (MiMantenimiento.Recorrido > 0)
                {
                    txtKilometrosRecorridos.Text = MiMantenimiento.Recorrido.ToString();
                }
                if (MiMantenimiento.CostoKm > 0)
                {
                    txtCostoKm.Text = MiMantenimiento.CostoKm.ToString();
                }
                if (MiMantenimiento.CostoLitro > 0)
                {
                    txtCostoLitro.Text = MiMantenimiento.CostoLitro.ToString();
                }
                if (ValidarSegunDiseño == "RTV")
                {
                    DateTimeRTV.Text = MiMantenimiento.DateRTV.ToString();
                }
                if (ValidarSegunDiseño == "Marchamo")
                {
                    txtMarchamo.Text = MiMantenimiento.Marchamo.ToString();
                }
                if (ValidarSegunDiseño == "CambioDeAceite")
                {
                    DpOilDate.Text = MiMantenimiento.OilDate.ToString();
                }
                DTFechaMantenimiento.Text = MiMantenimiento.FechaMantenimiento.ToString();

                MiMantenimiento.SeleccionarChoferM(MiMantenimiento.MiChoferDelMantenimiento.IDChofer);
                MiMantenimiento.SeleccionarVehiculoM(MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro);

                txtPlaca.Text = MiMantenimiento.MiVehiculoDelMantenimiento.Placa;
                txtKilometrajeAntes.Text = MiMantenimiento.MiVehiculoDelMantenimiento.Kilometraje.ToString();
                txtTipoVehiculo.Text = MiMantenimiento.TipoCarro;
                txtIDCarro.Text = MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro.ToString();
                txtIDChofer.Text = MiMantenimiento.MiChoferDelMantenimiento.IDChofer.ToString();
                txtNombreChofer.Text = MiMantenimiento.MiChoferDelMantenimiento.FullName;

                ActivarEditaryEliminar();

            }
        }

        private void ActivarEditaryEliminar()
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
            PaseParaEditar = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin() || ObjetosGlobales.PuedesEditar())
            {
                if (ValidarDatosRequeridos())
                {

                    Mantenimiento MantenimientoTemporal = MiMantenimiento.ConsultarPorID(MiMantenimiento.IDMantenimiento);
                    if (MantenimientoTemporal.IDMantenimiento > 0)
                    {
                        string Mensaje = string.Format("Desea Continuar con la Modificacion del Mantenimiento: {0} Tipo: {1}?", MiMantenimiento.IDMantenimiento, cbTipoMantenimiento.Text);

                        DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (Continuar == DialogResult.Yes)
                        {
                            if (MiMantenimiento.Editar())
                            {
                                Bitacora MiBitacora = new Bitacora();
                                string accion = "Actualizar: Se modificio el mantenimiento: " + cbTipoMantenimiento.Text;
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                                // se muestra mensaje de exito y se actualiza la lista
                                MessageBoxCustom.Show("El Mantenimiento se ha actualizado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (checkDesactivarOrden.Checked)
                                {
                                    MiMantenimiento.MiOrdenCompraDelMantenimiento.EliminarComoUsada(MiMantenimiento.MiOrdenCompraDelMantenimiento.IDOrdenCompra);
                                }
                                LimpiarFormulario();
                                LlenarListaMantenimientos();
                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error y no se actualizo el mantenimiento!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Bitacora MiBitacora = new Bitacora();
                                string accion = "Actualizar Fallido: Se intento modificar el mantenimiento: " + cbTipoMantenimiento.Text;
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

        private void cbTipoMantenimiento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTipoMantenimiento.Text == "Combustible")
            {
                CambiarDesign(2);
            }
            else if (cbTipoMantenimiento.Text == "Revisión Técnica")
            {
                CambiarDesign(3);
            }
            else if (cbTipoMantenimiento.Text == "Pago Marchamo")
            {
                CambiarDesign(4);
            }
            else if (cbTipoMantenimiento.Text == "Cambio de Aceite")
            {
                CambiarDesign(5);
            }
            else
            {
                CambiarDesign(1);
            }
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

        public static int IDOrdenCompraMantenimiento;

        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            FrmSelectOrdenCompra.SelectForMantenimiento = true;

            Form FormSeleccionarOrden = new FrmSelectOrdenCompra();

            DialogResult result = FormSeleccionarOrden.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Tengo el ID
                MiMantenimiento = MiMantenimiento.TraerInfoOrdenCompra(IDOrdenCompraMantenimiento);

                txtOrdenCompra.Text = IDOrdenCompraMantenimiento.ToString();

                cbCompany.SelectedValue = MiMantenimiento.MiCompanyDelMantenimiento.IDCompany;
                cbPlace.SelectedValue = MiMantenimiento.MiPlaceDelMantenimiento.IDPlace;

                txtDetalle.Text = MiMantenimiento.Detalles;

                txtCosto.Text = MiMantenimiento.Costo.ToString();
                txtCosto.Tag = MiMantenimiento.Costo.ToString();

                if (MiMantenimiento.MiArchivoDelMantenimiento.IDImg > 0)
                {
                    txtArchivo.Text = MiMantenimiento.MiArchivoDelMantenimiento.IDImg.ToString();
                }
                if (MiMantenimiento.MiArchivo2DelMantenimiento.IDImg > 0)
                {
                    txtArchivo2.Text = MiMantenimiento.MiArchivo2DelMantenimiento.IDImg.ToString();
                }

                if (MiMantenimiento.MiChoferDelMantenimiento.IDChofer > 0)
                {
                    txtIDChofer.Text = MiMantenimiento.MiChoferDelMantenimiento.IDChofer.ToString();
                    txtNombreChofer.Text = MiMantenimiento.MiChoferDelMantenimiento.FullName;
                }

                if (MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro > 0)
                {
                    txtIDCarro.Text = MiMantenimiento.MiVehiculoDelMantenimiento.IDCarro.ToString();
                    txtPlaca.Text = MiMantenimiento.MiVehiculoDelMantenimiento.Placa;
                    txtKilometrajeAntes.Text = MiMantenimiento.MiVehiculoDelMantenimiento.Kilometraje.ToString();
                    txtTipoVehiculo.Text = MiMantenimiento.TipoCarro;
                }

                DTFechaMantenimiento.Text = MiMantenimiento.FechaMantenimiento.ToString();

            }

            FrmSelectOrdenCompra.SelectForMantenimiento = false;
        }



        private void txtOrdenCompra_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOrdenCompra.Text.Trim()))
            {
                MiMantenimiento.MiOrdenCompraDelMantenimiento.IDOrdenCompra = Convert.ToInt32(txtOrdenCompra.Text);
            }
            else
            {
                MiMantenimiento.MiOrdenCompraDelMantenimiento.IDOrdenCompra = 0;
            }
        }

        private void btnLimpiarOrden_Click(object sender, EventArgs e)
        {
            txtOrdenCompra.Clear();
        }
    }
}
