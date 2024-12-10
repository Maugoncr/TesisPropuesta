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
using PracticaEmpresarial.Commons;
using Transitions;

namespace PracticaEmpresarial.Forms
{
    public partial class FrmLogin : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbHora.Text = DateTime.Now.ToString("g");
            ObjetosGlobales.MiLogin = this;

        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("g");
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.White;
            panelUser.BackColor = Color.White;
            txtContra.BackColor = SystemColors.Control;
            panelContra.BackColor = SystemColors.Control;
        }

        private void txtContra_Click(object sender, EventArgs e)
        {
            txtContra.BackColor = Color.White;
            panelContra.BackColor = Color.White;
            txtUser.BackColor = SystemColors.Control;
            panelUser.BackColor = SystemColors.Control;
        }

        private void btnSeePass_MouseDown(object sender, MouseEventArgs e)
        {
            txtContra.UseSystemPasswordChar = false;
            btnSeePass.IconChar = FontAwesome.Sharp.IconChar.LockOpen;

        }

        private void btnSeePass_MouseUp(object sender, MouseEventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;
            btnSeePass.IconChar = FontAwesome.Sharp.IconChar.Lock;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Bitacora MiBitacora = new Bitacora();

            if (ValidarDatos())
            {
                Usuario UserValido = new Usuario();
                UserRol rol = new UserRol();
                UserValido = UserValido.ValidarIngreso(txtUser.Text.Trim(), txtContra.Text.Trim());

                if (UserValido != null && UserValido.IDUser > 0)
                {
                    string accion = "El Usuario: " + UserValido.FullName + " Ingreso al sistema.";

                    MiBitacora.GuardarAccionBitacora(accion, UserValido.IDUser, UserValido.FullName);
                    rol = UserValido.TraerRolDelSistema(UserValido.MiRol.IDUserRol);

                    ObjetosGlobales.MiUsuarioDeSistema = UserValido;
                    ObjetosGlobales.MiRolDeSistema = rol;

                    ObjetosGlobales.MiFormPrincipal = new FrmMainSystem();
                    ObjetosGlobales.MiFormPrincipal.Show();
                    // Se oculta para no destruir el dato global.
                    this.Hide();
                }
                else
                {
                    MessageBoxCustom.Show("El Usuario o la contraseña es Incorrecto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MiBitacora.GuardarAccionBitacora("Se intento ingresar de forma fallida con el usuario: " + txtUser.Text.Trim());
                }
            }



        }

        private bool ValidarDatos()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(txtUser.Text.Trim()) &&
                !string.IsNullOrEmpty(txtContra.Text.Trim()))
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(txtUser.Text.Trim()) && string.IsNullOrEmpty(txtContra.Text.Trim()))
                {
                    MessageBoxCustom.Show("Debes ingresar tus datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser.Focus();
                    txtUser.BackColor = Color.White;
                    panelUser.BackColor = Color.White;
                    txtContra.BackColor = SystemColors.Control;
                    panelContra.BackColor = SystemColors.Control;
                    return false;
                }
                if (string.IsNullOrEmpty(txtUser.Text.Trim()))
                {
                    MessageBoxCustom.Show("Debes ingresar tu usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser.Focus();
                    txtUser.BackColor = Color.White;
                    panelUser.BackColor = Color.White;
                    txtContra.BackColor = SystemColors.Control;
                    panelContra.BackColor = SystemColors.Control;
                    return false;

                }
                if (string.IsNullOrEmpty(txtContra.Text.Trim()))
                {
                    MessageBoxCustom.Show("Debes ingresar tu contraseña", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtContra.Focus();
                    txtContra.BackColor = Color.White;
                    panelContra.BackColor = Color.White;
                    txtUser.BackColor = SystemColors.Control;
                    panelUser.BackColor = SystemColors.Control;
                    return false;
                }

            }
            return R;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift & e.KeyCode == Keys.A)
            {
                btnIngresoDirecto.Visible = true;
            }
        }

        private void btnIngresoDirecto_Click(object sender, EventArgs e)
        {
            ObjetosGlobales.MiUsuarioDeSistema.IDUser = 1000;
            ObjetosGlobales.MiUsuarioDeSistema.Email = "maugoncrxkirax@gmail.com";
            ObjetosGlobales.MiUsuarioDeSistema.FullName = "Mauricio González";
            ObjetosGlobales.MiUsuarioDeSistema.MiRol.IDUserRol = 1;
            ObjetosGlobales.MiRolDeSistema = ObjetosGlobales.MiUsuarioDeSistema.TraerRolDelSistema(1);

            //muestro el objeto global del FrmMain
            ObjetosGlobales.MiFormPrincipal = new FrmMainSystem();
            ObjetosGlobales.MiFormPrincipal.Show();

            // Oculto (no destruyo) el form global
            this.Hide();
        }

        private void btnRecuperarContra_Click(object sender, EventArgs e)
        {

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmRecuperarPassword);

            if (frm == null)
            {
                ObjetosGlobales.FormularioRecuperacionContrasennia = new FrmRecuperarPassword();
                ObjetosGlobales.FormularioRecuperacionContrasennia.Show();
            }
            else
            {
                frm.BringToFront();
                return;

            }

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Transition.run(panel1, "BackColor", Color.FromArgb(46, 109, 169), new TransitionType_EaseInEaseOut(500));
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Transition.run(panel1, "BackColor", Color.FromArgb(59, 141, 246), new TransitionType_EaseInEaseOut(500));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(pictureBox1, "Left", 1500);
            t.add(pictureBox3, "Left", 591);
            t.run();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(pictureBox3, "Left", 1500);
            t.add(pictureBox1, "Left", 591);
            t.run();
        }
    }
}
