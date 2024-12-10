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
    public partial class FrmRevisarWarnings : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Logica.Models.Vehiculo MiVehiculo{ get; set; }
        private DataTable ListaCambios { get; set; }
        private DataTable ListaRTV { get; set; }

        public FrmRevisarWarnings()
        {
            InitializeComponent();
            ListaCambios = new DataTable();
            ListaRTV = new DataTable();
            MiVehiculo = new Logica.Models.Vehiculo();

        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
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

        private void FrmRevisarWarnings_Load(object sender, EventArgs e)
        {
            LlenarDataGrids();
        }

        private void LlenarDataGrids()
        {
            ListaRTV = MiVehiculo.ListarRTV1Mes();
            DgvListaRTV.DataSource = ListaRTV;
            DgvListaRTV.ClearSelection();

            ListaCambios = MiVehiculo.ListarOil1Mes();
            DgvListaOil.DataSource = ListaCambios;
            DgvListaOil.ClearSelection();
        }

        private void DgvListaRTV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaRTV.SelectedRows.Count == 1)
            {
                Clipboard.SetDataObject(DgvListaRTV.SelectedRows[0].Cells["CPlaca"].Value.ToString());
                this.Alert("Placa Copiada", Form_Alert.enmType.Info);
            }
        }

        private void DgvListaOil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaOil.SelectedRows.Count == 1)
            {
                Clipboard.SetDataObject(DgvListaOil.SelectedRows[0].Cells["CPlacaOil"].Value.ToString());
                this.Alert("Placa Copiada", Form_Alert.enmType.Info);
            }
        }
    }
}
