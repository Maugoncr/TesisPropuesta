using CustomMessageBox;
using Logica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEmpresarial.Forms
{
    public partial class FrmGestionArchivos : Form
    {
        private Logica.Models.Archivo MiArchivo { get; set; }
        private DataTable ListaArchivos { get; set; }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private FrmGestionGastosVarios MiGastoVarioForm { get; set; }

        public FrmGestionArchivos()
        {
            InitializeComponent();
            MiArchivo = new Archivo();
            ListaArchivos = new DataTable();
            MiGastoVarioForm = new FrmGestionGastosVarios();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            DesactivarSeleccion = false;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Documentos";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtRuta.Text = openFileDialog1.FileName;
                txtNombre.Enabled = true;
            }


        }

        private void LlenarListaArchivos(string FiltroBusqueda = "")
        {

            string Filtro = "";


            if (!string.IsNullOrEmpty(FiltroBusqueda) &&
                FiltroBusqueda != "Buscar...")
            {
                Filtro = FiltroBusqueda;

            }


            ListaArchivos = MiArchivo.Listar(Filtro);

            DgvListaArchivos.DataSource = ListaArchivos;

            DgvListaArchivos.ClearSelection();

        }

        public bool ValidarCampos() 
        {
            bool R = false;

            if (!string.IsNullOrEmpty(txtRuta.Text) && !string.IsNullOrEmpty(txtNombre.Text) && MiArchivo.MiTipo.IDTipoArchivo > 0)
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(txtRuta.Text))
                {
                    MessageBoxCustom.Show("Aún no tienes la ruta del archivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return R;
                }
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBoxCustom.Show("Aún no tienes el nombre del archivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return R;
                }
                if (MiArchivo.MiTipo.IDTipoArchivo == 0)
                {
                    MessageBoxCustom.Show("Aún no eliges el tipo de archivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return R;
                }
            }

            return R;
        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                byte[] archivo = null;
                Stream MyStream = openFileDialog1.OpenFile();
                MemoryStream obj = new MemoryStream();
                MyStream.CopyTo(obj);
                archivo = obj.ToArray();

                MiArchivo.Nombre = txtNombre.Text;
                MiArchivo.Documento = archivo;
                MiArchivo.Extension = openFileDialog1.SafeFileName;

                if (MiArchivo.Agregar())
                {
                    Bitacora MiBitacora = new Bitacora();
                    string accion = "Agregar: Nuevo Archivo: " + txtNombre.Text.Trim();
                    MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                    MessageBoxCustom.Show("Se agrego el archivo correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    LlenarListaArchivos();
                }
                else
                {
                    MessageBoxCustom.Show("Ha ocurrido un error y no se ha guardado el archivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Bitacora MiBitacora = new Bitacora();
                    string accion = "Agregar Fallido: Nuevo Archivo";
                    MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                }
            }
        }

        private void FrmGestionArchivos_Load(object sender, EventArgs e)
        {
            LlenarListaArchivos();
            CargarCombos();
            LimpiarFormulario();
            if (DesactivarSeleccion)
            {
                DesactivarSelect();
            }
        }

        private void CargarCombos() 
        {
            DataTable DatosDeTipos = new DataTable();

            DatosDeTipos = MiArchivo.MiTipo.Listar();

            cbTipoArchivo.ValueMember = "IDTipoArchivo";

            cbTipoArchivo.DisplayMember = "DescripcionTipoArchivo";

            cbTipoArchivo.DataSource = DatosDeTipos;

            cbTipoArchivo.SelectedIndex = -1;

        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {

            if (DgvListaArchivos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(DgvListaArchivos.CurrentRow.Cells[0].Value.ToString());
                MiArchivo.IDImg = id;
                var Lista = new List<Archivo>();
                Lista = MiArchivo.FiltroArchivos();

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
            else {
                MessageBoxCustom.Show("No has seleccionado ningun archivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        public void LimpiarFormulario(bool LimpiarBusqueda = true) 
        {
            txtRuta.Clear();
            txtNombre.Clear();
            cbTipoArchivo.SelectedIndex = -1;

            if (LimpiarBusqueda)
            {
                txtFiltro.Text = "Buscar...";
            }

            MiArchivo = new Archivo();
            ActivarAjustes();

        }

        private void ActivarAjustes() 
        {
            btnGuardarArchivo.Enabled = true;
            btnEditarArchivo.Enabled = false;
            txtNombre.Enabled = false;
            btnExaminar.Enabled = true;
        }

        private void DgvListaArchivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaArchivos.SelectedRows.Count == 1)
            {
                LimpiarFormulario(false);

                DataGridViewRow MiFila = DgvListaArchivos.SelectedRows[0];

                int CodigoUsuario = Convert.ToInt32(MiFila.Cells["CIDImg"].Value);

                MiArchivo = MiArchivo.ConsultarPorID(CodigoUsuario);

                txtNombre.Text = MiArchivo.Nombre.ToString();

                cbTipoArchivo.SelectedValue = MiArchivo.MiTipo.IDTipoArchivo;

                ActivarEditaryEliminar();

            }
        }

        private void ActivarEditaryEliminar()
        {
            btnGuardarArchivo.Enabled = false;
            btnEditarArchivo.Enabled = true;
            txtNombre.Enabled = true;
            btnExaminar.Enabled = false;
        }

        private void btnEditarArchivo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                Archivo ObjUsuario = MiArchivo.ConsultarPorID(MiArchivo.IDImg);
                if (ObjUsuario.IDImg > 0)
                {
                    string Mensaje = string.Format("Desea Continuar con la Modificacion del archivo: {0}?", MiArchivo.Nombre);

                    DialogResult Continuar = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Continuar == DialogResult.Yes)
                    {

                        if (MiArchivo.Editar())
                        {
                            Bitacora MiBitacora = new Bitacora();
                            string accion = "Actualizar: Se modificio el archivo: " + MiArchivo.Nombre;
                            MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);
                            // se muestra mensaje de exito y se actualiza la lista
                            MessageBoxCustom.Show("El Archivo se ha actualizado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarFormulario();
                            LlenarListaArchivos();
                        }
                        else
                        {
                            MessageBoxCustom.Show("Ha ocurrido un error y no se actualizo el archivo!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Bitacora MiBitacora = new Bitacora();
                            string accion = "Actualizar Fallido: Se intento modificar el archivo: " + MiArchivo.Nombre;
                            MiBitacora.GuardarAccionBitacora(accion, Commons.ObjetosGlobales.MiUsuarioDeSistema.IDUser, Commons.ObjetosGlobales.MiUsuarioDeSistema.FullName);

                        }
                    }
                }
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                MiArchivo.Nombre = txtNombre.Text;
            }
            else
            {
                MiArchivo.Nombre = "";
            }
        }

        public static bool DesactivarSeleccion = false;

        public void DesactivarSelect()
        {
            btnSeleccionarArchivo.Enabled = false;
        }
       
        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            if (DgvListaArchivos.SelectedRows.Count > 0)
            {
                try
                {
                    if (FrmGestionMantenimientos.DesdeMantenimientos)
                    {
                        if (FrmGestionMantenimientos.ParaEvidencia1)
                        {
                            FrmGestionMantenimientos.Evidencia1 = Convert.ToInt32(DgvListaArchivos.SelectedRows[0].Cells["CIDImg"].Value);

                            FrmGestionMantenimientos.ParaEvidencia1 = false;
                            FrmGestionMantenimientos.DesdeMantenimientos = false;
                            this.DialogResult = DialogResult.OK;
                        }
                        if (FrmGestionMantenimientos.ParaEvidencia2)
                        {
                            FrmGestionMantenimientos.Evidencia2 = Convert.ToInt32(DgvListaArchivos.SelectedRows[0].Cells["CIDImg"].Value);

                            FrmGestionMantenimientos.ParaEvidencia2 = false;
                            FrmGestionMantenimientos.DesdeMantenimientos = false;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else if (FrmOrdendeCompra.DesdeOrden)
                    {
                        if (FrmOrdendeCompra.ParaEvidencia1)
                        {
                            FrmOrdendeCompra.Evidencia1 = Convert.ToInt32(DgvListaArchivos.SelectedRows[0].Cells["CIDImg"].Value);

                            FrmOrdendeCompra.ParaEvidencia1 = false;
                            FrmOrdendeCompra.DesdeOrden = false;
                            this.DialogResult = DialogResult.OK;
                        }
                        if (FrmOrdendeCompra.ParaEvidencia2)
                        {
                            FrmOrdendeCompra.Evidencia2 = Convert.ToInt32(DgvListaArchivos.SelectedRows[0].Cells["CIDImg"].Value);

                            FrmOrdendeCompra.ParaEvidencia2 = false;
                            FrmOrdendeCompra.DesdeOrden = false;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        if (FrmGestionGastosVarios.ParaEvidencia1)
                        {
                            FrmGestionGastosVarios.Evidencia1 = Convert.ToInt32(DgvListaArchivos.SelectedRows[0].Cells["CIDImg"].Value);

                            FrmGestionGastosVarios.ParaEvidencia1 = false;
                            this.DialogResult = DialogResult.OK;
                        }
                        if (FrmGestionGastosVarios.ParaEvidencia2)
                        {
                            FrmGestionGastosVarios.Evidencia2 = Convert.ToInt32(DgvListaArchivos.SelectedRows[0].Cells["CIDImg"].Value);

                            FrmGestionGastosVarios.ParaEvidencia2 = false;
                            this.DialogResult = DialogResult.OK;
                        }
                    }


                }
                catch (Exception)
                {
                    this.DialogResult = DialogResult.None;
                }
                
            }
            else
            {
                MessageBoxCustom.Show("No has seleccionado ningun archivo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            DesactivarSeleccion = false;
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            txtFiltro.SelectAll();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cbTipoArchivo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbTipoArchivo.SelectedIndex >= 0)
            {
                MiArchivo.MiTipo.IDTipoArchivo = Convert.ToInt32(cbTipoArchivo.SelectedValue);
            }
            else
            {

                MiArchivo.MiTipo.IDTipoArchivo = 0;
            }
        }
    }
}
