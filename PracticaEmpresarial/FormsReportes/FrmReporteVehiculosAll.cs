using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Logica.Models;
using PracticaEmpresarial.Forms;

namespace PracticaEmpresarial.FormsReportes
{
    public partial class FrmReporteVehiculosAll : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //INICIALIZADORES
        private Vehiculo MiVehiculo { get; set; }
        private DataTable ListaReporte { get; set; }

     
        public FrmReporteVehiculosAll()
        {
            InitializeComponent();
            MiVehiculo = new Vehiculo();
            ListaReporte = new DataTable();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmReporteVehiculosAll_Load(object sender, EventArgs e)
        {
            LlenarReporte();
        }

        private void LlenarReporte()
        {
            ListaReporte = MiVehiculo.ReporteVehiculoAll(FrmCrearReportes.Company);
            DgvListaVehiculos.DataSource = ListaReporte;
            DgvListaVehiculos.ClearSelection();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Cargando.Visible = true;
            timer1.Start();
            Exportaraexcel(DgvListaVehiculos);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cargando.Visible = false;
            timer1.Stop();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void btnCrystalReport_Click(object sender, EventArgs e)
        {
            if (DgvListaVehiculos.Rows.Count > 0)
            {
                try
                {
                    Cargando.Visible = true;
                    timer1.Start();

                    ReportDocument MiReporte = new ReportDocument();
                    MiReporte = new Reports.RptVehiculoByCompany();

                    MiReporte = MiVehiculo.ImprimirReporteVehiculoAll(FrmCrearReportes.Company, MiReporte);

                    FrmVisualizadorReportes MiVisualizador = new FrmVisualizadorReportes();

                    MiVisualizador.crystalReportViewer1.ReportSource = MiReporte;

                    MiVisualizador.ShowDialog();

                    MiVisualizador.crystalReportViewer1.Zoom(1);

                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                this.Alert("Está vacio", Form_Alert.enmType.Info);
            }

        }
    }
}
