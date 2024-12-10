namespace PracticaEmpresarial.Forms
{
    partial class FrmGestionMantenimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionMantenimientos));
            this.DgvListaM = new System.Windows.Forms.DataGridView();
            this.CIDMantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CConsecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDOrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDetalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaMantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CKilometraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.btnMini = new FontAwesome.Sharp.IconButton();
            this.cbTipoMantenimiento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKmNuevo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKilometrajeAntes = new System.Windows.Forms.TextBox();
            this.txtKilometrajeNuevo = new System.Windows.Forms.TextBox();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.txtIDMantenimiento = new System.Windows.Forms.TextBox();
            this.cbPlace = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.lbLitros = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelNavRight = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtArchivo2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtTipoVehiculo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtIDCarro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLimpiarCarro = new FontAwesome.Sharp.IconButton();
            this.btnBuscarCarro = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNombreChofer = new System.Windows.Forms.TextBox();
            this.txtIDChofer = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnLimpiarChofer = new FontAwesome.Sharp.IconButton();
            this.btnBuscarChofer = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrdenCompra = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.lbKmRecorridos = new System.Windows.Forms.Label();
            this.txtKilometrosRecorridos = new System.Windows.Forms.TextBox();
            this.lbCostoLitro = new System.Windows.Forms.Label();
            this.txtCostoLitro = new System.Windows.Forms.TextBox();
            this.lbCostoKm = new System.Windows.Forms.Label();
            this.txtCostoKm = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.DpOilDate = new System.Windows.Forms.DateTimePicker();
            this.lbCambioAceite = new System.Windows.Forms.Label();
            this.DateTimeRTV = new System.Windows.Forms.DateTimePicker();
            this.lbProximoRTV = new System.Windows.Forms.Label();
            this.lbProximoMarchamo = new System.Windows.Forms.Label();
            this.txtMarchamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DTFechaMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.checkDesactivarOrden = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLimpiarOrden = new FontAwesome.Sharp.IconButton();
            this.btnBuscarOrden = new FontAwesome.Sharp.IconButton();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            this.btnCalculator = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnVerArchivo2 = new FontAwesome.Sharp.IconButton();
            this.btnVerArchivo = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarArchivo2 = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarArchivo = new FontAwesome.Sharp.IconButton();
            this.btnSelectArchivo2 = new FontAwesome.Sharp.IconButton();
            this.btnSelectArchivo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaM)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListaM
            // 
            this.DgvListaM.AllowUserToAddRows = false;
            this.DgvListaM.AllowUserToDeleteRows = false;
            this.DgvListaM.AllowUserToResizeColumns = false;
            this.DgvListaM.AllowUserToResizeRows = false;
            this.DgvListaM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListaM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDMantenimiento,
            this.CConsecutivo,
            this.CIDOrdenCompra,
            this.CDetalle,
            this.CDetalles,
            this.CCosto,
            this.CFechaRegistro,
            this.CFechaMantenimiento,
            this.CFechaModificacion,
            this.CPlaca,
            this.CKilometraje,
            this.CNombre,
            this.CDescripcion,
            this.CFullName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaM.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaM.Location = new System.Drawing.Point(27, 79);
            this.DgvListaM.MultiSelect = false;
            this.DgvListaM.Name = "DgvListaM";
            this.DgvListaM.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaM.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListaM.RowHeadersVisible = false;
            this.DgvListaM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaM.Size = new System.Drawing.Size(1763, 393);
            this.DgvListaM.TabIndex = 27;
            this.DgvListaM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaM_CellClick);
            // 
            // CIDMantenimiento
            // 
            this.CIDMantenimiento.DataPropertyName = "IDMantenimiento";
            this.CIDMantenimiento.HeaderText = "Código";
            this.CIDMantenimiento.Name = "CIDMantenimiento";
            this.CIDMantenimiento.ReadOnly = true;
            this.CIDMantenimiento.Width = 70;
            // 
            // CConsecutivo
            // 
            this.CConsecutivo.DataPropertyName = "Consecutivo";
            this.CConsecutivo.HeaderText = "Factura";
            this.CConsecutivo.Name = "CConsecutivo";
            this.CConsecutivo.ReadOnly = true;
            this.CConsecutivo.Width = 110;
            // 
            // CIDOrdenCompra
            // 
            this.CIDOrdenCompra.DataPropertyName = "IDOrdenCompra";
            this.CIDOrdenCompra.HeaderText = "Orden de Compra";
            this.CIDOrdenCompra.Name = "CIDOrdenCompra";
            this.CIDOrdenCompra.ReadOnly = true;
            this.CIDOrdenCompra.Width = 110;
            // 
            // CDetalle
            // 
            this.CDetalle.DataPropertyName = "Detalle";
            this.CDetalle.HeaderText = "Tipo";
            this.CDetalle.Name = "CDetalle";
            this.CDetalle.ReadOnly = true;
            this.CDetalle.Width = 180;
            // 
            // CDetalles
            // 
            this.CDetalles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDetalles.DataPropertyName = "Detalles";
            this.CDetalles.HeaderText = "Detalles";
            this.CDetalles.Name = "CDetalles";
            this.CDetalles.ReadOnly = true;
            // 
            // CCosto
            // 
            this.CCosto.DataPropertyName = "Costo";
            this.CCosto.HeaderText = "Costo";
            this.CCosto.Name = "CCosto";
            this.CCosto.ReadOnly = true;
            // 
            // CFechaRegistro
            // 
            this.CFechaRegistro.DataPropertyName = "FechaRegistro";
            this.CFechaRegistro.HeaderText = "Registrado";
            this.CFechaRegistro.Name = "CFechaRegistro";
            this.CFechaRegistro.ReadOnly = true;
            this.CFechaRegistro.Width = 90;
            // 
            // CFechaMantenimiento
            // 
            this.CFechaMantenimiento.DataPropertyName = "FechaMantenimiento";
            this.CFechaMantenimiento.HeaderText = "Realizado";
            this.CFechaMantenimiento.Name = "CFechaMantenimiento";
            this.CFechaMantenimiento.ReadOnly = true;
            this.CFechaMantenimiento.Width = 90;
            // 
            // CFechaModificacion
            // 
            this.CFechaModificacion.DataPropertyName = "FechaModificacion";
            this.CFechaModificacion.HeaderText = "Modificado";
            this.CFechaModificacion.Name = "CFechaModificacion";
            this.CFechaModificacion.ReadOnly = true;
            this.CFechaModificacion.Width = 90;
            // 
            // CPlaca
            // 
            this.CPlaca.DataPropertyName = "Placa";
            this.CPlaca.HeaderText = "Placa";
            this.CPlaca.Name = "CPlaca";
            this.CPlaca.ReadOnly = true;
            // 
            // CKilometraje
            // 
            this.CKilometraje.DataPropertyName = "Kilometraje";
            this.CKilometraje.HeaderText = "Kilometraje";
            this.CKilometraje.Name = "CKilometraje";
            this.CKilometraje.ReadOnly = true;
            this.CKilometraje.Width = 90;
            // 
            // CNombre
            // 
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Compañia";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            this.CNombre.Width = 120;
            // 
            // CDescripcion
            // 
            this.CDescripcion.DataPropertyName = "Descripcion";
            this.CDescripcion.HeaderText = "Servicentro";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            this.CDescripcion.Width = 160;
            // 
            // CFullName
            // 
            this.CFullName.DataPropertyName = "FullName";
            this.CFullName.HeaderText = "Chofer";
            this.CFullName.Name = "CFullName";
            this.CFullName.ReadOnly = true;
            this.CFullName.Width = 150;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(503, 49);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(747, 24);
            this.txtFiltro.TabIndex = 117;
            this.txtFiltro.Text = "Buscar...";
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltro.Click += new System.EventHandler(this.txtFiltro_Click);
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1827, 30);
            this.panel1.TabIndex = 118;
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
            this.BtnClose.Location = new System.Drawing.Point(1796, -4);
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
            this.btnMini.Location = new System.Drawing.Point(1759, -4);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(31, 39);
            this.btnMini.TabIndex = 4;
            this.btnMini.UseVisualStyleBackColor = false;
            // 
            // cbTipoMantenimiento
            // 
            this.cbTipoMantenimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMantenimiento.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoMantenimiento.FormattingEnabled = true;
            this.cbTipoMantenimiento.Location = new System.Drawing.Point(1473, 579);
            this.cbTipoMantenimiento.Name = "cbTipoMantenimiento";
            this.cbTipoMantenimiento.Size = new System.Drawing.Size(213, 25);
            this.cbTipoMantenimiento.TabIndex = 120;
            this.cbTipoMantenimiento.SelectionChangeCommitted += new System.EventHandler(this.cbTipoMantenimiento_SelectionChangeCommitted);
            this.cbTipoMantenimiento.SelectedValueChanged += new System.EventHandler(this.cbTipoMantenimiento_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1502, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 119;
            this.label5.Text = "Tipo Mantenimiento";
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(308, 633);
            this.txtCosto.MaxLength = 200;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(256, 24);
            this.txtCosto.TabIndex = 130;
            this.txtCosto.Enter += new System.EventHandler(this.txtCosto_Enter);
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            this.txtCosto.Leave += new System.EventHandler(this.txtCosto_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 611);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 129;
            this.label6.Text = "Costo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 128;
            this.label4.Text = "Kilometraje Actual:";
            // 
            // lbKmNuevo
            // 
            this.lbKmNuevo.AutoSize = true;
            this.lbKmNuevo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKmNuevo.Location = new System.Drawing.Point(585, 559);
            this.lbKmNuevo.Name = "lbKmNuevo";
            this.lbKmNuevo.Size = new System.Drawing.Size(138, 19);
            this.lbKmNuevo.TabIndex = 127;
            this.lbKmNuevo.Text = "Kilometraje Nuevo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 559);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 126;
            this.label2.Text = "Num Factura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 125;
            this.label1.Text = "Codigo Mantenimiento:";
            // 
            // txtKilometrajeAntes
            // 
            this.txtKilometrajeAntes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilometrajeAntes.Location = new System.Drawing.Point(246, 45);
            this.txtKilometrajeAntes.Name = "txtKilometrajeAntes";
            this.txtKilometrajeAntes.ReadOnly = true;
            this.txtKilometrajeAntes.Size = new System.Drawing.Size(202, 24);
            this.txtKilometrajeAntes.TabIndex = 124;
            // 
            // txtKilometrajeNuevo
            // 
            this.txtKilometrajeNuevo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilometrajeNuevo.Location = new System.Drawing.Point(589, 581);
            this.txtKilometrajeNuevo.MaxLength = 200;
            this.txtKilometrajeNuevo.Name = "txtKilometrajeNuevo";
            this.txtKilometrajeNuevo.Size = new System.Drawing.Size(213, 24);
            this.txtKilometrajeNuevo.TabIndex = 123;
            this.txtKilometrajeNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKilometrajeNuevo_KeyPress);
            this.txtKilometrajeNuevo.Leave += new System.EventHandler(this.txtKilometrajeNuevo_Leave);
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsecutivo.Location = new System.Drawing.Point(40, 582);
            this.txtConsecutivo.MaxLength = 150;
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(249, 24);
            this.txtConsecutivo.TabIndex = 122;
            this.txtConsecutivo.Leave += new System.EventHandler(this.txtConsecutivo_Leave);
            // 
            // txtIDMantenimiento
            // 
            this.txtIDMantenimiento.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMantenimiento.Location = new System.Drawing.Point(40, 526);
            this.txtIDMantenimiento.Name = "txtIDMantenimiento";
            this.txtIDMantenimiento.ReadOnly = true;
            this.txtIDMantenimiento.Size = new System.Drawing.Size(112, 24);
            this.txtIDMantenimiento.TabIndex = 121;
            // 
            // cbPlace
            // 
            this.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlace.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlace.FormattingEnabled = true;
            this.cbPlace.Location = new System.Drawing.Point(308, 528);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(187, 25);
            this.cbPlace.TabIndex = 137;
            this.cbPlace.SelectionChangeCommitted += new System.EventHandler(this.cbPlace_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(304, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 19);
            this.label8.TabIndex = 138;
            this.label8.Text = "Tienda de Servicio:";
            // 
            // txtLitros
            // 
            this.txtLitros.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLitros.Location = new System.Drawing.Point(589, 633);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(213, 24);
            this.txtLitros.TabIndex = 139;
            this.txtLitros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLitros_KeyPress);
            this.txtLitros.Leave += new System.EventHandler(this.txtLitros_Leave);
            // 
            // lbLitros
            // 
            this.lbLitros.AutoSize = true;
            this.lbLitros.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLitros.Location = new System.Drawing.Point(585, 611);
            this.lbLitros.Name = "lbLitros";
            this.lbLitros.Size = new System.Drawing.Size(45, 19);
            this.lbLitros.TabIndex = 140;
            this.lbLitros.Text = "Litros:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(822, 530);
            this.txtDetalle.MaxLength = 350;
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(213, 127);
            this.txtDetalle.TabIndex = 141;
            this.txtDetalle.Leave += new System.EventHandler(this.txtDetalle_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(818, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 142;
            this.label10.Text = "Detalles:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 888);
            this.panel3.TabIndex = 143;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 908);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1817, 10);
            this.panel2.TabIndex = 144;
            // 
            // panelNavRight
            // 
            this.panelNavRight.BackColor = System.Drawing.Color.Teal;
            this.panelNavRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNavRight.Location = new System.Drawing.Point(1817, 30);
            this.panelNavRight.Name = "panelNavRight";
            this.panelNavRight.Size = new System.Drawing.Size(10, 878);
            this.panelNavRight.TabIndex = 145;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1039, 558);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 19);
            this.label11.TabIndex = 149;
            this.label11.Text = "Archivo 2";
            // 
            // txtArchivo2
            // 
            this.txtArchivo2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivo2.Location = new System.Drawing.Point(1043, 580);
            this.txtArchivo2.Name = "txtArchivo2";
            this.txtArchivo2.ReadOnly = true;
            this.txtArchivo2.Size = new System.Drawing.Size(112, 24);
            this.txtArchivo2.TabIndex = 148;
            this.txtArchivo2.TextChanged += new System.EventHandler(this.txtArchivo2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1039, 508);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 19);
            this.label12.TabIndex = 147;
            this.label12.Text = "Archivo 1:";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivo.Location = new System.Drawing.Point(1043, 530);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(112, 24);
            this.txtArchivo.TabIndex = 146;
            this.txtArchivo.TextChanged += new System.EventHandler(this.txtArchivo_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(1411, 504);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(323, 45);
            this.label13.TabIndex = 159;
            this.label13.Text = "Mantenimientos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.txtTipoVehiculo);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.txtIDCarro);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtKilometrajeAntes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLimpiarCarro);
            this.groupBox1.Controls.Add(this.btnBuscarCarro);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(379, 698);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 139);
            this.groupBox1.TabIndex = 161;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehiculo";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(242, 69);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(127, 19);
            this.label31.TabIndex = 165;
            this.label31.Text = "Tipo de Vehiculo:";
            // 
            // txtTipoVehiculo
            // 
            this.txtTipoVehiculo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoVehiculo.Location = new System.Drawing.Point(246, 91);
            this.txtTipoVehiculo.Name = "txtTipoVehiculo";
            this.txtTipoVehiculo.ReadOnly = true;
            this.txtTipoVehiculo.Size = new System.Drawing.Size(202, 24);
            this.txtTipoVehiculo.TabIndex = 164;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 19);
            this.label15.TabIndex = 163;
            this.label15.Text = "Codigo:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(15, 94);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.ReadOnly = true;
            this.txtPlaca.Size = new System.Drawing.Size(202, 24);
            this.txtPlaca.TabIndex = 162;
            // 
            // txtIDCarro
            // 
            this.txtIDCarro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCarro.Location = new System.Drawing.Point(15, 45);
            this.txtIDCarro.Name = "txtIDCarro";
            this.txtIDCarro.ReadOnly = true;
            this.txtIDCarro.Size = new System.Drawing.Size(112, 24);
            this.txtIDCarro.TabIndex = 162;
            this.txtIDCarro.TextChanged += new System.EventHandler(this.txtIDCarro_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 19);
            this.label14.TabIndex = 163;
            this.label14.Text = "Placa:";
            // 
            // btnLimpiarCarro
            // 
            this.btnLimpiarCarro.BackColor = System.Drawing.Color.Teal;
            this.btnLimpiarCarro.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCarro.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnLimpiarCarro.IconColor = System.Drawing.Color.White;
            this.btnLimpiarCarro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarCarro.IconSize = 20;
            this.btnLimpiarCarro.Location = new System.Drawing.Point(189, 45);
            this.btnLimpiarCarro.Name = "btnLimpiarCarro";
            this.btnLimpiarCarro.Size = new System.Drawing.Size(28, 24);
            this.btnLimpiarCarro.TabIndex = 132;
            this.btnLimpiarCarro.UseVisualStyleBackColor = false;
            this.btnLimpiarCarro.Click += new System.EventHandler(this.btnLimpiarCarro_Click);
            // 
            // btnBuscarCarro
            // 
            this.btnBuscarCarro.BackColor = System.Drawing.Color.Teal;
            this.btnBuscarCarro.FlatAppearance.BorderSize = 0;
            this.btnBuscarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCarro.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnBuscarCarro.IconColor = System.Drawing.Color.White;
            this.btnBuscarCarro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCarro.IconSize = 20;
            this.btnBuscarCarro.Location = new System.Drawing.Point(156, 45);
            this.btnBuscarCarro.Name = "btnBuscarCarro";
            this.btnBuscarCarro.Size = new System.Drawing.Size(28, 24);
            this.btnBuscarCarro.TabIndex = 150;
            this.btnBuscarCarro.UseVisualStyleBackColor = false;
            this.btnBuscarCarro.Click += new System.EventHandler(this.btnBuscarCarro_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtNombreChofer);
            this.groupBox2.Controls.Add(this.txtIDChofer);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnLimpiarChofer);
            this.groupBox2.Controls.Add(this.btnBuscarChofer);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 698);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 139);
            this.groupBox2.TabIndex = 162;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chofer";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 19);
            this.label16.TabIndex = 163;
            this.label16.Text = "Codigo:";
            // 
            // txtNombreChofer
            // 
            this.txtNombreChofer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreChofer.Location = new System.Drawing.Point(15, 94);
            this.txtNombreChofer.Name = "txtNombreChofer";
            this.txtNombreChofer.ReadOnly = true;
            this.txtNombreChofer.Size = new System.Drawing.Size(286, 24);
            this.txtNombreChofer.TabIndex = 162;
            // 
            // txtIDChofer
            // 
            this.txtIDChofer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDChofer.Location = new System.Drawing.Point(15, 45);
            this.txtIDChofer.Name = "txtIDChofer";
            this.txtIDChofer.ReadOnly = true;
            this.txtIDChofer.Size = new System.Drawing.Size(112, 24);
            this.txtIDChofer.TabIndex = 162;
            this.txtIDChofer.TextChanged += new System.EventHandler(this.txtIDChofer_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 19);
            this.label17.TabIndex = 163;
            this.label17.Text = "Nombre:";
            // 
            // btnLimpiarChofer
            // 
            this.btnLimpiarChofer.BackColor = System.Drawing.Color.Teal;
            this.btnLimpiarChofer.FlatAppearance.BorderSize = 0;
            this.btnLimpiarChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarChofer.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnLimpiarChofer.IconColor = System.Drawing.Color.White;
            this.btnLimpiarChofer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarChofer.IconSize = 20;
            this.btnLimpiarChofer.Location = new System.Drawing.Point(189, 45);
            this.btnLimpiarChofer.Name = "btnLimpiarChofer";
            this.btnLimpiarChofer.Size = new System.Drawing.Size(28, 24);
            this.btnLimpiarChofer.TabIndex = 132;
            this.btnLimpiarChofer.UseVisualStyleBackColor = false;
            this.btnLimpiarChofer.Click += new System.EventHandler(this.btnLimpiarChofer_Click);
            // 
            // btnBuscarChofer
            // 
            this.btnBuscarChofer.BackColor = System.Drawing.Color.Teal;
            this.btnBuscarChofer.FlatAppearance.BorderSize = 0;
            this.btnBuscarChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarChofer.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnBuscarChofer.IconColor = System.Drawing.Color.White;
            this.btnBuscarChofer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarChofer.IconSize = 20;
            this.btnBuscarChofer.Location = new System.Drawing.Point(156, 45);
            this.btnBuscarChofer.Name = "btnBuscarChofer";
            this.btnBuscarChofer.Size = new System.Drawing.Size(28, 24);
            this.btnBuscarChofer.TabIndex = 150;
            this.btnBuscarChofer.UseVisualStyleBackColor = false;
            this.btnBuscarChofer.Click += new System.EventHandler(this.btnBuscarChofer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 611);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 164;
            this.label7.Text = "Orden Compra:";
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdenCompra.Location = new System.Drawing.Point(40, 633);
            this.txtOrdenCompra.MaxLength = 150;
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.ReadOnly = true;
            this.txtOrdenCompra.Size = new System.Drawing.Size(170, 24);
            this.txtOrdenCompra.TabIndex = 163;
            this.txtOrdenCompra.TextChanged += new System.EventHandler(this.txtOrdenCompra_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(305, 559);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 19);
            this.label18.TabIndex = 166;
            this.label18.Text = "Compañia:";
            // 
            // cbCompany
            // 
            this.cbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompany.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(309, 581);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(187, 25);
            this.cbCompany.TabIndex = 165;
            this.cbCompany.SelectionChangeCommitted += new System.EventHandler(this.cbCompany_SelectionChangeCommitted);
            // 
            // lbKmRecorridos
            // 
            this.lbKmRecorridos.AutoSize = true;
            this.lbKmRecorridos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKmRecorridos.Location = new System.Drawing.Point(864, 721);
            this.lbKmRecorridos.Name = "lbKmRecorridos";
            this.lbKmRecorridos.Size = new System.Drawing.Size(156, 19);
            this.lbKmRecorridos.TabIndex = 168;
            this.lbKmRecorridos.Text = "Kilometros Recorridos:";
            // 
            // txtKilometrosRecorridos
            // 
            this.txtKilometrosRecorridos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilometrosRecorridos.Location = new System.Drawing.Point(868, 743);
            this.txtKilometrosRecorridos.Name = "txtKilometrosRecorridos";
            this.txtKilometrosRecorridos.ReadOnly = true;
            this.txtKilometrosRecorridos.Size = new System.Drawing.Size(202, 24);
            this.txtKilometrosRecorridos.TabIndex = 167;
            this.txtKilometrosRecorridos.TextChanged += new System.EventHandler(this.txtKilometrosRecorridos_TextChanged);
            // 
            // lbCostoLitro
            // 
            this.lbCostoLitro.AutoSize = true;
            this.lbCostoLitro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostoLitro.Location = new System.Drawing.Point(1079, 773);
            this.lbCostoLitro.Name = "lbCostoLitro";
            this.lbCostoLitro.Size = new System.Drawing.Size(110, 19);
            this.lbCostoLitro.TabIndex = 170;
            this.lbCostoLitro.Text = "Coste por Litro:";
            // 
            // txtCostoLitro
            // 
            this.txtCostoLitro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoLitro.Location = new System.Drawing.Point(1083, 795);
            this.txtCostoLitro.Name = "txtCostoLitro";
            this.txtCostoLitro.ReadOnly = true;
            this.txtCostoLitro.Size = new System.Drawing.Size(202, 24);
            this.txtCostoLitro.TabIndex = 169;
            this.txtCostoLitro.TextChanged += new System.EventHandler(this.txtCostoLitro_TextChanged);
            // 
            // lbCostoKm
            // 
            this.lbCostoKm.AutoSize = true;
            this.lbCostoKm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostoKm.Location = new System.Drawing.Point(864, 773);
            this.lbCostoKm.Name = "lbCostoKm";
            this.lbCostoKm.Size = new System.Drawing.Size(142, 19);
            this.lbCostoKm.TabIndex = 172;
            this.lbCostoKm.Text = "Costo por Kilometro";
            // 
            // txtCostoKm
            // 
            this.txtCostoKm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoKm.Location = new System.Drawing.Point(868, 795);
            this.txtCostoKm.Name = "txtCostoKm";
            this.txtCostoKm.ReadOnly = true;
            this.txtCostoKm.Size = new System.Drawing.Size(202, 24);
            this.txtCostoKm.TabIndex = 171;
            this.txtCostoKm.TextChanged += new System.EventHandler(this.txtCostoKm_TextChanged);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Teal;
            this.label22.Location = new System.Drawing.Point(28, 665);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1250, 3);
            this.label22.TabIndex = 174;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Teal;
            this.label23.Location = new System.Drawing.Point(28, 488);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(508, 3);
            this.label23.TabIndex = 175;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Teal;
            this.label24.Location = new System.Drawing.Point(1275, 491);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(3, 175);
            this.label24.TabIndex = 176;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Teal;
            this.label26.Location = new System.Drawing.Point(526, 488);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(752, 3);
            this.label26.TabIndex = 178;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.Teal;
            this.label27.Location = new System.Drawing.Point(28, 488);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(3, 180);
            this.label27.TabIndex = 179;
            // 
            // DpOilDate
            // 
            this.DpOilDate.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DpOilDate.CustomFormat = "MM/yyyy";
            this.DpOilDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DpOilDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DpOilDate.Location = new System.Drawing.Point(589, 634);
            this.DpOilDate.Name = "DpOilDate";
            this.DpOilDate.Size = new System.Drawing.Size(213, 23);
            this.DpOilDate.TabIndex = 181;
            this.DpOilDate.ValueChanged += new System.EventHandler(this.DpOilDate_ValueChanged);
            // 
            // lbCambioAceite
            // 
            this.lbCambioAceite.AutoSize = true;
            this.lbCambioAceite.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCambioAceite.Location = new System.Drawing.Point(585, 609);
            this.lbCambioAceite.Name = "lbCambioAceite";
            this.lbCambioAceite.Size = new System.Drawing.Size(226, 19);
            this.lbCambioAceite.TabIndex = 180;
            this.lbCambioAceite.Text = "Posible proximo cambio aceite:";
            // 
            // DateTimeRTV
            // 
            this.DateTimeRTV.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeRTV.CustomFormat = "MM/yyyy";
            this.DateTimeRTV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeRTV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeRTV.Location = new System.Drawing.Point(589, 634);
            this.DateTimeRTV.Name = "DateTimeRTV";
            this.DateTimeRTV.Size = new System.Drawing.Size(202, 23);
            this.DateTimeRTV.TabIndex = 183;
            this.DateTimeRTV.ValueChanged += new System.EventHandler(this.DateTimeRTV_ValueChanged);
            // 
            // lbProximoRTV
            // 
            this.lbProximoRTV.AutoSize = true;
            this.lbProximoRTV.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProximoRTV.Location = new System.Drawing.Point(585, 612);
            this.lbProximoRTV.Name = "lbProximoRTV";
            this.lbProximoRTV.Size = new System.Drawing.Size(93, 19);
            this.lbProximoRTV.TabIndex = 182;
            this.lbProximoRTV.Text = "Proximo RTV:";
            // 
            // lbProximoMarchamo
            // 
            this.lbProximoMarchamo.AutoSize = true;
            this.lbProximoMarchamo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProximoMarchamo.Location = new System.Drawing.Point(585, 609);
            this.lbProximoMarchamo.Name = "lbProximoMarchamo";
            this.lbProximoMarchamo.Size = new System.Drawing.Size(147, 19);
            this.lbProximoMarchamo.TabIndex = 185;
            this.lbProximoMarchamo.Text = "Proximo Marchamo:";
            // 
            // txtMarchamo
            // 
            this.txtMarchamo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarchamo.Location = new System.Drawing.Point(589, 633);
            this.txtMarchamo.MaxLength = 4;
            this.txtMarchamo.Name = "txtMarchamo";
            this.txtMarchamo.Size = new System.Drawing.Size(213, 24);
            this.txtMarchamo.TabIndex = 184;
            this.txtMarchamo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarchamo_KeyPress);
            this.txtMarchamo.Leave += new System.EventHandler(this.txtMarchamo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(585, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 186;
            this.label3.Text = "Fecha de la acción:";
            // 
            // DTFechaMantenimiento
            // 
            this.DTFechaMantenimiento.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaMantenimiento.CustomFormat = "dd/MM/yyyy";
            this.DTFechaMantenimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaMantenimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTFechaMantenimiento.Location = new System.Drawing.Point(589, 530);
            this.DTFechaMantenimiento.Name = "DTFechaMantenimiento";
            this.DTFechaMantenimiento.Size = new System.Drawing.Size(213, 23);
            this.DTFechaMantenimiento.TabIndex = 187;
            this.DTFechaMantenimiento.ValueChanged += new System.EventHandler(this.DTFechaMantenimiento_ValueChanged);
            // 
            // checkDesactivarOrden
            // 
            this.checkDesactivarOrden.AutoSize = true;
            this.checkDesactivarOrden.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDesactivarOrden.Location = new System.Drawing.Point(1457, 622);
            this.checkDesactivarOrden.Name = "checkDesactivarOrden";
            this.checkDesactivarOrden.Size = new System.Drawing.Size(229, 20);
            this.checkDesactivarOrden.TabIndex = 191;
            this.checkDesactivarOrden.Text = "MARCAR ORDEN COMO USADA";
            this.checkDesactivarOrden.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PracticaEmpresarial.Properties.Resources.exclamationOrden;
            this.pictureBox2.Location = new System.Drawing.Point(1681, 630);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 192;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // btnLimpiarOrden
            // 
            this.btnLimpiarOrden.BackColor = System.Drawing.Color.Teal;
            this.btnLimpiarOrden.FlatAppearance.BorderSize = 0;
            this.btnLimpiarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarOrden.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnLimpiarOrden.IconColor = System.Drawing.Color.White;
            this.btnLimpiarOrden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarOrden.IconSize = 20;
            this.btnLimpiarOrden.Location = new System.Drawing.Point(250, 632);
            this.btnLimpiarOrden.Name = "btnLimpiarOrden";
            this.btnLimpiarOrden.Size = new System.Drawing.Size(28, 24);
            this.btnLimpiarOrden.TabIndex = 190;
            this.btnLimpiarOrden.UseVisualStyleBackColor = false;
            this.btnLimpiarOrden.Click += new System.EventHandler(this.btnLimpiarOrden_Click);
            // 
            // btnBuscarOrden
            // 
            this.btnBuscarOrden.BackColor = System.Drawing.Color.Teal;
            this.btnBuscarOrden.FlatAppearance.BorderSize = 0;
            this.btnBuscarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarOrden.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnBuscarOrden.IconColor = System.Drawing.Color.White;
            this.btnBuscarOrden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarOrden.IconSize = 20;
            this.btnBuscarOrden.Location = new System.Drawing.Point(216, 632);
            this.btnBuscarOrden.Name = "btnBuscarOrden";
            this.btnBuscarOrden.Size = new System.Drawing.Size(28, 24);
            this.btnBuscarOrden.TabIndex = 189;
            this.btnBuscarOrden.UseVisualStyleBackColor = false;
            this.btnBuscarOrden.Click += new System.EventHandler(this.btnBuscarOrden_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExportar.IconColor = System.Drawing.Color.Black;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.Location = new System.Drawing.Point(1678, 478);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(112, 25);
            this.btnExportar.TabIndex = 188;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackColor = System.Drawing.Color.Teal;
            this.btnCalculator.FlatAppearance.BorderSize = 0;
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnCalculator.IconColor = System.Drawing.Color.White;
            this.btnCalculator.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalculator.IconSize = 20;
            this.btnCalculator.Location = new System.Drawing.Point(1076, 742);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(28, 24);
            this.btnCalculator.TabIndex = 173;
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PracticaEmpresarial.Properties.Resources.Paso1;
            this.pictureBox1.Location = new System.Drawing.Point(1419, 569);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 160;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Teal;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 25;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(1681, 706);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 46);
            this.btnLimpiar.TabIndex = 158;
            this.btnLimpiar.Text = "       Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Teal;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 20;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(1518, 706);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 46);
            this.btnEditar.TabIndex = 157;
            this.btnEditar.Text = "       Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Teal;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(1356, 706);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 46);
            this.btnAgregar.TabIndex = 156;
            this.btnAgregar.Text = "       Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVerArchivo2
            // 
            this.btnVerArchivo2.BackColor = System.Drawing.Color.Teal;
            this.btnVerArchivo2.FlatAppearance.BorderSize = 0;
            this.btnVerArchivo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerArchivo2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVerArchivo2.IconColor = System.Drawing.Color.White;
            this.btnVerArchivo2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerArchivo2.IconSize = 25;
            this.btnVerArchivo2.Location = new System.Drawing.Point(1241, 579);
            this.btnVerArchivo2.Name = "btnVerArchivo2";
            this.btnVerArchivo2.Size = new System.Drawing.Size(28, 24);
            this.btnVerArchivo2.TabIndex = 155;
            this.btnVerArchivo2.UseVisualStyleBackColor = false;
            this.btnVerArchivo2.Click += new System.EventHandler(this.btnVerArchivo2_Click);
            // 
            // btnVerArchivo
            // 
            this.btnVerArchivo.BackColor = System.Drawing.Color.Teal;
            this.btnVerArchivo.FlatAppearance.BorderSize = 0;
            this.btnVerArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerArchivo.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVerArchivo.IconColor = System.Drawing.Color.White;
            this.btnVerArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerArchivo.IconSize = 25;
            this.btnVerArchivo.Location = new System.Drawing.Point(1241, 529);
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Size = new System.Drawing.Size(28, 24);
            this.btnVerArchivo.TabIndex = 154;
            this.btnVerArchivo.UseVisualStyleBackColor = false;
            this.btnVerArchivo.Click += new System.EventHandler(this.btnVerArchivo_Click);
            // 
            // btnLimpiarArchivo2
            // 
            this.btnLimpiarArchivo2.BackColor = System.Drawing.Color.Teal;
            this.btnLimpiarArchivo2.FlatAppearance.BorderSize = 0;
            this.btnLimpiarArchivo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarArchivo2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnLimpiarArchivo2.IconColor = System.Drawing.Color.White;
            this.btnLimpiarArchivo2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarArchivo2.IconSize = 20;
            this.btnLimpiarArchivo2.Location = new System.Drawing.Point(1201, 579);
            this.btnLimpiarArchivo2.Name = "btnLimpiarArchivo2";
            this.btnLimpiarArchivo2.Size = new System.Drawing.Size(28, 24);
            this.btnLimpiarArchivo2.TabIndex = 153;
            this.btnLimpiarArchivo2.UseVisualStyleBackColor = false;
            this.btnLimpiarArchivo2.Click += new System.EventHandler(this.btnLimpiarArchivo2_Click);
            // 
            // btnLimpiarArchivo
            // 
            this.btnLimpiarArchivo.BackColor = System.Drawing.Color.Teal;
            this.btnLimpiarArchivo.FlatAppearance.BorderSize = 0;
            this.btnLimpiarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarArchivo.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnLimpiarArchivo.IconColor = System.Drawing.Color.White;
            this.btnLimpiarArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarArchivo.IconSize = 20;
            this.btnLimpiarArchivo.Location = new System.Drawing.Point(1201, 529);
            this.btnLimpiarArchivo.Name = "btnLimpiarArchivo";
            this.btnLimpiarArchivo.Size = new System.Drawing.Size(28, 24);
            this.btnLimpiarArchivo.TabIndex = 152;
            this.btnLimpiarArchivo.UseVisualStyleBackColor = false;
            this.btnLimpiarArchivo.Click += new System.EventHandler(this.btnLimpiarArchivo_Click);
            // 
            // btnSelectArchivo2
            // 
            this.btnSelectArchivo2.BackColor = System.Drawing.Color.Teal;
            this.btnSelectArchivo2.FlatAppearance.BorderSize = 0;
            this.btnSelectArchivo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectArchivo2.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnSelectArchivo2.IconColor = System.Drawing.Color.White;
            this.btnSelectArchivo2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectArchivo2.IconSize = 20;
            this.btnSelectArchivo2.Location = new System.Drawing.Point(1161, 579);
            this.btnSelectArchivo2.Name = "btnSelectArchivo2";
            this.btnSelectArchivo2.Size = new System.Drawing.Size(28, 24);
            this.btnSelectArchivo2.TabIndex = 151;
            this.btnSelectArchivo2.UseVisualStyleBackColor = false;
            this.btnSelectArchivo2.Click += new System.EventHandler(this.btnSelectArchivo2_Click);
            // 
            // btnSelectArchivo
            // 
            this.btnSelectArchivo.BackColor = System.Drawing.Color.Teal;
            this.btnSelectArchivo.FlatAppearance.BorderSize = 0;
            this.btnSelectArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectArchivo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnSelectArchivo.IconColor = System.Drawing.Color.White;
            this.btnSelectArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectArchivo.IconSize = 20;
            this.btnSelectArchivo.Location = new System.Drawing.Point(1161, 529);
            this.btnSelectArchivo.Name = "btnSelectArchivo";
            this.btnSelectArchivo.Size = new System.Drawing.Size(28, 24);
            this.btnSelectArchivo.TabIndex = 131;
            this.btnSelectArchivo.UseVisualStyleBackColor = false;
            this.btnSelectArchivo.Click += new System.EventHandler(this.btnSelectArchivo_Click);
            // 
            // FrmGestionMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 918);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkDesactivarOrden);
            this.Controls.Add(this.btnLimpiarOrden);
            this.Controls.Add(this.btnBuscarOrden);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.DTFechaMantenimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbProximoMarchamo);
            this.Controls.Add(this.txtMarchamo);
            this.Controls.Add(this.DateTimeRTV);
            this.Controls.Add(this.lbProximoRTV);
            this.Controls.Add(this.DpOilDate);
            this.Controls.Add(this.lbCambioAceite);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lbKmNuevo);
            this.Controls.Add(this.txtKilometrajeNuevo);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.lbCostoKm);
            this.Controls.Add(this.txtCostoKm);
            this.Controls.Add(this.lbCostoLitro);
            this.Controls.Add(this.txtCostoLitro);
            this.Controls.Add(this.lbKmRecorridos);
            this.Controls.Add(this.txtKilometrosRecorridos);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOrdenCompra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVerArchivo2);
            this.Controls.Add(this.btnVerArchivo);
            this.Controls.Add(this.btnLimpiarArchivo2);
            this.Controls.Add(this.btnLimpiarArchivo);
            this.Controls.Add(this.btnSelectArchivo2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtArchivo2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.panelNavRight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.lbLitros);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPlace);
            this.Controls.Add(this.btnSelectArchivo);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsecutivo);
            this.Controls.Add(this.txtIDMantenimiento);
            this.Controls.Add(this.cbTipoMantenimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.DgvListaM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionMantenimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Mantenimientos";
            this.Load += new System.EventHandler(this.FrmGestionMantenimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaM;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton btnMini;
        private System.Windows.Forms.ComboBox cbTipoMantenimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbKmNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKilometrajeAntes;
        private System.Windows.Forms.TextBox txtKilometrajeNuevo;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.TextBox txtIDMantenimiento;
        private FontAwesome.Sharp.IconButton btnSelectArchivo;
        private FontAwesome.Sharp.IconButton btnLimpiarCarro;
        private System.Windows.Forms.ComboBox cbPlace;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Label lbLitros;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelNavRight;
        private FontAwesome.Sharp.IconButton btnVerArchivo2;
        private FontAwesome.Sharp.IconButton btnVerArchivo;
        private FontAwesome.Sharp.IconButton btnLimpiarArchivo2;
        private FontAwesome.Sharp.IconButton btnLimpiarArchivo;
        private FontAwesome.Sharp.IconButton btnSelectArchivo2;
        private FontAwesome.Sharp.IconButton btnBuscarCarro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtArchivo2;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtArchivo;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIDCarro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNombreChofer;
        private System.Windows.Forms.TextBox txtIDChofer;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconButton btnLimpiarChofer;
        private FontAwesome.Sharp.IconButton btnBuscarChofer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrdenCompra;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.Label lbKmRecorridos;
        private System.Windows.Forms.TextBox txtKilometrosRecorridos;
        private System.Windows.Forms.Label lbCostoLitro;
        private System.Windows.Forms.TextBox txtCostoLitro;
        private System.Windows.Forms.Label lbCostoKm;
        private System.Windows.Forms.TextBox txtCostoKm;
        private FontAwesome.Sharp.IconButton btnCalculator;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker DpOilDate;
        private System.Windows.Forms.Label lbCambioAceite;
        private System.Windows.Forms.DateTimePicker DateTimeRTV;
        private System.Windows.Forms.Label lbProximoRTV;
        private System.Windows.Forms.Label lbProximoMarchamo;
        private System.Windows.Forms.TextBox txtMarchamo;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtTipoVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTFechaMantenimiento;
        private FontAwesome.Sharp.IconButton btnExportar;
        private FontAwesome.Sharp.IconButton btnBuscarOrden;
        private FontAwesome.Sharp.IconButton btnLimpiarOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDMantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CConsecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDOrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaMantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CKilometraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFullName;
        private System.Windows.Forms.CheckBox checkDesactivarOrden;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}