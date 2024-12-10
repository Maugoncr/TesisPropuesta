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
    public partial class FrmRecuperarPassword : Form
    {

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Logica.Models.Usuario MyUser { get; set; }

        public Logica.Email MyEmail { get; set; }

        public FrmRecuperarPassword()
        {
            InitializeComponent();

            MyEmail = new Logica.Email();
            MyUser = new Logica.Models.Usuario();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmRecuperarPassword_Load(object sender, EventArgs e)
        {
            txtCodeVerif.Enabled = false;
            txtPassword1.Enabled = false;
            txtPassword2.Enabled = false;
            btnAceptar.Enabled = false;
            

            txtCodeVerif.Clear();
            txtPassword1.Clear();
            txtPassword2.Clear();

        }

        private void btnSeePass1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword1.UseSystemPasswordChar = false;
            btnSeePass1.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
        }

        private void btnSeePass1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword1.UseSystemPasswordChar = true;
            btnSeePass1.IconChar = FontAwesome.Sharp.IconChar.Lock;
        }

        private void btnSeePass2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword2.UseSystemPasswordChar = false;
            btnSeePass2.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
        }

        private void btnSeePass2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword2.UseSystemPasswordChar = true;
            btnSeePass2.IconChar = FontAwesome.Sharp.IconChar.Lock;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                if (Commons.ObjetosGlobales.ValidarEmail(txtEmail.Text.Trim()))
                {
                    
                }
                else
                {
                    MessageBoxCustom.Show("El formato del email no es correcto!!", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                }
            }
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (!string.IsNullOrEmpty(txtEmail.Text.Trim()) &&
                Commons.ObjetosGlobales.ValidarEmail(txtEmail.Text.Trim()))
                {
                    MyUser.Email = txtEmail.Text.Trim();

                    if (MyUser.ConsultarPorEmail())
                    {
                        // Si el correo existe para un usuario activo se procede a enviar el correo con un
                        //codigo de verificacion que el usuario debera digitar para comprobar que sea el

                        //Este codigo se deberia generar aleatoriamente.
                        // TO DO: ???

                        string CodigoVerificacion = GenerarCode();


                        if (MyUser.EnviarCodigoRecuperacion(CodigoVerificacion))
                        {
                            // Se procede a enviar el correo al usuario con el codigo

                            MyEmail.Asunto = "Su código de Recuperación de contraseña para el Sistema de Gestión de Automotores Coarsa";

                            MyEmail.CorreoDestino = MyUser.Email;

                            string Mensaje = string.Format("Su código de recuperación de contraseña es: {0}", CodigoVerificacion);

                            MyEmail.Mensaje = Mensaje;

                            if (MyEmail.EnviarCorreo_Net_Mail_SmtpClient())
                            {
                                MessageBoxCustom.Show("Correo enviado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();

                                string accion = "Enviar: Correo a: " + txtEmail.Text.Trim() + " para la solicitud de cambio de contraseña";

                                MiBitacora.GuardarAccionBitacora(accion, MyUser.IDUser,MyUser.FullName);

                                txtCodeVerif.Enabled = true;
                                txtPassword1.Enabled = true;
                                txtPassword2.Enabled = true;
                                btnAceptar.Enabled = true;

                            }
                            else
                            {
                                MessageBoxCustom.Show("El correo no se pudo enviar!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);

                                Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();

                                string accion = "Enviar Fallido: Correo a: " + txtEmail.Text.Trim() + " para la solicitud de cambio de contraseña";

                                MiBitacora.GuardarAccionBitacora(accion);

                            }

                        }


                    }
                    else
                    {
                        MessageBoxCustom.Show("Lo Sentimos el correo utilizado no se encuentra registrado dentro de algún usuario activo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();

                        string accion = "Recuperar contraseña fallido: Se uso el Correo " + txtEmail.Text.Trim() + " para la solicitar un cambio contraseña";

                        MiBitacora.GuardarAccionBitacora(accion);

                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                this.Cursor = Cursors.Default;

            }

        }

        private string GenerarCode()
        {
            var Caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz*/-";
            var Code = new char[8];
            var random = new Random();
            for (int i = 0; i < Code.Length; i++)
            {
                Code[i] = Caracteres[random.Next(Caracteres.Length)];
            }
            var codeResultado = new String(Code);
            return codeResultado;
        }

        private void txtPassword1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword1.Text.Trim()))
            {
                if (Commons.ObjetosGlobales.ValidarContrasennia(txtPassword1.Text.Trim()))
                {
                   
                }
                else
                {
                    MessageBoxCustom.Show("El formato de la contraseña no es correcto!!\n" +
                        "1. Debe contener al menos una mayúscula y una minúscula\n" +
                        "2. Debe tener una longitud minima de 8 caracteres\n" +
                        "2. Debe contener al menos un numero impar\n" +
                        "3. Debe contener al menos un caracter especial\n",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtPassword1.Focus();
                    txtPassword1.SelectAll();
                }
            }
           
        }

        private bool ValidarContrasennias()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(txtPassword1.Text.Trim()) && !string.IsNullOrEmpty(txtPassword2.Text.Trim())
                && txtPassword1.Text.Trim() == txtPassword2.Text.Trim()
                )
            {
                R = true;
            }
            else
            {

                if (string.IsNullOrEmpty(txtPassword1.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la contraseña", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword1.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(txtPassword2.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la confirmacion de contraseña", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword2.Focus();
                    return false;

                }

                if (!string.IsNullOrEmpty(txtPassword1.Text.Trim()) && !string.IsNullOrEmpty(txtPassword2.Text.Trim())
                && txtPassword1.Text.Trim() != txtPassword2.Text.Trim())
                {
                    MessageBoxCustom.Show("Las contraseñas no coinciden", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword2.Focus();
                    return false;

                }
            }
            return R;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //1. Se debe verificar que el codigo digitado sea el mismo que esta almacenado en la tabla usuario
            //2. las contraseñas deben ser las mismas
            //3. se procede con el cambio de contraseña

            if (!string.IsNullOrEmpty(txtCodeVerif.Text.Trim()) && ValidarContrasennias())
            {
                // el dato del email ya se habia asignado en el proceso de enviar el email al usuario
                MyUser.CodigoRecuperacion = txtCodeVerif.Text.Trim();
                MyUser.Password = txtPassword1.Text.Trim();

                if (MyUser.ComprobarCodigoRecuperacion())
                {
                    //se tiene permiso de modificar la contraseniia
                    if (MyUser.CambiarPassword())
                    {
                        MessageBoxCustom.Show("La Contraseña se ha actualizado correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Logica.Models.Bitacora MiBitacora = new Logica.Models.Bitacora();
                        string accion = "Actualización de Contraseña Exitosa: Correo vinculado: " + txtEmail.Text.Trim();
                        MiBitacora.GuardarAccionBitacora(accion);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se ha cambiado la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El codigo de recuperación digitado no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
