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
    public partial class FrmBitacora : Form
    {

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Logica.Models.Bitacora MiBitacoraLocal { get; set; }

        private DataTable ListaBitacora { get; set; }

        public FrmBitacora()
        {
            InitializeComponent();
            MiBitacoraLocal = new Logica.Models.Bitacora();
            ListaBitacora = new DataTable();

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

        private void FrmBitacora_Load(object sender, EventArgs e)
        {

            LlenarListaUsuarios();


        }


        private void LlenarListaUsuarios(string FiltroBusqueda = "")
        {
            string Filtro = "";

            if (!string.IsNullOrEmpty(FiltroBusqueda) &&
                FiltroBusqueda != "Buscar...")
            {
                Filtro = FiltroBusqueda;

            }

            ListaBitacora = MiBitacoraLocal.Listar(Filtro);
            DgvListaBitacora.DataSource = ListaBitacora;
            DgvListaBitacora.ClearSelection();

        }

        private void LlenarListaUsuariosFechas(DateTime FechaDesde, DateTime FechaHasta ,string FiltroBusqueda = "")
        {
            string Filtro = "";

            if (!string.IsNullOrEmpty(FiltroBusqueda) &&
                FiltroBusqueda != "Buscar...")
            {
                Filtro = FiltroBusqueda;

            }

            ListaBitacora = MiBitacoraLocal.ListarConFechas(FechaDesde, FechaHasta, Filtro);
            DgvListaBitacora.DataSource = ListaBitacora;
            DgvListaBitacora.ClearSelection();

        }


        private void txtFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.SelectAll();
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

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBoxCustom.Show("• Nombre Usuario\n• Acción\n• Código Usuario", "Posibles Filtros", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnFiltroFecha_Click(object sender, EventArgs e)
        {
            string Desde = DateDesde.Value.Date.ToShortDateString();
            string hasta = DateHasta.Value.Date.ToShortDateString();

            if (!string.IsNullOrEmpty(txtFiltro.Text.Trim()) && txtFiltro.Text.Count() >= 2)
            {
                LlenarListaUsuariosFechas(Convert.ToDateTime(Desde), Convert.ToDateTime(hasta), txtFiltro.Text.Trim());
            }
            else
            {
                LlenarListaUsuariosFechas(Convert.ToDateTime(Desde), Convert.ToDateTime(hasta));
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LlenarListaUsuarios();
            txtFiltro.Text = "Buscar...";
            DateDesde.Text = DateTime.Now.ToShortDateString();
            DateHasta.Text = DateTime.Now.ToShortDateString();
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
    }
}
