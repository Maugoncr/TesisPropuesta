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
using PracticaEmpresarial.FormsReportes;

namespace PracticaEmpresarial.Forms
{
    public partial class FrmCrearReportes : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Logica.Models.Vehiculo MiVehiculo { get; set; }
        public FrmCrearReportes()
        {
            InitializeComponent();
            MiVehiculo = new Logica.Models.Vehiculo();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCrearReportes_Load(object sender, EventArgs e)
        {
            CargarComboRoles();
            LimpiarFormulario();
        }

        private void CargarComboRoles()
        {

            DataTable DatosCompanies = new DataTable();

            DatosCompanies = MiVehiculo.MiCompany.ListarForCombo();

            // Same for choferes

            cbCompany2.ValueMember = "IDCompany";

            cbCompany2.DisplayMember = "Nombre";

            cbCompany2.DataSource = DatosCompanies;

            cbCompany2.SelectedIndex = -1;

            // Same for Companies
           
            cbCompany.ValueMember = "IDCompany";

            cbCompany.DisplayMember = "Nombre";

            cbCompany.DataSource = DatosCompanies;

            cbCompany.SelectedIndex = -1;

            // Same for Companies

            cbCompany3.ValueMember = "IDCompany";

            cbCompany3.DisplayMember = "Nombre";

            cbCompany3.DataSource = DatosCompanies;

            cbCompany3.SelectedIndex = -1;

        }

        public static int Company;

        private void btnCrearVehiculoR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlaca.Text.Trim()))
            {
                //Es vacia entonces haremos reporte general, pero necesitamos saber la compañia
                //Variable global para saber la compañia a la cual haremos select
                Company = Convert.ToInt32(cbCompany.SelectedValue);
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmReporteVehiculosAll);
                if (frm == null)
                {
                    FrmReporteVehiculosAll MiReporte = new FrmReporteVehiculosAll();
                    MiReporte.ShowDialog();
                }
                else
                {
                    frm.BringToFront();
                }
            }
            else
            {
                PlacaReporte = txtPlaca.Text;
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmReporteVehiculoPorPlaca);
                if (frm == null)
                {
                    FrmReporteVehiculoPorPlaca MiReportePorPlaca = new FrmReporteVehiculoPorPlaca();
                    MiReportePorPlaca.ShowDialog();
                }
                else
                {
                    frm.BringToFront();
                }
            }

        }


        private void LimpiarFormulario()
        {
            // Parte del vehiculo
            btnCrearVehiculoR.Enabled = false;
            btnBorrarPlaca.Enabled = false;
            cbCompany.SelectedIndex = -1;
            checkFechasGastos.Checked = false;
            dtDesdeGasto.Enabled = false;
            dtHastaGasto.Enabled = false;
            checkFechasMantenimiento.Checked = false;
            dtDesdeMantenimiento.Enabled = false;
            dtHastaMantenimiento.Enabled = false;


            MiVehiculo = new Logica.Models.Vehiculo();


        }

        private void cbCompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCompany.SelectedIndex >= 0)
            {
                btnCrearVehiculoR.Enabled = true;
            }
            else
            {

                btnCrearVehiculoR.Enabled = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public static string PlacaReporte;
        public static bool DesdeReporte = false;

        private void btnBuscarVehiculo_Click(object sender, EventArgs e)
        {

            DesdeReporte = true;

            Form FormSelectVehiculo = new FrmSelectVehiculos();

            DialogResult result = FormSelectVehiculo.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtPlaca.Text = PlacaReporte;
                // Ya la placa viene de X compañia
                cbCompany.Enabled = false;
                cbCompany.SelectedIndex = -1;
                btnBorrarPlaca.Enabled = true;
                btnCrearVehiculoR.Enabled = true;
            }
        }

        private void btnBorrarPlaca_Click(object sender, EventArgs e)
        {
            txtPlaca.Clear();
            cbCompany.Enabled = true;
            btnBorrarPlaca.Enabled = false;
            btnCrearVehiculoR.Enabled = false;
        }

        // Parte reporte de Gastos!

        private void checkFechasGastos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFechasGastos.Checked == true)
            {
                dtDesdeGasto.Enabled = true;
                dtHastaGasto.Enabled = true;

            }
            else
            {
                dtDesdeGasto.Enabled = false;
                dtHastaGasto.Enabled = false;
                dtDesdeGasto.ResetText();
                dtHastaGasto.ResetText();

            }
        }

        private void btnEliminarCompanyGasto_Click(object sender, EventArgs e)
        {
            cbCompany2.SelectedIndex = -1;
        }

        public static string DesdeGasto;
        public static string HastaGasto;
        public static int CompanyGasto;
        public static int CasoGasto;
        private void btnCrearGastoR_Click(object sender, EventArgs e)
        {
            VerificarCasoGasto();

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmReporteGastos);
            if (frm == null)
            {
                FrmReporteGastos MiReporteGasto = new FrmReporteGastos();
                MiReporteGasto.ShowDialog();
            }
            else
            {
                frm.BringToFront();
            }


        }

        private void VerificarCasoGasto() 
        {
            if (checkFechasGastos.Checked)
            {
                // Usa fechas entonces entre caso 1 y 2
                DesdeGasto = dtDesdeGasto.Value.Date.ToShortDateString();
                HastaGasto = dtHastaGasto.Value.Date.ToShortDateString();
                if (cbCompany2.SelectedIndex >= 0)
                {
                    // Usa compañia
                    CasoGasto = 1;
                    CompanyGasto = Convert.ToInt32(cbCompany2.SelectedValue);
                }
                else
                {
                    // No usa compañia
                    CasoGasto = 2;
                }
            }
            else
            {
                // No usa fechas caso 3 o 4
                if (cbCompany2.SelectedIndex >= 0)
                {
                    // Usa compañia
                    CasoGasto = 3;
                    CompanyGasto = Convert.ToInt32(cbCompany2.SelectedValue);
                }
                else
                {
                    // No usa nada.
                    CasoGasto= 4;
                }
            }
        }

        // Parte de RPT Mantenimientos

        public static string DesdeMantenimiento;
        public static string HastaMantenimiento;
        public static int CompanyMantenimiento;
        public static int CasoMantenimiento;

        private void checkFechasMantenimiento_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFechasMantenimiento.Checked == true)
            {
                dtDesdeMantenimiento.Enabled = true;
                dtHastaMantenimiento.Enabled = true;

            }
            else
            {
                dtDesdeMantenimiento.Enabled = false;
                dtHastaMantenimiento.Enabled = false;
                dtDesdeMantenimiento.ResetText();
                dtHastaMantenimiento.ResetText();

            }
        }

        private void btnEliminarCompanyMantenimiento_Click(object sender, EventArgs e)
        {
            cbCompany3.SelectedIndex = -1;
        }

        private void btnCrearMantenimientoR_Click(object sender, EventArgs e)
        {
            VerificarCasoMantenimiento();

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmReporteMantenimientos);
            if (frm == null)
            {
                FrmReporteMantenimientos MiReporteMantenimiento = new FrmReporteMantenimientos();
                MiReporteMantenimiento.ShowDialog();
            }
            else
            {
                frm.BringToFront();
            }
        }

        private void VerificarCasoMantenimiento()
        {
            if (checkFechasMantenimiento.Checked)
            {
                // Usa fechas entonces entre caso 1 y 2
                DesdeMantenimiento = dtDesdeMantenimiento.Value.Date.ToShortDateString();
                HastaMantenimiento = dtHastaMantenimiento.Value.Date.ToShortDateString();
                if (cbCompany3.SelectedIndex >= 0)
                {
                    // Usa compañia
                    CasoMantenimiento = 1;
                    CompanyMantenimiento = Convert.ToInt32(cbCompany3.SelectedValue);
                }
                else
                {
                    // No usa compañia
                    CasoMantenimiento = 2;
                }
            }
            else
            {
                // No usa fechas caso 3 o 4
                if (cbCompany3.SelectedIndex >= 0)
                {
                    // Usa compañia
                    CasoMantenimiento = 3;
                    CompanyMantenimiento = Convert.ToInt32(cbCompany3.SelectedValue);
                }
                else
                {
                    // No usa nada.
                    CasoMantenimiento = 4;
                }
            }
        }

    }
}
