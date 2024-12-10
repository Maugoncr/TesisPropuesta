namespace PracticaEmpresarial.Forms
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelContra = new System.Windows.Forms.Panel();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnSeePass = new FontAwesome.Sharp.IconButton();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lbHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRecuperarContra = new System.Windows.Forms.Button();
            this.btnIngresoDirecto = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelUser.SuspendLayout();
            this.panelContra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 598);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(164, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mauricio González Morales";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gestión de Automotores";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(164, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desarrollado por";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 101);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido al Sistema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PracticaEmpresarial.Properties.Resources.icon;
            this.pictureBox2.Location = new System.Drawing.Point(68, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.label5.Location = new System.Drawing.Point(339, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 101);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ingresa en tu cuenta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.SystemColors.Control;
            this.panelUser.Controls.Add(this.txtUser);
            this.panelUser.Controls.Add(this.iconButton1);
            this.panelUser.Location = new System.Drawing.Point(333, 182);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(569, 52);
            this.panelUser.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(50, 17);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(506, 20);
            this.txtUser.TabIndex = 1;
            this.txtUser.Click += new System.EventHandler(this.txtUser_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(11, 10);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(33, 39);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panelContra
            // 
            this.panelContra.BackColor = System.Drawing.SystemColors.Control;
            this.panelContra.Controls.Add(this.txtContra);
            this.panelContra.Controls.Add(this.btnSeePass);
            this.panelContra.Location = new System.Drawing.Point(333, 267);
            this.panelContra.Name = "panelContra";
            this.panelContra.Size = new System.Drawing.Size(569, 52);
            this.panelContra.TabIndex = 5;
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.SystemColors.Control;
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.ForeColor = System.Drawing.Color.Black;
            this.txtContra.Location = new System.Drawing.Point(50, 19);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(506, 20);
            this.txtContra.TabIndex = 6;
            this.txtContra.UseSystemPasswordChar = true;
            this.txtContra.Click += new System.EventHandler(this.txtContra_Click);
            // 
            // btnSeePass
            // 
            this.btnSeePass.FlatAppearance.BorderSize = 0;
            this.btnSeePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeePass.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnSeePass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.btnSeePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeePass.IconSize = 35;
            this.btnSeePass.Location = new System.Drawing.Point(11, 9);
            this.btnSeePass.Name = "btnSeePass";
            this.btnSeePass.Size = new System.Drawing.Size(33, 40);
            this.btnSeePass.TabIndex = 6;
            this.btnSeePass.UseVisualStyleBackColor = true;
            this.btnSeePass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSeePass_MouseDown);
            this.btnSeePass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSeePass_MouseUp);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(372, 345);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(147, 38);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lbHora
            // 
            this.lbHora.BackColor = System.Drawing.Color.Transparent;
            this.lbHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHora.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.lbHora.Location = new System.Drawing.Point(654, 539);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(235, 48);
            this.lbHora.TabIndex = 8;
            this.lbHora.Text = "Hora y Fecha";
            this.lbHora.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRecuperarContra
            // 
            this.btnRecuperarContra.BackColor = System.Drawing.Color.Transparent;
            this.btnRecuperarContra.FlatAppearance.BorderSize = 0;
            this.btnRecuperarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperarContra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperarContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.btnRecuperarContra.Location = new System.Drawing.Point(344, 400);
            this.btnRecuperarContra.Name = "btnRecuperarContra";
            this.btnRecuperarContra.Size = new System.Drawing.Size(206, 38);
            this.btnRecuperarContra.TabIndex = 9;
            this.btnRecuperarContra.Text = "¿Olvido su contraseña?";
            this.btnRecuperarContra.UseVisualStyleBackColor = false;
            this.btnRecuperarContra.Click += new System.EventHandler(this.btnRecuperarContra_Click);
            // 
            // btnIngresoDirecto
            // 
            this.btnIngresoDirecto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIngresoDirecto.IconColor = System.Drawing.Color.Black;
            this.btnIngresoDirecto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresoDirecto.Location = new System.Drawing.Point(647, 347);
            this.btnIngresoDirecto.Name = "btnIngresoDirecto";
            this.btnIngresoDirecto.Size = new System.Drawing.Size(119, 38);
            this.btnIngresoDirecto.TabIndex = 10;
            this.btnIngresoDirecto.Text = "Admin";
            this.btnIngresoDirecto.UseVisualStyleBackColor = true;
            this.btnIngresoDirecto.Click += new System.EventHandler(this.btnIngresoDirecto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PracticaEmpresarial.Properties.Resources.CoarsaLogo;
            this.pictureBox1.Location = new System.Drawing.Point(591, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.Location = new System.Drawing.Point(858, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 50);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PracticaEmpresarial.Properties.Resources.arvaco;
            this.pictureBox3.Location = new System.Drawing.Point(1500, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(257, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 597);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnIngresoDirecto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRecuperarContra);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.panelContra);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesión";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelContra.ResumeLayout(false);
            this.panelContra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelUser;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelContra;
        private FontAwesome.Sharp.IconButton btnSeePass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnIngresar;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRecuperarContra;
        private FontAwesome.Sharp.IconButton btnIngresoDirecto;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}