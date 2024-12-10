using CustomMessageBox;
using PracticaEmpresarial.Commons;
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
    public partial class FrmPlaces : Form
    {

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Logica.Models.Place MiLugar { get; set; }
        private DataTable ListaPlaces { get; set; }

        public FrmPlaces()
        {
            InitializeComponent();

            MiLugar = new Logica.Models.Place();
            ListaPlaces = new DataTable();

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmPlaces_Load(object sender, EventArgs e)
        {
            LlenarListaUsuarios();

            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            txtDescripcion.Clear();
            txtIDPlace.Clear();

            MiLugar = new Logica.Models.Place();

        }

        private void LlenarListaUsuarios()
        {

            ListaPlaces = MiLugar.Listar();
            DgvListaLugares.DataSource = ListaPlaces;
            DgvListaLugares.ClearSelection();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            LlenarListaUsuarios();
        }

        private void DgvListaLugares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaLugares.SelectedRows.Count == 1)
            {
                LimpiarFormulario();

                DataGridViewRow MiFila = DgvListaLugares.SelectedRows[0];

                int CodigoPlace = Convert.ToInt32(MiFila.Cells["CIDPlace"].Value);

                MiLugar = MiLugar.ConsultarPorID(CodigoPlace);

                txtIDPlace.Text = MiLugar.IDPlace.ToString();
                txtDescripcion.Text = MiLugar.Descripcion;

                ActivarEditar();

            }
        }

        private void ActivarEditar()
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin() || ObjetosGlobales.PuedesAgregar())
            {
                if (ValidarDatosRequeridos())
                {

                    bool okDescripcion = MiLugar.ConsultarPorDescripcion();

                    if (!okDescripcion)
                    {
                        string Mensaje = string.Format("¿Realmente deseas agregar este nuevo lugar frecuente {0}?", MiLugar.Descripcion);
                        DialogResult respuesta = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (respuesta == DialogResult.Yes)
                        {
                            if (MiLugar.Agregar())
                            {
                                Logica.Models.Bitacora bitacora = new Logica.Models.Bitacora();

                                string accion = "Agregar: Nuevo Lugar Frecuente: " + MiLugar.Descripcion;

                                bitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser,
                                    ObjetosGlobales.MiUsuarioDeSistema.FullName);

                                MessageBoxCustom.Show("Lugar Agregado Correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                                LlenarListaUsuarios();

                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error agregando el lugar frecuente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }


                    }
                    else
                    {
                        if (okDescripcion)
                        {
                            MessageBox.Show("Ya existe un lugar frecuente ese mismo nombre",
                                "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (!string.IsNullOrEmpty(MiLugar.Descripcion))
            {
                R = true;
            }
            else
            {
                
                if (string.IsNullOrEmpty(MiLugar.Descripcion))
                {
                    MessageBoxCustom.Show("Tienes que agregar un nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return R;
                }
            }

            return R;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 128)
            //    || (e.KeyChar >= 60 && e.KeyChar <= 64) || (e.KeyChar >= 155 && e.KeyChar <= 255))
            //{
            //    MessageBoxCustom.Show("Solo se puede ingresar letras", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    e.Handled = true;
            //    return;
            //}
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                MiLugar.Descripcion = txtDescripcion.Text.Trim();

            }
            else
            {
                MiLugar.Descripcion = "";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ObjetosGlobales.EresAdmin() || ObjetosGlobales.PuedesEditar())
            {
                if (ValidarDatosRequeridos())
                {
                    Logica.Models.Place objRol = MiLugar.ConsultarPorID(MiLugar.IDPlace);

                    if (objRol.IDPlace > 0)
                    {

                        string Mensaje = string.Format("¿Realmente deseas editar el lugar: {0}?", MiLugar.Descripcion);
                        DialogResult respuesta = MessageBoxCustom.Show(Mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (respuesta == DialogResult.Yes)
                        {
                            if (MiLugar.Editar())
                            {
                                Logica.Models.Bitacora bitacora = new Logica.Models.Bitacora();

                                string accion = "Editar el Lugar Frecuente: " + MiLugar.Descripcion;

                                bitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser,
                                    ObjetosGlobales.MiUsuarioDeSistema.FullName);

                                MessageBoxCustom.Show("Lugar Frecuente Editado Correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarFormulario();
                                LlenarListaUsuarios();
                            }
                            else
                            {
                                MessageBoxCustom.Show("Ha ocurrido un error editando el lugar frecuente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
