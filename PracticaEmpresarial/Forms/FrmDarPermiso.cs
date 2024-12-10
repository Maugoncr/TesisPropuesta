using CustomMessageBox;
using PracticaEmpresarial.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEmpresarial.Forms
{
    public partial class FrmDarPermiso : Form
    {
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        public FrmDarPermiso()
        {
            InitializeComponent();
            MiUsuarioLocal = new Logica.Models.Usuario();
        }

        public int ID;
        public string Code;

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIDUser_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDUser.Text.Trim()))
            {
                ID = Convert.ToInt32(txtIDUser.Text.Trim());
            }
            else
            {
                ID = 0;
            }
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode.Text.Trim()))
            {
                Code = txtCode.Text.Trim();
            }
            else
            {
                Code = "";
            }
        }

        private void FrmDarPermiso_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txtIDUser.Clear();
            txtCode.Clear();
            Code = "";
            ID = 0;

            MiUsuarioLocal = new Logica.Models.Usuario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if (ID != 0 && Code != "")
            {
                if (MiUsuarioLocal.BuscarCodePermiso(ID, Code))
                {
                    MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(ID);
                    ObjetosGlobales.PermisoConcedidoRapido = true;
                    Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                    string accion = MiUsuarioLocal.FullName +" Habilito Permiso rapido: Al Usuario: " + ObjetosGlobales.MiUsuarioDeSistema.FullName;
                    MiBitacora.GuardarAccionBitacora(accion, MiUsuarioLocal.IDUser, MiUsuarioLocal.FullName);
                    ObjetosGlobales.MiAdministradorPermiso = MiUsuarioLocal;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBoxCustom.Show("Permiso NO concedido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                    string accion = "Intento obtener permiso rapido de forma denegada";
                    MiBitacora.GuardarAccionBitacora(accion, ObjetosGlobales.MiUsuarioDeSistema.IDUser, ObjetosGlobales.MiUsuarioDeSistema.FullName);
                    this.DialogResult = DialogResult.None;
                }
            }
            
        }
    }
}
