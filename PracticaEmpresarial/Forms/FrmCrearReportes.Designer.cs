namespace PracticaEmpresarial.Forms
{
    partial class FrmCrearReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearReportes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.panelNavRight = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarCompanyMantenimiento = new FontAwesome.Sharp.IconButton();
            this.checkFechasMantenimiento = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCompany3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearMantenimientoR = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtHastaMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.dtDesdeMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarCompanyGasto = new FontAwesome.Sharp.IconButton();
            this.checkFechasGastos = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCompany2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtHastaGasto = new System.Windows.Forms.DateTimePicker();
            this.dtDesdeGasto = new System.Windows.Forms.DateTimePicker();
            this.btnCrearGastoR = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.btnBorrarPlaca = new FontAwesome.Sharp.IconButton();
            this.btnBuscarVehiculo = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btnCrearVehiculoR = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 51);
            this.panel1.TabIndex = 93;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(504, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 49);
            this.label7.TabIndex = 98;
            this.label7.Text = "Reportes";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.BtnClose.IconColor = System.Drawing.Color.White;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 30;
            this.BtnClose.Location = new System.Drawing.Point(1182, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(31, 39);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panelNavRight
            // 
            this.panelNavRight.BackColor = System.Drawing.Color.Teal;
            this.panelNavRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNavRight.Location = new System.Drawing.Point(1206, 51);
            this.panelNavRight.Name = "panelNavRight";
            this.panelNavRight.Size = new System.Drawing.Size(10, 294);
            this.panelNavRight.TabIndex = 95;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 294);
            this.panel3.TabIndex = 96;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 10);
            this.panel2.TabIndex = 97;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarCompanyMantenimiento);
            this.groupBox1.Controls.Add(this.checkFechasMantenimiento);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbCompany3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCrearMantenimientoR);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtHastaMantenimiento);
            this.groupBox1.Controls.Add(this.dtDesdeMantenimiento);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 232);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimientos";
            // 
            // btnEliminarCompanyMantenimiento
            // 
            this.btnEliminarCompanyMantenimiento.FlatAppearance.BorderSize = 0;
            this.btnEliminarCompanyMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCompanyMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarCompanyMantenimiento.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.btnEliminarCompanyMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCompanyMantenimiento.IconSize = 25;
            this.btnEliminarCompanyMantenimiento.Location = new System.Drawing.Point(294, 140);
            this.btnEliminarCompanyMantenimiento.Name = "btnEliminarCompanyMantenimiento";
            this.btnEliminarCompanyMantenimiento.Size = new System.Drawing.Size(26, 30);
            this.btnEliminarCompanyMantenimiento.TabIndex = 112;
            this.btnEliminarCompanyMantenimiento.UseVisualStyleBackColor = true;
            this.btnEliminarCompanyMantenimiento.Click += new System.EventHandler(this.btnEliminarCompanyMantenimiento_Click);
            // 
            // checkFechasMantenimiento
            // 
            this.checkFechasMantenimiento.AutoSize = true;
            this.checkFechasMantenimiento.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFechasMantenimiento.Location = new System.Drawing.Point(133, 18);
            this.checkFechasMantenimiento.Name = "checkFechasMantenimiento";
            this.checkFechasMantenimiento.Size = new System.Drawing.Size(103, 23);
            this.checkFechasMantenimiento.TabIndex = 109;
            this.checkFechasMantenimiento.Text = "Por fechas:";
            this.checkFechasMantenimiento.UseVisualStyleBackColor = true;
            this.checkFechasMantenimiento.CheckedChanged += new System.EventHandler(this.checkFechasMantenimiento_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 108;
            this.label9.Text = "Compañia:";
            // 
            // cbCompany3
            // 
            this.cbCompany3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompany3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompany3.FormattingEnabled = true;
            this.cbCompany3.Location = new System.Drawing.Point(60, 142);
            this.cbCompany3.Name = "cbCompany3";
            this.cbCompany3.Size = new System.Drawing.Size(228, 25);
            this.cbCompany3.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 99;
            this.label2.Text = "Hasta:";
            // 
            // btnCrearMantenimientoR
            // 
            this.btnCrearMantenimientoR.BackColor = System.Drawing.Color.Teal;
            this.btnCrearMantenimientoR.FlatAppearance.BorderSize = 0;
            this.btnCrearMantenimientoR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearMantenimientoR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearMantenimientoR.ForeColor = System.Drawing.Color.White;
            this.btnCrearMantenimientoR.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCrearMantenimientoR.IconColor = System.Drawing.Color.White;
            this.btnCrearMantenimientoR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearMantenimientoR.IconSize = 25;
            this.btnCrearMantenimientoR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearMantenimientoR.Location = new System.Drawing.Point(123, 182);
            this.btnCrearMantenimientoR.Name = "btnCrearMantenimientoR";
            this.btnCrearMantenimientoR.Size = new System.Drawing.Size(113, 29);
            this.btnCrearMantenimientoR.TabIndex = 89;
            this.btnCrearMantenimientoR.Text = "        Crear";
            this.btnCrearMantenimientoR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearMantenimientoR.UseVisualStyleBackColor = false;
            this.btnCrearMantenimientoR.Click += new System.EventHandler(this.btnCrearMantenimientoR_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 98;
            this.label3.Text = "Desde:";
            // 
            // dtHastaMantenimiento
            // 
            this.dtHastaMantenimiento.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHastaMantenimiento.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHastaMantenimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHastaMantenimiento.Location = new System.Drawing.Point(166, 78);
            this.dtHastaMantenimiento.Name = "dtHastaMantenimiento";
            this.dtHastaMantenimiento.Size = new System.Drawing.Size(107, 24);
            this.dtHastaMantenimiento.TabIndex = 96;
            // 
            // dtDesdeMantenimiento
            // 
            this.dtDesdeMantenimiento.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesdeMantenimiento.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesdeMantenimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesdeMantenimiento.Location = new System.Drawing.Point(166, 47);
            this.dtDesdeMantenimiento.Name = "dtDesdeMantenimiento";
            this.dtDesdeMantenimiento.Size = new System.Drawing.Size(107, 24);
            this.dtDesdeMantenimiento.TabIndex = 95;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarCompanyGasto);
            this.groupBox2.Controls.Add(this.checkFechasGastos);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbCompany2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtHastaGasto);
            this.groupBox2.Controls.Add(this.dtDesdeGasto);
            this.groupBox2.Controls.Add(this.btnCrearGastoR);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(419, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 232);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gastos";
            // 
            // btnEliminarCompanyGasto
            // 
            this.btnEliminarCompanyGasto.FlatAppearance.BorderSize = 0;
            this.btnEliminarCompanyGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCompanyGasto.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarCompanyGasto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.btnEliminarCompanyGasto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCompanyGasto.IconSize = 25;
            this.btnEliminarCompanyGasto.Location = new System.Drawing.Point(306, 140);
            this.btnEliminarCompanyGasto.Name = "btnEliminarCompanyGasto";
            this.btnEliminarCompanyGasto.Size = new System.Drawing.Size(26, 30);
            this.btnEliminarCompanyGasto.TabIndex = 111;
            this.btnEliminarCompanyGasto.UseVisualStyleBackColor = true;
            this.btnEliminarCompanyGasto.Click += new System.EventHandler(this.btnEliminarCompanyGasto_Click);
            // 
            // checkFechasGastos
            // 
            this.checkFechasGastos.AutoSize = true;
            this.checkFechasGastos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFechasGastos.Location = new System.Drawing.Point(138, 18);
            this.checkFechasGastos.Name = "checkFechasGastos";
            this.checkFechasGastos.Size = new System.Drawing.Size(103, 23);
            this.checkFechasGastos.TabIndex = 110;
            this.checkFechasGastos.Text = "Por fechas:";
            this.checkFechasGastos.UseVisualStyleBackColor = true;
            this.checkFechasGastos.CheckedChanged += new System.EventHandler(this.checkFechasGastos_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(141, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 106;
            this.label8.Text = "Compañia:";
            // 
            // cbCompany2
            // 
            this.cbCompany2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompany2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompany2.FormattingEnabled = true;
            this.cbCompany2.Location = new System.Drawing.Point(72, 142);
            this.cbCompany2.Name = "cbCompany2";
            this.cbCompany2.Size = new System.Drawing.Size(228, 25);
            this.cbCompany2.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 103;
            this.label4.Text = "Hasta:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 102;
            this.label5.Text = "Desde:";
            // 
            // dtHastaGasto
            // 
            this.dtHastaGasto.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHastaGasto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHastaGasto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHastaGasto.Location = new System.Drawing.Point(172, 78);
            this.dtHastaGasto.Name = "dtHastaGasto";
            this.dtHastaGasto.Size = new System.Drawing.Size(107, 24);
            this.dtHastaGasto.TabIndex = 101;
            // 
            // dtDesdeGasto
            // 
            this.dtDesdeGasto.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesdeGasto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDesdeGasto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDesdeGasto.Location = new System.Drawing.Point(172, 47);
            this.dtDesdeGasto.Name = "dtDesdeGasto";
            this.dtDesdeGasto.Size = new System.Drawing.Size(107, 24);
            this.dtDesdeGasto.TabIndex = 100;
            // 
            // btnCrearGastoR
            // 
            this.btnCrearGastoR.BackColor = System.Drawing.Color.Teal;
            this.btnCrearGastoR.FlatAppearance.BorderSize = 0;
            this.btnCrearGastoR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearGastoR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearGastoR.ForeColor = System.Drawing.Color.White;
            this.btnCrearGastoR.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCrearGastoR.IconColor = System.Drawing.Color.White;
            this.btnCrearGastoR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearGastoR.IconSize = 25;
            this.btnCrearGastoR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearGastoR.Location = new System.Drawing.Point(128, 182);
            this.btnCrearGastoR.Name = "btnCrearGastoR";
            this.btnCrearGastoR.Size = new System.Drawing.Size(113, 29);
            this.btnCrearGastoR.TabIndex = 89;
            this.btnCrearGastoR.Text = "        Crear";
            this.btnCrearGastoR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearGastoR.UseVisualStyleBackColor = false;
            this.btnCrearGastoR.Click += new System.EventHandler(this.btnCrearGastoR_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbCompany);
            this.groupBox3.Controls.Add(this.btnBorrarPlaca);
            this.groupBox3.Controls.Add(this.btnBuscarVehiculo);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtPlaca);
            this.groupBox3.Controls.Add(this.btnCrearVehiculoR);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(804, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 232);
            this.groupBox3.TabIndex = 100;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vehiculos";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 103;
            this.label6.Text = "Compañia:";
            // 
            // cbCompany
            // 
            this.cbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompany.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(70, 140);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(228, 25);
            this.cbCompany.TabIndex = 98;
            this.cbCompany.SelectionChangeCommitted += new System.EventHandler(this.cbCompany_SelectionChangeCommitted);
            // 
            // btnBorrarPlaca
            // 
            this.btnBorrarPlaca.FlatAppearance.BorderSize = 0;
            this.btnBorrarPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPlaca.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnBorrarPlaca.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.btnBorrarPlaca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrarPlaca.IconSize = 25;
            this.btnBorrarPlaca.Location = new System.Drawing.Point(340, 60);
            this.btnBorrarPlaca.Name = "btnBorrarPlaca";
            this.btnBorrarPlaca.Size = new System.Drawing.Size(26, 30);
            this.btnBorrarPlaca.TabIndex = 97;
            this.btnBorrarPlaca.UseVisualStyleBackColor = true;
            this.btnBorrarPlaca.Click += new System.EventHandler(this.btnBorrarPlaca_Click);
            // 
            // btnBuscarVehiculo
            // 
            this.btnBuscarVehiculo.FlatAppearance.BorderSize = 0;
            this.btnBuscarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVehiculo.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscarVehiculo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.btnBuscarVehiculo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarVehiculo.IconSize = 30;
            this.btnBuscarVehiculo.Location = new System.Drawing.Point(304, 60);
            this.btnBuscarVehiculo.Name = "btnBuscarVehiculo";
            this.btnBuscarVehiculo.Size = new System.Drawing.Size(26, 30);
            this.btnBuscarVehiculo.TabIndex = 96;
            this.btnBuscarVehiculo.UseVisualStyleBackColor = true;
            this.btnBuscarVehiculo.Click += new System.EventHandler(this.btnBuscarVehiculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 95;
            this.label1.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(70, 63);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = true;
            this.txtPlaca.Size = new System.Drawing.Size(228, 27);
            this.txtPlaca.TabIndex = 94;
            // 
            // btnCrearVehiculoR
            // 
            this.btnCrearVehiculoR.BackColor = System.Drawing.Color.Teal;
            this.btnCrearVehiculoR.FlatAppearance.BorderSize = 0;
            this.btnCrearVehiculoR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearVehiculoR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearVehiculoR.ForeColor = System.Drawing.Color.White;
            this.btnCrearVehiculoR.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCrearVehiculoR.IconColor = System.Drawing.Color.White;
            this.btnCrearVehiculoR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearVehiculoR.IconSize = 25;
            this.btnCrearVehiculoR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearVehiculoR.Location = new System.Drawing.Point(133, 182);
            this.btnCrearVehiculoR.Name = "btnCrearVehiculoR";
            this.btnCrearVehiculoR.Size = new System.Drawing.Size(113, 29);
            this.btnCrearVehiculoR.TabIndex = 89;
            this.btnCrearVehiculoR.Text = "        Crear";
            this.btnCrearVehiculoR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearVehiculoR.UseVisualStyleBackColor = false;
            this.btnCrearVehiculoR.Click += new System.EventHandler(this.btnCrearVehiculoR_Click);
            // 
            // FrmCrearReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 345);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelNavRight);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCrearReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Reportes";
            this.Load += new System.EventHandler(this.FrmCrearReportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Panel panelNavRight;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnCrearMantenimientoR;
        private FontAwesome.Sharp.IconButton btnCrearGastoR;
        private FontAwesome.Sharp.IconButton btnCrearVehiculoR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtHastaMantenimiento;
        private System.Windows.Forms.DateTimePicker dtDesdeMantenimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtHastaGasto;
        private System.Windows.Forms.DateTimePicker dtDesdeGasto;
        private FontAwesome.Sharp.IconButton btnBuscarVehiculo;
        private FontAwesome.Sharp.IconButton btnBorrarPlaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCompany2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCompany3;
        private System.Windows.Forms.CheckBox checkFechasMantenimiento;
        private System.Windows.Forms.CheckBox checkFechasGastos;
        private FontAwesome.Sharp.IconButton btnEliminarCompanyGasto;
        private FontAwesome.Sharp.IconButton btnEliminarCompanyMantenimiento;
    }
}