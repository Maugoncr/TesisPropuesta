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
    public partial class FrmSelectChofer : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Logica.Models.Chofer MiChofer { get; set; }
        private DataTable ListaChoferes { get; set; }

        public FrmSelectChofer()
        {
            InitializeComponent();

            MiChofer = new Logica.Models.Chofer();
            ListaChoferes = new DataTable();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmSelectChofer_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
            LlenarListaArchivos();

        }

        private void LlenarListaArchivos(string FiltroBusqueda = "")
        {

            string Filtro = "";


            if (!string.IsNullOrEmpty(FiltroBusqueda) &&
                FiltroBusqueda != "Buscar...")
            {
                Filtro = FiltroBusqueda;

            }


            ListaChoferes = MiChofer.ListarForSelect(Filtro);

            DgvListaChofer.DataSource = ListaChoferes;

            DgvListaChofer.ClearSelection();

        }
        public void LimpiarFormulario(bool LimpiarBusqueda = true)
        {
            txtIDChofer.Clear();
            txtNombre.Clear();

            if (LimpiarBusqueda)
            {
                txtFiltro.Text = "Buscar...";
            }

            MiChofer = new Logica.Models.Chofer();
            Desactivar();

        }


        private void Desactivar()
        {
            btnSeleccionarChofer.Enabled = false;
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.SelectAll();
        }

        private void DgvListaChofer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaChofer.SelectedRows.Count == 1)
            {
                LimpiarFormulario(false);

                DataGridViewRow MiFila = DgvListaChofer.SelectedRows[0];

                int CodigoUsuario = Convert.ToInt32(MiFila.Cells["CIDChofer"].Value);

                MiChofer = MiChofer.ConsultarPorID(CodigoUsuario);

                txtNombre.Text = MiChofer.FullName.ToString();
                txtIDChofer.Text = MiChofer.IDChofer.ToString();

                Activar();

            }
        }

        public void Activar()
        {
            btnSeleccionarChofer.Enabled = true;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltro.Text.Trim()) && txtFiltro.Text.Count() >= 2)
            {
                LlenarListaArchivos(txtFiltro.Text.Trim());
            }
            else
            {
                LlenarListaArchivos();
            }
        }

        public static bool DesdeOrden = false;

        private void btnSeleccionarChofer_Click(object sender, EventArgs e)
        {
            if (DgvListaChofer.SelectedRows.Count > 0)
            {
                try
                {
                    if (DesdeOrden==true)
                    {
                        FrmOrdendeCompra.IDChofer = Convert.ToInt32(DgvListaChofer.SelectedRows[0].Cells["CIDChofer"].Value);
                        FrmOrdendeCompra.NombreChofer = Convert.ToString(DgvListaChofer.SelectedRows[0].Cells["CFullName"].Value);
                        DesdeOrden = false;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        FrmGestionMantenimientos.IDChofer = Convert.ToInt32(DgvListaChofer.SelectedRows[0].Cells["CIDChofer"].Value);
                        FrmGestionMantenimientos.NombreChofer = Convert.ToString(DgvListaChofer.SelectedRows[0].Cells["CFullName"].Value);
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
                MessageBoxCustom.Show("No has seleccionado ningun chofer", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
