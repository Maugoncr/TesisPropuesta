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
using CrystalDecisions.CrystalReports.Engine;
using Logica.Models;
using PracticaEmpresarial.Forms;

namespace PracticaEmpresarial.FormsReportes
{
    public partial class FrmReporteGastos : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private GastosV MiGasto { get; set; }
        private DataTable ListaReporte { get; set; }

        public FrmReporteGastos()
        {
            InitializeComponent();
            MiGasto = new GastosV();
            ListaReporte = new DataTable();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LlenarReporte()
        {

            switch (FrmCrearReportes.CasoGasto)
            {
                case 1:

                    ListaReporte = MiGasto.ReporteGastoConFechasYCompany
                    (Convert.ToDateTime(FrmCrearReportes.DesdeGasto), Convert.ToDateTime(FrmCrearReportes.HastaGasto),FrmCrearReportes.CompanyGasto);
                    DgvListaGasto.DataSource = ListaReporte;
                    DgvListaGasto.ClearSelection();

                    break;
                case 2:

                    ListaReporte = MiGasto.ReporteGastoConFechasSinCompany
                   (Convert.ToDateTime(FrmCrearReportes.DesdeGasto), Convert.ToDateTime(FrmCrearReportes.HastaGasto));
                    DgvListaGasto.DataSource = ListaReporte;
                    DgvListaGasto.ClearSelection();

                    break;
                case 3:
                    ListaReporte = MiGasto.ReporteGastoSinFechaConCompany
                    (FrmCrearReportes.CompanyGasto);
                    DgvListaGasto.DataSource = ListaReporte;
                    DgvListaGasto.ClearSelection();
                    break;
                case 4:
                    ListaReporte = MiGasto.ReporteGastoGeneral();
                    DgvListaGasto.DataSource = ListaReporte;
                    DgvListaGasto.ClearSelection();
                    break;
            }
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
            Exportaraexcel(DgvListaGasto);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cargando.Visible = false;
            timer1.Stop();
        }

        private void FrmReporteGastos_Load(object sender, EventArgs e)
        {
            LlenarReporte();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void btnCrystalReport_Click(object sender, EventArgs e)
        {
            if (DgvListaGasto.Rows.Count > 0)
            {
                try
                {
                    Cargando.Visible = true;
                    timer1.Start();

                    ReportDocument MiReporte = new ReportDocument();

                    FrmVisualizadorReportes MiVisualizador = new FrmVisualizadorReportes();

                    switch (FrmCrearReportes.CasoGasto)
                    {
                        case 1:
                            MiReporte = new Reports.RptGastos();
                            MiReporte = MiGasto.ImprimirReporteGastoConFechasYCompany(Convert.ToDateTime(FrmCrearReportes.DesdeGasto),
                              Convert.ToDateTime(FrmCrearReportes.HastaGasto),
                              FrmCrearReportes.CompanyGasto, MiReporte);
                            MiVisualizador.crystalReportViewer1.ReportSource = MiReporte;
                            MiVisualizador.ShowDialog();
                            MiVisualizador.crystalReportViewer1.Zoom(1);
                            break;
                        case 2:
                            MiReporte = new Reports.RptGastos();
                            MiReporte = MiGasto.ImprimirReporteGastoConFechasSinCompany(Convert.ToDateTime(FrmCrearReportes.DesdeGasto),
                              Convert.ToDateTime(FrmCrearReportes.HastaGasto), MiReporte);
                            MiVisualizador.crystalReportViewer1.ReportSource = MiReporte;
                            MiVisualizador.ShowDialog();
                            MiVisualizador.crystalReportViewer1.Zoom(1);
                            break;
                        case 3:
                            MiReporte = new Reports.RptGastos();
                            MiReporte = MiGasto.ImprimirReporteGastoSinFechaConCompany(FrmCrearReportes.CompanyGasto, MiReporte);
                            MiVisualizador.crystalReportViewer1.ReportSource = MiReporte;
                            MiVisualizador.ShowDialog();
                            MiVisualizador.crystalReportViewer1.Zoom(1);
                            break;
                        case 4:
                            MiReporte = new Reports.RptGastos();
                            MiReporte = MiGasto.ImprimirReporteGastoGeneral(MiReporte);
                            MiVisualizador.crystalReportViewer1.ReportSource = MiReporte;
                            MiVisualizador.ShowDialog();
                            MiVisualizador.crystalReportViewer1.Zoom(1);
                            break;
                    }
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
