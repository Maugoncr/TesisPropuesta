using Logica.Models;
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
using PracticaEmpresarial.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace PracticaEmpresarial.FormsReportes
{
    public partial class FrmReporteMantenimientos : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Mantenimiento MiMantenimiento { get; set; }
        private DataTable ListaReporte { get; set; }
        public FrmReporteMantenimientos()
        {
            InitializeComponent();
            MiMantenimiento = new Mantenimiento();
            ListaReporte = new DataTable();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cargando.Visible = false;
            timer1.Stop();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Cargando.Visible = true;
            timer1.Start();
            Exportaraexcel(DgvListaMantenimiento);
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmReporteMantenimientos_Load(object sender, EventArgs e)
        {
            LlenarReporte();
        }

        private void LlenarReporte()
        {

            switch (FrmCrearReportes.CasoMantenimiento)
            {
                case 1:

                    ListaReporte = MiMantenimiento.ReporteMantenimientoConFechasYCompany
                    (Convert.ToDateTime(FrmCrearReportes.DesdeMantenimiento), Convert.ToDateTime(FrmCrearReportes.HastaMantenimiento)
                    , FrmCrearReportes.CompanyMantenimiento);
                    DgvListaMantenimiento.DataSource = ListaReporte;
                    DgvListaMantenimiento.ClearSelection();

                    break;
                case 2:

                    ListaReporte = MiMantenimiento.ReporteMantenimientoConFechasSinCompany
                   (Convert.ToDateTime(FrmCrearReportes.DesdeMantenimiento), Convert.ToDateTime(FrmCrearReportes.HastaMantenimiento));
                    DgvListaMantenimiento.DataSource = ListaReporte;
                    DgvListaMantenimiento.ClearSelection();

                    break;
                case 3:
                    ListaReporte = MiMantenimiento.ReporteMantenimientoSinFechaConCompany
                    (FrmCrearReportes.CompanyMantenimiento);
                    DgvListaMantenimiento.DataSource = ListaReporte;
                    DgvListaMantenimiento.ClearSelection();
                    break;
                case 4:
                    ListaReporte = MiMantenimiento.ReporteMantenimientoGeneral();
                    DgvListaMantenimiento.DataSource = ListaReporte;
                    DgvListaMantenimiento.ClearSelection();
                    break;
            }
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void btnCrystalReport_Click(object sender, EventArgs e)
        {
            if (DgvListaMantenimiento.Rows.Count > 0)
            {
                try
                {
                    Cargando.Visible = true;
                    timer1.Start();

                    ReportDocument MiReporte = new ReportDocument();

                    FrmVisualizadorReportes MiVisualizador = new FrmVisualizadorReportes();

                    switch (FrmCrearReportes.CasoMantenimiento)
                    {
                        case 1:
                            MiReporte = new Reports.RptMantenimientos();
                            MiReporte = MiMantenimiento.ImprimirReporteMantenimientoConFechasYCompany(Convert.ToDateTime(FrmCrearReportes.DesdeMantenimiento),
                              Convert.ToDateTime(FrmCrearReportes.HastaMantenimiento),
                              FrmCrearReportes.CompanyMantenimiento, MiReporte);
                            MiVisualizador.crystalReportViewer1.ReportSource = MiReporte;
                            MiVisualizador.ShowDialog();
                            MiVisualizador.crystalReportViewer1.Zoom(1);
                            break;
                        case 2:
                            MiReporte = new Reports.RptMantenimientos();
                            MiReporte = MiMantenimiento.ImprimirReporteMantenimientoConFechasSinCompany(Convert.ToDateTime(FrmCrearReportes.DesdeMantenimiento),
                              Convert.ToDateTime(FrmCrearReportes.HastaMantenimiento), MiReporte);
                            MiVisualizador.crystalReportViewer1.ReportSource = MiReporte;
                            MiVisualizador.ShowDialog();
                            MiVisualizador.crystalReportViewer1.Zoom(1);
                            break;
                        case 3:
                            MiReporte = new Reports.RptMantenimientos();
                            MiReporte = MiMantenimiento.ImprimirReporteMantenimientoSinFechaConCompany(FrmCrearReportes.CompanyMantenimiento, MiReporte);
                            MiVisualizador.crystalReportViewer1.ReportSource = MiReporte;
                            MiVisualizador.ShowDialog();
                            MiVisualizador.crystalReportViewer1.Zoom(1);
                            break;
                        case 4:
                            MiReporte = new Reports.RptMantenimientos();
                            MiReporte = MiMantenimiento.ImprimirReporteMantenimientoGeneral(MiReporte);
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
