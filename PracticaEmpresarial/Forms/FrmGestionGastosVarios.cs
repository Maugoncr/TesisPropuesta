using CustomMessageBox;
using Logica.Models;
using PracticaEmpresarial.Commons;
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

namespace PracticaEmpresarial.Forms
{
    public partial class FrmGestionGastosVarios : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Logica.Models.GastosV MiGasto { get; set; }
        private DataTable ListaGastos { get; set; }
        public FrmGestionGastosVarios()
        {
            InitializeComponent();
            MiGasto = new Logica.Models.GastosV();
            ListaGastos = new DataTable();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void FrmGestionGastosVarios_Load(object sender, EventArgs e)
        {
            CargarComboRoles();
            LlenarListaGastos();
            LimpiarFormulario();
        }
        private void LimpiarFormulario(bool LimpiarBusqueda = true)
        {

            txtIDGasto.Clear();
            txtConsecutivo.Clear();
            txtCosto.Clear();
            txtCosto.Tag = null;
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtArchivo.Clear();
            txtArchivo2.Clear();
            txtOrdenCompra.Clear();
            cbPlace.SelectedIndex = -1;
            cbCompany.SelectedIndex = -1;
            DTFechaGasto.ResetText();


            if (LimpiarBusqueda)
            {
                txtFiltro.Text = "Buscar...";
            }
            // al reinstanciar el objeto local se eliminan todos los datos de los atributos
            MiGasto = new GastosV();

            ActivarAgregar();

        }
        private void ActivarAgregar()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnVerArchivo.Enabled = false;
            btnVerArchivo2.Enabled = false;


        }
        private void LlenarListaGastos(string FiltroBusqueda = "")
        {

            string Filtro = "";


            if (!string.IsNullOrEmpty(FiltroBusqueda) &&
                FiltroBusqueda != "Buscar...")
            {
                Filtro = FiltroBusqueda;

            }


            ListaGastos = MiGasto.Listar(Filtro);

            DgvListaGastosVarios.DataSource = ListaGastos;

            DgvListaGastosVarios.ClearSelection();

        }

        private void CargarComboRoles()
        {
            // Para los lugares
            DataTable DatosDeTipos = new DataTable();

            DatosDeTipos = MiGasto.MiPlace.Listar();

            cbPlace.ValueMember = "IDPlace";

            cbPlace.DisplayMember = "Descripcion";

            cbPlace.DataSource = DatosDeTipos;

            cbPlace.SelectedIndex = -1;

            // Para compañias

            DataTable DatosCompany = new DataTable();

            DatosCompany = MiGasto.MiCompany.ListarForCombo();

            cbCompany.ValueMember = "IDCompany";

            cbCompany.DisplayMember = "Nombre";

            cbCompany.DataSource = DatosCompany;

            cbCompany.SelectedIndex = -1;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.SelectAll();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltro.Text.Trim()) && txtFiltro.Text.Count() >= 2)
            {
                LlenarListaGastos(txtFiltro.Text.Trim());
            }
            else
            {
                LlenarListaGastos();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin() || ObjetosGlobales.PuedesAgregar())
            {
                if (ValidarDatosRequeridos())
                {
                    if (cbCompany.Text == "Arvaco")
                    {
                        MiGasto.Consecutivo = "AR-" + MiGasto.Consecutivo;
                    }
                    if (cbCompany.Text == "Coarsa")
                    {
                        MiGasto.Consecutivo = "CO-" + MiGasto.Consecutivo;
                    }
                    if (cbCompany.Text == "Personal")
                    {
                        MiGasto.Consecutivo = "PE-" + MiGasto.Consecutivo;
                    }

                    bool OkConsecutivo = MiGasto.ConsultarPorConsecutivo(MiGasto.Consecutivo);

                    if (!OkConsecutivo)
                    {
                        string Mensaje = string.Format("¿Desea agregar el gasto con el consecutivo: {0}?", MiGasto.Consecutivo);
                        DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (Continuar == DialogResult.Yes)
                        {
                            MiGasto.FechaGasto = DTFechaGasto.Value.Date;
                            

                            if (MiGasto.Agregar())
                            {
                                Bitacora MiBitacora = new Bitacora();
                                string accion = "Agregar: Nuevo Gasto: " + txtDescripcion.Text.Trim();
                                MiBitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser, ObjetosGlobales.MiUsuarioDeSistema.FullName);
                                MessageBoxCustom.Show("Gasto Agregado Correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (checkDesactivarOrden.Checked)
                                {
                                    MiGasto.MiOrden.EliminarComoUsada(MiGasto.MiOrden.IDOrdenCompra);
                                }
                                LimpiarFormulario();
                                LlenarListaGastos();
                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error y no se ha guardado el gasto", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                                string accion = "Agregar Fallido: Nuevo Gasto";
                                MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            }
                        }
                    }
                    else
                    {
                        if (OkConsecutivo)
                        {
                            MessageBoxCustom.Show("Ya existe un gasto con el consecutivo digitado", "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            else
            {
                MessageBoxCustom.Show("Permiso de agregar NO concedido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private bool ValidarDatosRequeridos()
        {
            bool R = false;


            if (!string.IsNullOrEmpty(MiGasto.Consecutivo) &&
                !string.IsNullOrEmpty(MiGasto.Descrip) &&
                MiGasto.Costo > 0 && MiGasto.MiPlace.IDPlace > 0 && MiGasto.Cantidad > 0 && MiGasto.MiCompany.IDCompany > 0 &&
                MiGasto.MiOrden.IDOrdenCompra > 0)
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(MiGasto.Consecutivo))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Consecutivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }

                if (string.IsNullOrEmpty(MiGasto.Descrip))
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Descripcion", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiGasto.MiOrden.IDOrdenCompra == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar Orden de Compra", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiGasto.Costo == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Costo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiGasto.MiPlace.IDPlace == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar la tienda de servicio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }if (MiGasto.MiCompany.IDCompany == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Seleccionar la compañia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                }
                if (MiGasto.Cantidad == 0)
                {
                    MessageBoxCustom.Show("Faltan datos!\n•Cantidad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return R;
                } 
               

            }

            return R;
        }

        private void txtConsecutivo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtConsecutivo.Text.Trim()))
            {
                MiGasto.Consecutivo = txtConsecutivo.Text.Trim();

            }
            else
            {

                MiGasto.Consecutivo = "";
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                MiGasto.Descrip = txtDescripcion.Text.Trim();
            }
            else
            {
                MiGasto.Descrip = "";
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCantidad.Text.Trim()))
            {
                MiGasto.Cantidad = Convert.ToDouble(txtCantidad.Text.Trim());
            }
            else
            {
                MiGasto.Cantidad = 0;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || e.KeyChar == 47)
            {
                MessageBoxCustom.Show("Solo se pueden ingresar números", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
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

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCosto.Text.Trim()))
            {
                MiGasto.Costo = Convert.ToDouble(txtCosto.Text.Trim());

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
                MiGasto.Costo = 0;
            }
                        
           
        }

        private void cbPlace_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbPlace.SelectedIndex >= 0)
            {
                MiGasto.MiPlace.IDPlace = Convert.ToInt32(cbPlace.SelectedValue);
            }
            else
            {

                MiGasto.MiPlace.IDPlace = 0;
            }
        }

        private void txtArchivo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArchivo.Text.Trim()))
            {
                MiGasto.MiArchivo.IDImg = Convert.ToInt32(txtArchivo.Text.Trim());
                btnVerArchivo.Enabled = true;
            }
            else
            {
                MiGasto.MiArchivo.IDImg = 0;
            }
        }

        private void txtArchivo2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArchivo2.Text.Trim()))
            {
                MiGasto.MiArchivo2.IDImg = Convert.ToInt32(txtArchivo2.Text.Trim());
                btnVerArchivo2.Enabled = true;
            }
            else
            {
                MiGasto.MiArchivo2.IDImg = 0;
            }
        }

        public static bool ParaEvidencia1 = false;
        public static int Evidencia1 = 0;
        private void btnSelectArchivo_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.PuedesEditar() || ObjetosGlobales.PuedesAgregar())
            {
                ParaEvidencia1 = true;

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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtArchivo.Clear();
            Evidencia1 = 0;
            btnVerArchivo.Enabled = false;
        }

        private void btnBorrar2_Click(object sender, EventArgs e)
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
                MiGasto.MiArchivo.IDImg = id;
                var Lista = new List<Archivo>();
                Lista = MiGasto.MiArchivo.FiltroArchivos();

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
                MiGasto.MiArchivo2.IDImg = id;
                var Lista = new List<Archivo>();
                Lista = MiGasto.MiArchivo2.FiltroArchivos();

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

        private void DgvListaGastosVarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaGastosVarios.SelectedRows.Count == 1)
            {
                LimpiarFormulario(false);

                DataGridViewRow MiFila = DgvListaGastosVarios.SelectedRows[0];

                int CodigoUsuario = Convert.ToInt32(MiFila.Cells["CIDGasto"].Value);

                MiGasto = MiGasto.ConsultarPorID(CodigoUsuario);

                txtIDGasto.Text = MiGasto.IDGasto.ToString();
                txtConsecutivo.Text = MiGasto.Consecutivo;
                txtDescripcion.Text = MiGasto.Descrip;
                txtCantidad.Text = MiGasto.Cantidad.ToString();
                txtCosto.Text = MiGasto.Costo.ToString();
                txtCosto.Tag = MiGasto.Costo.ToString();
                if (MiGasto.MiArchivo.IDImg != 0)
                {
                    txtArchivo.Text = MiGasto.MiArchivo.IDImg.ToString();
                }
                if (MiGasto.MiArchivo2.IDImg != 0)
                {
                    txtArchivo2.Text = MiGasto.MiArchivo2.IDImg.ToString();
                }
                
                txtOrdenCompra.Text = MiGasto.MiOrden.IDOrdenCompra.ToString();
                
                cbPlace.SelectedValue = MiGasto.MiPlace.IDPlace;
                cbCompany.SelectedValue = MiGasto.MiCompany.IDCompany;
               
                DTFechaGasto.Text = MiGasto.FechaGasto.ToString();
                
               

                ActivarEditaryEliminar();

            }
        }

        private void ActivarEditaryEliminar()
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin()||ObjetosGlobales.PuedesEditar())
            {
                if (ValidarDatosRequeridos())
                {

                    GastosV GastoTemp = MiGasto.ConsultarPorID(MiGasto.IDGasto);
                    if (GastoTemp.IDGasto > 0)
                    {

                        string Mensaje = string.Format("Desea Continuar con la Modificacion del gasto: {0}?", MiGasto.Descrip);

                        DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (Continuar == DialogResult.Yes)
                        {
                            MiGasto.FechaModificacion = DateTime.Today.Date;
                            MiGasto.FechaGasto = DTFechaGasto.Value.Date;
                            if (MiGasto.Editar())
                            {
                                Bitacora MiBitacora = new Bitacora();
                                string accion = "Actualizar: Se modificio el Gasto: " + MiGasto.Descrip;
                                MiBitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser, ObjetosGlobales.MiUsuarioDeSistema.FullName);
                                // se muestra mensaje de exito y se actualiza la lista
                                MessageBoxCustom.Show("El Gasto se ha actualizado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (checkDesactivarOrden.Checked)
                                {
                                    MiGasto.MiOrden.EliminarComoUsada(MiGasto.MiOrden.IDOrdenCompra);
                                }
                                LimpiarFormulario();
                                LlenarListaGastos();
                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error y no se actualizo el gasto!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Bitacora MiBitacora = new Bitacora();
                                string accion = "Actualizar Fallido: Se intento modificar el gasto: " + MiGasto.Descrip;
                                MiBitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser, ObjetosGlobales.MiUsuarioDeSistema.FullName);

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

        private void txtCosto_Enter(object sender, EventArgs e)
        {
               
                txtCosto.Text = Convert.ToString(txtCosto.Tag);
        }

        private void cbCompany_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCompany.SelectedIndex >= 0)
            {
                MiGasto.MiCompany.IDCompany = Convert.ToInt32(cbCompany.SelectedValue);
            }
            else
            {
                MiGasto.MiCompany.IDCompany = 0;
            }
        }

        private void DTFechaGasto_ValueChanged(object sender, EventArgs e)
        {
            MiGasto.FechaGasto = DateTime.ParseExact(DTFechaGasto.Value.ToString
            ("dd MM yyyy", CultureInfo.InvariantCulture),
            "dd MM yyyy", CultureInfo.InvariantCulture);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportaraexcel(DgvListaGastosVarios);
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

        private void txtOrdenCompra_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOrdenCompra.Text.Trim()))
            {
                MiGasto.MiOrden.IDOrdenCompra = Convert.ToInt32(txtOrdenCompra.Text);
            }
            else
            {
                MiGasto.MiOrden.IDOrdenCompra = 0;
            }
        }

        public static int IDOrdenCompraGasto;

        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            Form FormSeleccionarOrden = new FrmSelectOrdenCompra();

            DialogResult result = FormSeleccionarOrden.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Tengo el ID
                MiGasto = MiGasto.TraerInfoOrdenCompra(IDOrdenCompraGasto);

                txtOrdenCompra.Text = IDOrdenCompraGasto.ToString();

                cbCompany.SelectedValue = MiGasto.MiCompany.IDCompany;
                cbPlace.SelectedValue = MiGasto.MiPlace.IDPlace;

                txtDescripcion.Text = MiGasto.Descrip;

                txtCosto.Text = MiGasto.Costo.ToString();
                txtCosto.Tag = MiGasto.Costo.ToString();

                if (MiGasto.MiArchivo.IDImg > 0)
                {
                    txtArchivo.Text = MiGasto.MiArchivo.IDImg.ToString();
                }
                if (MiGasto.MiArchivo2.IDImg > 0)
                {
                    txtArchivo2.Text = MiGasto.MiArchivo2.IDImg.ToString();
                }

                DTFechaGasto.Text = MiGasto.FechaGasto.ToString();

            }
        }

        private void btnLimpiarOrden_Click(object sender, EventArgs e)
        {
            txtOrdenCompra.Clear();
        }
    }
}
