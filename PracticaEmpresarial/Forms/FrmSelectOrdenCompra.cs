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
using CustomMessageBox;
using Logica.Models;

namespace PracticaEmpresarial.Forms
{
    public partial class FrmSelectOrdenCompra : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private OrdenCompra MiOrden { get; set; }
        private DataTable ListaOrdenes { get; set; }


        public FrmSelectOrdenCompra()
        {
            InitializeComponent();
            MiOrden = new OrdenCompra();
            ListaOrdenes = new DataTable();

        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.SelectAll();
        }

        private void FrmSelectOrdenCompra_Load(object sender, EventArgs e)
        {
            LlenarListaOrdenes();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public static bool SelectForMantenimiento = false;

        private void LlenarListaOrdenes(string FiltroBusqueda = "")
        {

            string Filtro = "";


            if (!string.IsNullOrEmpty(FiltroBusqueda) &&
                FiltroBusqueda != "Buscar...")
            {
                Filtro = FiltroBusqueda;

            }

            if (SelectForMantenimiento)
            {
                ListaOrdenes = MiOrden.ListarForSelectMantenimiento(Filtro);
            }
            else
            {
                ListaOrdenes = MiOrden.ListarForSelectGasto(Filtro);
            }

            DgvListaOrden.DataSource = ListaOrdenes;

            DgvListaOrden.ClearSelection();

        }

        private void btnSeleccionarOrden_Click(object sender, EventArgs e)
        {
            if (DgvListaOrden.SelectedRows.Count > 0)
            {
                try
                {
                    if (SelectForMantenimiento == true)
                    {
                        FrmGestionMantenimientos.IDOrdenCompraMantenimiento = Convert.ToInt32(DgvListaOrden.SelectedRows[0].Cells["CIDOrdenCompra"].Value);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        FrmGestionGastosVarios.IDOrdenCompraGasto = Convert.ToInt32(DgvListaOrden.SelectedRows[0].Cells["CIDOrdenCompra"].Value);
                        this.DialogResult = DialogResult.OK;
                    }

                }
                catch (Exception)
                {
                    this.DialogResult = DialogResult.None;
                }

            }
            else
            {
                MessageBoxCustom.Show("No has seleccionado ninguna Orden", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltro.Text.Trim()) && txtFiltro.Text.Count() >= 2)
            {
                LlenarListaOrdenes(txtFiltro.Text.Trim());
            }
            else
            {
                LlenarListaOrdenes();
            }
        }
    }
}
