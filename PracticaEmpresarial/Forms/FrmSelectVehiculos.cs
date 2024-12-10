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
    public partial class FrmSelectVehiculos : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Logica.Models.Vehiculo MiVehiculo { get; set; }
        private DataTable ListaVehiculos { get; set; }

        public FrmSelectVehiculos()
        {
            InitializeComponent();

            MiVehiculo = new Logica.Models.Vehiculo();
            ListaVehiculos = new DataTable();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSelectVehiculos_Load(object sender, EventArgs e)
        {
            LlenarListaVehiculo();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LlenarListaVehiculo(string FiltroBusqueda = "")
        {

            string Filtro = "";


            if (!string.IsNullOrEmpty(FiltroBusqueda) &&
                FiltroBusqueda != "Buscar...")
            {
                Filtro = FiltroBusqueda;

            }

            ListaVehiculos = MiVehiculo.ListarForSelect(Filtro);

            DgvListaChofer.DataSource = ListaVehiculos;

            DgvListaChofer.ClearSelection();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltro.Text.Trim()) && txtFiltro.Text.Count() >= 2)
            {
                LlenarListaVehiculo(txtFiltro.Text.Trim());
            }
            else
            {
                LlenarListaVehiculo();
            }
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

                int CodigoUsuario = Convert.ToInt32(MiFila.Cells["CIDCarro"].Value);

                MiVehiculo = MiVehiculo.ConsultarPorID(CodigoUsuario);

                txtPlaca.Text = MiVehiculo.Placa.ToString();
                txtIDCarro.Text = MiVehiculo.IDCarro.ToString();
                txtKilometraje.Text = MiVehiculo.Kilometraje.ToString();

                Activar();

            }
        }

        public void Activar()
        {
            btnSeleccionarCarro.Enabled = true;
        }

        public void LimpiarFormulario(bool LimpiarBusqueda = true)
        {
            txtIDCarro.Clear();
            txtPlaca.Clear();
            txtKilometraje.Clear();
            if (LimpiarBusqueda)
            {
                txtFiltro.Text = "Buscar...";
            }
            MiVehiculo = new Logica.Models.Vehiculo();
            Desactivar();
        }

        public void Desactivar()
        {
            btnSeleccionarCarro.Enabled = false;        
        }

        public static bool DesdeOrden = false;
        private void btnSeleccionarCarro_Click(object sender, EventArgs e)
        {
            if (DgvListaChofer.SelectedRows.Count > 0)
            {
                try
                {
                    if (FrmCrearReportes.DesdeReporte)
                    {
                        FrmCrearReportes.PlacaReporte = Convert.ToString(DgvListaChofer.SelectedRows[0].Cells["CPlaca"].Value);
                        FrmCrearReportes.DesdeReporte = false;
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (DesdeOrden)
                    {
                        FrmOrdendeCompra.IDCarro = Convert.ToInt32(DgvListaChofer.SelectedRows[0].Cells["CIDCarro"].Value);
                        FrmOrdendeCompra.Placa = Convert.ToString(DgvListaChofer.SelectedRows[0].Cells["CPlaca"].Value);
                        DesdeOrden = false;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        FrmGestionMantenimientos.IDCarro = Convert.ToInt32(DgvListaChofer.SelectedRows[0].Cells["CIDCarro"].Value);
                        FrmGestionMantenimientos.Placa = Convert.ToString(DgvListaChofer.SelectedRows[0].Cells["CPlaca"].Value);
                        FrmGestionMantenimientos.TipoVehiculo = Convert.ToString(DgvListaChofer.SelectedRows[0].Cells["CDescripcion"].Value);
                        FrmGestionMantenimientos.Kilometraje = Convert.ToInt32(DgvListaChofer.SelectedRows[0].Cells["CKilometraje"].Value);
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
                MessageBoxCustom.Show("No has seleccionado ningun vehiculo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
