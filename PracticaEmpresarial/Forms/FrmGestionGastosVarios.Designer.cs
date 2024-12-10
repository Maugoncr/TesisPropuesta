namespace PracticaEmpresarial.Forms
{
    partial class FrmGestionGastosVarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionGastosVarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.btnMini = new FontAwesome.Sharp.IconButton();
            this.DgvListaGastosVarios = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.txtIDGasto = new System.Windows.Forms.TextBox();
            this.cbPlace = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArchivo2 = new System.Windows.Forms.TextBox();
            this.btnSelectArchivo = new FontAwesome.Sharp.IconButton();
            this.btnSelectArchivo2 = new FontAwesome.Sharp.IconButton();
            this.btnBorrar = new FontAwesome.Sharp.IconButton();
            this.btnBorrar2 = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVerArchivo = new FontAwesome.Sharp.IconButton();
            this.btnVerArchivo2 = new FontAwesome.Sharp.IconButton();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelNavRight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOrdenCompra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DTFechaGasto = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkDesactivarOrden = new System.Windows.Forms.CheckBox();
            this.btnBuscarOrden = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarOrden = new FontAwesome.Sharp.IconButton();
            this.CIDGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDOrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CConsecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaGastosVarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1610, 41);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            this.BtnClose.Location = new System.Drawing.Point(1569, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(31, 39);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMini.IconColor = System.Drawing.Color.White;
            this.btnMini.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMini.IconSize = 30;
            this.btnMini.Location = new System.Drawing.Point(1532, 2);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(31, 39);
            this.btnMini.TabIndex = 4;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // DgvListaGastosVarios
            // 
            this.DgvListaGastosVarios.AllowUserToAddRows = false;
            this.DgvListaGastosVarios.AllowUserToDeleteRows = false;
            this.DgvListaGastosVarios.AllowUserToResizeColumns = false;
            this.DgvListaGastosVarios.AllowUserToResizeRows = false;
            this.DgvListaGastosVarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaGastosVarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListaGastosVarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaGastosVarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDGasto,
            this.CIDOrdenCompra,
            this.CConsecutivo,
            this.CDescrip,
            this.CCantidad,
            this.CCosto,
            this.CDescripcion,
            this.CNombre,
            this.CFechaRegistro,
            this.CFechaGasto,
            this.CFechaModificacion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaGastosVarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaGastosVarios.Location = new System.Drawing.Point(33, 92);
            this.DgvListaGastosVarios.MultiSelect = false;
            this.DgvListaGastosVarios.Name = "DgvListaGastosVarios";
            this.DgvListaGastosVarios.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaGastosVarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListaGastosVarios.RowHeadersVisible = false;
            this.DgvListaGastosVarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaGastosVarios.Size = new System.Drawing.Size(1544, 355);
            this.DgvListaGastosVarios.TabIndex = 26;
            this.DgvListaGastosVarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaGastosVarios_CellClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 25;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(1414, 551);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 29);
            this.btnLimpiar.TabIndex = 91;
            this.btnLimpiar.Text = "       Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 20;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(1277, 551);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 29);
            this.btnEditar.TabIndex = 89;
            this.btnEditar.Text = "       Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(1136, 551);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 29);
            this.btnAgregar.TabIndex = 88;
            this.btnAgregar.Text = "       Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(131, 650);
            this.txtCosto.MaxLength = 200;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(311, 24);
            this.txtCosto.TabIndex = 103;
            this.txtCosto.Enter += new System.EventHandler(this.txtCosto_Enter);
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            this.txtCosto.Leave += new System.EventHandler(this.txtCosto_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 628);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 102;
            this.label6.Text = "Costo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 101;
            this.label5.Text = "Tienda de Servicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 677);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 100;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 99;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 98;
            this.label2.Text = "Num Factura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 97;
            this.label1.Text = "Codigo Gasto:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(130, 699);
            this.txtCantidad.MaxLength = 200;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(311, 24);
            this.txtCantidad.TabIndex = 95;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(474, 597);
            this.txtDescripcion.MaxLength = 255;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(273, 126);
            this.txtDescripcion.TabIndex = 94;
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsecutivo.Location = new System.Drawing.Point(130, 597);
            this.txtConsecutivo.MaxLength = 100;
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(249, 24);
            this.txtConsecutivo.TabIndex = 93;
            this.txtConsecutivo.Leave += new System.EventHandler(this.txtConsecutivo_Leave);
            // 
            // txtIDGasto
            // 
            this.txtIDGasto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDGasto.Location = new System.Drawing.Point(131, 499);
            this.txtIDGasto.Name = "txtIDGasto";
            this.txtIDGasto.ReadOnly = true;
            this.txtIDGasto.Size = new System.Drawing.Size(112, 24);
            this.txtIDGasto.TabIndex = 92;
            // 
            // cbPlace
            // 
            this.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlace.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlace.FormattingEnabled = true;
            this.cbPlace.Location = new System.Drawing.Point(474, 498);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(273, 25);
            this.cbPlace.TabIndex = 104;
            this.cbPlace.SelectionChangeCommitted += new System.EventHandler(this.cbPlace_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(792, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 106;
            this.label7.Text = "Archivo 1:";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivo.Location = new System.Drawing.Point(796, 499);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(112, 24);
            this.txtArchivo.TabIndex = 105;
            this.txtArchivo.TextChanged += new System.EventHandler(this.txtArchivo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(792, 527);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 108;
            this.label8.Text = "Archivo 2";
            // 
            // txtArchivo2
            // 
            this.txtArchivo2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivo2.Location = new System.Drawing.Point(796, 549);
            this.txtArchivo2.Name = "txtArchivo2";
            this.txtArchivo2.ReadOnly = true;
            this.txtArchivo2.Size = new System.Drawing.Size(112, 24);
            this.txtArchivo2.TabIndex = 107;
            this.txtArchivo2.TextChanged += new System.EventHandler(this.txtArchivo2_TextChanged);
            // 
            // btnSelectArchivo
            // 
            this.btnSelectArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnSelectArchivo.FlatAppearance.BorderSize = 0;
            this.btnSelectArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectArchivo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnSelectArchivo.IconColor = System.Drawing.Color.White;
            this.btnSelectArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectArchivo.IconSize = 20;
            this.btnSelectArchivo.Location = new System.Drawing.Point(926, 499);
            this.btnSelectArchivo.Name = "btnSelectArchivo";
            this.btnSelectArchivo.Size = new System.Drawing.Size(28, 24);
            this.btnSelectArchivo.TabIndex = 109;
            this.btnSelectArchivo.UseVisualStyleBackColor = false;
            this.btnSelectArchivo.Click += new System.EventHandler(this.btnSelectArchivo_Click);
            // 
            // btnSelectArchivo2
            // 
            this.btnSelectArchivo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnSelectArchivo2.FlatAppearance.BorderSize = 0;
            this.btnSelectArchivo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectArchivo2.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnSelectArchivo2.IconColor = System.Drawing.Color.White;
            this.btnSelectArchivo2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectArchivo2.IconSize = 20;
            this.btnSelectArchivo2.Location = new System.Drawing.Point(926, 549);
            this.btnSelectArchivo2.Name = "btnSelectArchivo2";
            this.btnSelectArchivo2.Size = new System.Drawing.Size(28, 24);
            this.btnSelectArchivo2.TabIndex = 110;
            this.btnSelectArchivo2.UseVisualStyleBackColor = false;
            this.btnSelectArchivo2.Click += new System.EventHandler(this.btnSelectArchivo2_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnBorrar.IconColor = System.Drawing.Color.White;
            this.btnBorrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar.IconSize = 20;
            this.btnBorrar.Location = new System.Drawing.Point(966, 499);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(28, 24);
            this.btnBorrar.TabIndex = 111;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBorrar2
            // 
            this.btnBorrar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnBorrar2.FlatAppearance.BorderSize = 0;
            this.btnBorrar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnBorrar2.IconColor = System.Drawing.Color.White;
            this.btnBorrar2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorrar2.IconSize = 20;
            this.btnBorrar2.Location = new System.Drawing.Point(966, 549);
            this.btnBorrar2.Name = "btnBorrar2";
            this.btnBorrar2.Size = new System.Drawing.Size(28, 24);
            this.btnBorrar2.TabIndex = 112;
            this.btnBorrar2.UseVisualStyleBackColor = false;
            this.btnBorrar2.Click += new System.EventHandler(this.btnBorrar2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.label9.Location = new System.Drawing.Point(1195, 615);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(284, 49);
            this.label9.TabIndex = 113;
            this.label9.Text = "Gastos Varios";
            // 
            // btnVerArchivo
            // 
            this.btnVerArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnVerArchivo.FlatAppearance.BorderSize = 0;
            this.btnVerArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerArchivo.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVerArchivo.IconColor = System.Drawing.Color.White;
            this.btnVerArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerArchivo.IconSize = 25;
            this.btnVerArchivo.Location = new System.Drawing.Point(1006, 499);
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Size = new System.Drawing.Size(28, 24);
            this.btnVerArchivo.TabIndex = 114;
            this.btnVerArchivo.UseVisualStyleBackColor = false;
            this.btnVerArchivo.Click += new System.EventHandler(this.btnVerArchivo_Click);
            // 
            // btnVerArchivo2
            // 
            this.btnVerArchivo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnVerArchivo2.FlatAppearance.BorderSize = 0;
            this.btnVerArchivo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerArchivo2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVerArchivo2.IconColor = System.Drawing.Color.White;
            this.btnVerArchivo2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerArchivo2.IconSize = 25;
            this.btnVerArchivo2.Location = new System.Drawing.Point(1006, 549);
            this.btnVerArchivo2.Name = "btnVerArchivo2";
            this.btnVerArchivo2.Size = new System.Drawing.Size(28, 24);
            this.btnVerArchivo2.TabIndex = 115;
            this.btnVerArchivo2.UseVisualStyleBackColor = false;
            this.btnVerArchivo2.Click += new System.EventHandler(this.btnVerArchivo2_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(428, 62);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(693, 24);
            this.txtFiltro.TabIndex = 116;
            this.txtFiltro.Text = "Buscar...";
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltro.Click += new System.EventHandler(this.txtFiltro_Click);
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 766);
            this.panel3.TabIndex = 117;
            // 
            // panelNavRight
            // 
            this.panelNavRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.panelNavRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNavRight.Location = new System.Drawing.Point(1600, 41);
            this.panelNavRight.Name = "panelNavRight";
            this.panelNavRight.Size = new System.Drawing.Size(10, 766);
            this.panelNavRight.TabIndex = 118;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 797);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1590, 10);
            this.panel2.TabIndex = 119;
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdenCompra.Location = new System.Drawing.Point(131, 548);
            this.txtOrdenCompra.MaxLength = 150;
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.ReadOnly = true;
            this.txtOrdenCompra.Size = new System.Drawing.Size(186, 24);
            this.txtOrdenCompra.TabIndex = 120;
            this.txtOrdenCompra.TextChanged += new System.EventHandler(this.txtOrdenCompra_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(127, 526);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 19);
            this.label10.TabIndex = 121;
            this.label10.Text = "Orden de Compra:";
            // 
            // cbCompany
            // 
            this.cbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompany.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(474, 546);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(273, 25);
            this.cbCompany.TabIndex = 122;
            this.cbCompany.SelectionChangeCommitted += new System.EventHandler(this.cbCompany_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(470, 525);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 19);
            this.label11.TabIndex = 123;
            this.label11.Text = "Compañia:";
            // 
            // DTFechaGasto
            // 
            this.DTFechaGasto.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaGasto.CustomFormat = "dd/MM/yyyy";
            this.DTFechaGasto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaGasto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTFechaGasto.Location = new System.Drawing.Point(796, 615);
            this.DTFechaGasto.Name = "DTFechaGasto";
            this.DTFechaGasto.Size = new System.Drawing.Size(173, 23);
            this.DTFechaGasto.TabIndex = 189;
            this.DTFechaGasto.ValueChanged += new System.EventHandler(this.DTFechaGasto_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(792, 594);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(241, 19);
            this.label12.TabIndex = 188;
            this.label12.Text = "Fecha cuando se realizo el gasto:";
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExportar.IconColor = System.Drawing.Color.Black;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.Location = new System.Drawing.Point(1465, 453);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(112, 31);
            this.btnExportar.TabIndex = 190;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PracticaEmpresarial.Properties.Resources.exclamationOrden;
            this.pictureBox2.Location = new System.Drawing.Point(1019, 644);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 194;
            this.pictureBox2.TabStop = false;
            // 
            // checkDesactivarOrden
            // 
            this.checkDesactivarOrden.AutoSize = true;
            this.checkDesactivarOrden.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDesactivarOrden.Location = new System.Drawing.Point(796, 653);
            this.checkDesactivarOrden.Name = "checkDesactivarOrden";
            this.checkDesactivarOrden.Size = new System.Drawing.Size(227, 21);
            this.checkDesactivarOrden.TabIndex = 193;
            this.checkDesactivarOrden.Text = "MARCAR ORDEN COMO USADA";
            this.checkDesactivarOrden.UseVisualStyleBackColor = true;
            // 
            // btnBuscarOrden
            // 
            this.btnBuscarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnBuscarOrden.FlatAppearance.BorderSize = 0;
            this.btnBuscarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarOrden.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnBuscarOrden.IconColor = System.Drawing.Color.White;
            this.btnBuscarOrden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarOrden.IconSize = 20;
            this.btnBuscarOrden.Location = new System.Drawing.Point(326, 547);
            this.btnBuscarOrden.Name = "btnBuscarOrden";
            this.btnBuscarOrden.Size = new System.Drawing.Size(28, 24);
            this.btnBuscarOrden.TabIndex = 195;
            this.btnBuscarOrden.UseVisualStyleBackColor = false;
            this.btnBuscarOrden.Click += new System.EventHandler(this.btnBuscarOrden_Click);
            // 
            // btnLimpiarOrden
            // 
            this.btnLimpiarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnLimpiarOrden.FlatAppearance.BorderSize = 0;
            this.btnLimpiarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarOrden.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnLimpiarOrden.IconColor = System.Drawing.Color.White;
            this.btnLimpiarOrden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarOrden.IconSize = 20;
            this.btnLimpiarOrden.Location = new System.Drawing.Point(360, 547);
            this.btnLimpiarOrden.Name = "btnLimpiarOrden";
            this.btnLimpiarOrden.Size = new System.Drawing.Size(28, 24);
            this.btnLimpiarOrden.TabIndex = 196;
            this.btnLimpiarOrden.UseVisualStyleBackColor = false;
            this.btnLimpiarOrden.Click += new System.EventHandler(this.btnLimpiarOrden_Click);
            // 
            // CIDGasto
            // 
            this.CIDGasto.DataPropertyName = "IDGasto";
            this.CIDGasto.HeaderText = "Código Gasto";
            this.CIDGasto.Name = "CIDGasto";
            this.CIDGasto.ReadOnly = true;
            // 
            // CIDOrdenCompra
            // 
            this.CIDOrdenCompra.DataPropertyName = "IDOrdenCompra";
            this.CIDOrdenCompra.HeaderText = "Orden de Compra";
            this.CIDOrdenCompra.Name = "CIDOrdenCompra";
            this.CIDOrdenCompra.ReadOnly = true;
            this.CIDOrdenCompra.Width = 150;
            // 
            // CConsecutivo
            // 
            this.CConsecutivo.DataPropertyName = "Consecutivo";
            this.CConsecutivo.HeaderText = "Consecutivo";
            this.CConsecutivo.Name = "CConsecutivo";
            this.CConsecutivo.ReadOnly = true;
            // 
            // CDescrip
            // 
            this.CDescrip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDescrip.DataPropertyName = "Descrip";
            this.CDescrip.HeaderText = "Descripcion";
            this.CDescrip.Name = "CDescrip";
            this.CDescrip.ReadOnly = true;
            // 
            // CCantidad
            // 
            this.CCantidad.DataPropertyName = "Cantidad";
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.ReadOnly = true;
            // 
            // CCosto
            // 
            this.CCosto.DataPropertyName = "Costo";
            this.CCosto.HeaderText = "Costo";
            this.CCosto.Name = "CCosto";
            this.CCosto.ReadOnly = true;
            this.CCosto.Width = 130;
            // 
            // CDescripcion
            // 
            this.CDescripcion.DataPropertyName = "Descripcion";
            this.CDescripcion.HeaderText = "Servicentro";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            this.CDescripcion.Width = 180;
            // 
            // CNombre
            // 
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Compañia";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CFechaRegistro
            // 
            this.CFechaRegistro.DataPropertyName = "FechaRegistro";
            this.CFechaRegistro.HeaderText = "Fecha Registro";
            this.CFechaRegistro.Name = "CFechaRegistro";
            this.CFechaRegistro.ReadOnly = true;
            this.CFechaRegistro.Width = 150;
            // 
            // CFechaGasto
            // 
            this.CFechaGasto.DataPropertyName = "FechaGasto";
            this.CFechaGasto.HeaderText = "Fecha Gasto";
            this.CFechaGasto.Name = "CFechaGasto";
            this.CFechaGasto.ReadOnly = true;
            this.CFechaGasto.Width = 150;
            // 
            // CFechaModificacion
            // 
            this.CFechaModificacion.DataPropertyName = "FechaModificacion";
            this.CFechaModificacion.HeaderText = "Fecha Ultima Modificacion";
            this.CFechaModificacion.Name = "CFechaModificacion";
            this.CFechaModificacion.ReadOnly = true;
            this.CFechaModificacion.Width = 150;
            // 
            // FrmGestionGastosVarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 807);
            this.Controls.Add(this.btnLimpiarOrden);
            this.Controls.Add(this.btnBuscarOrden);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkDesactivarOrden);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.DTFechaGasto);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOrdenCompra);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNavRight);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnVerArchivo2);
            this.Controls.Add(this.btnVerArchivo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBorrar2);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSelectArchivo2);
            this.Controls.Add(this.btnSelectArchivo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtArchivo2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.cbPlace);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtConsecutivo);
            this.Controls.Add(this.txtIDGasto);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.DgvListaGastosVarios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionGastosVarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Gastos Variados";
            this.Load += new System.EventHandler(this.FrmGestionGastosVarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaGastosVarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton btnMini;
        private System.Windows.Forms.DataGridView DgvListaGastosVarios;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.TextBox txtIDGasto;
        private System.Windows.Forms.ComboBox cbPlace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtArchivo2;
        private FontAwesome.Sharp.IconButton btnSelectArchivo;
        private FontAwesome.Sharp.IconButton btnSelectArchivo2;
        private FontAwesome.Sharp.IconButton btnBorrar;
        private FontAwesome.Sharp.IconButton btnBorrar2;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnVerArchivo;
        private FontAwesome.Sharp.IconButton btnVerArchivo2;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelNavRight;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.TextBox txtOrdenCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DTFechaGasto;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btnExportar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkDesactivarOrden;
        private FontAwesome.Sharp.IconButton btnBuscarOrden;
        private FontAwesome.Sharp.IconButton btnLimpiarOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDOrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CConsecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaModificacion;
    }
}