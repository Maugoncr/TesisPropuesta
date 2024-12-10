namespace PracticaEmpresarial.Forms
{
    partial class FrmOrdendeCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdendeCompra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.btnMini = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelNavRight = new System.Windows.Forms.Panel();
            this.txtIDOrdenCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListaM = new System.Windows.Forms.DataGridView();
            this.CIDOrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDetalleOrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaParaRealizar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaImpresion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaCreacionOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaUtilizada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIsGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIsMantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFullNameChofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoOrden = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDetalleOrdenCompra = new System.Windows.Forms.TextBox();
            this.DTFechaOrdenCompra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPlace = new System.Windows.Forms.ComboBox();
            this.LblPassRequerido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNombreChofer = new System.Windows.Forms.TextBox();
            this.txtIDChofer = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnLimpiarChofer = new FontAwesome.Sharp.IconButton();
            this.btnBuscarChofer = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtIDCarro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnLimpiarCarro = new FontAwesome.Sharp.IconButton();
            this.btnBuscarCarro = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnVerArchivo2 = new FontAwesome.Sharp.IconButton();
            this.btnVerArchivo = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarArchivo2 = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarArchivo = new FontAwesome.Sharp.IconButton();
            this.btnSelectArchivo2 = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtArchivo2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnSelectArchivo = new FontAwesome.Sharp.IconButton();
            this.checkIsGasto = new System.Windows.Forms.CheckBox();
            this.checkIsMantenimiento = new System.Windows.Forms.CheckBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.checkActivos = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnDesactivar = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaM)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1873, 30);
            this.panel1.TabIndex = 119;
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
            this.BtnClose.Location = new System.Drawing.Point(1830, -3);
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
            this.btnMini.Location = new System.Drawing.Point(1793, -3);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(31, 39);
            this.btnMini.TabIndex = 4;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(180)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 793);
            this.panel3.TabIndex = 144;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(180)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 813);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1863, 10);
            this.panel2.TabIndex = 145;
            // 
            // panelNavRight
            // 
            this.panelNavRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(180)))));
            this.panelNavRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNavRight.Location = new System.Drawing.Point(1863, 30);
            this.panelNavRight.Name = "panelNavRight";
            this.panelNavRight.Size = new System.Drawing.Size(10, 783);
            this.panelNavRight.TabIndex = 146;
            // 
            // txtIDOrdenCompra
            // 
            this.txtIDOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDOrdenCompra.Location = new System.Drawing.Point(321, 522);
            this.txtIDOrdenCompra.Name = "txtIDOrdenCompra";
            this.txtIDOrdenCompra.ReadOnly = true;
            this.txtIDOrdenCompra.Size = new System.Drawing.Size(154, 24);
            this.txtIDOrdenCompra.TabIndex = 147;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 148;
            this.label1.Text = "ID Orden de Compra:";
            // 
            // DgvListaM
            // 
            this.DgvListaM.AllowUserToAddRows = false;
            this.DgvListaM.AllowUserToDeleteRows = false;
            this.DgvListaM.AllowUserToResizeColumns = false;
            this.DgvListaM.AllowUserToResizeRows = false;
            this.DgvListaM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvListaM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.CIDOrdenCompra,
            this.CCodigo,
            this.CDetalleOrdenCompra,
            this.CCosto,
            this.CFechaParaRealizar,
            this.CFechaImpresion,
            this.CFechaCreacionOrden,
            this.CFechaUtilizada,
            this.CIsGasto,
            this.CIsMantenimiento,
            this.CFullName,
            this.CDescripcion,
            this.CNombre,
            this.CFullNameChofer,
            this.CPlaca});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaM.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaM.Location = new System.Drawing.Point(54, 85);
            this.DgvListaM.MultiSelect = false;
            this.DgvListaM.Name = "DgvListaM";
            this.DgvListaM.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaM.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListaM.RowHeadersVisible = false;
            this.DgvListaM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaM.Size = new System.Drawing.Size(1767, 385);
            this.DgvListaM.TabIndex = 149;
            this.DgvListaM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaM_CellClick);
            // 
            // CIDOrdenCompra
            // 
            this.CIDOrdenCompra.DataPropertyName = "IDOrdenCompra";
            this.CIDOrdenCompra.HeaderText = "ID Orden";
            this.CIDOrdenCompra.Name = "CIDOrdenCompra";
            this.CIDOrdenCompra.ReadOnly = true;
            this.CIDOrdenCompra.Width = 83;
            // 
            // CCodigo
            // 
            this.CCodigo.DataPropertyName = "Codigo";
            this.CCodigo.HeaderText = "Codigo";
            this.CCodigo.Name = "CCodigo";
            this.CCodigo.ReadOnly = true;
            this.CCodigo.Width = 83;
            // 
            // CDetalleOrdenCompra
            // 
            this.CDetalleOrdenCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDetalleOrdenCompra.DataPropertyName = "DetalleOrdenCompra";
            this.CDetalleOrdenCompra.HeaderText = "Detalle";
            this.CDetalleOrdenCompra.Name = "CDetalleOrdenCompra";
            this.CDetalleOrdenCompra.ReadOnly = true;
            // 
            // CCosto
            // 
            this.CCosto.DataPropertyName = "Costo";
            this.CCosto.HeaderText = "Costo Aprox";
            this.CCosto.Name = "CCosto";
            this.CCosto.ReadOnly = true;
            this.CCosto.Width = 104;
            // 
            // CFechaParaRealizar
            // 
            this.CFechaParaRealizar.DataPropertyName = "FechaParaRealizar";
            this.CFechaParaRealizar.HeaderText = "Realizar el:";
            this.CFechaParaRealizar.Name = "CFechaParaRealizar";
            this.CFechaParaRealizar.ReadOnly = true;
            this.CFechaParaRealizar.Width = 94;
            // 
            // CFechaImpresion
            // 
            this.CFechaImpresion.DataPropertyName = "FechaImpresion";
            this.CFechaImpresion.HeaderText = "Impresa el:";
            this.CFechaImpresion.Name = "CFechaImpresion";
            this.CFechaImpresion.ReadOnly = true;
            this.CFechaImpresion.Width = 95;
            // 
            // CFechaCreacionOrden
            // 
            this.CFechaCreacionOrden.DataPropertyName = "FechaCreacionOrden";
            this.CFechaCreacionOrden.HeaderText = "Creada el:";
            this.CFechaCreacionOrden.Name = "CFechaCreacionOrden";
            this.CFechaCreacionOrden.ReadOnly = true;
            this.CFechaCreacionOrden.Width = 94;
            // 
            // CFechaUtilizada
            // 
            this.CFechaUtilizada.DataPropertyName = "FechaUtilizada";
            this.CFechaUtilizada.HeaderText = "Usada el:";
            this.CFechaUtilizada.Name = "CFechaUtilizada";
            this.CFechaUtilizada.ReadOnly = true;
            this.CFechaUtilizada.Width = 85;
            // 
            // CIsGasto
            // 
            this.CIsGasto.DataPropertyName = "IsGasto";
            this.CIsGasto.HeaderText = "Es gasto:";
            this.CIsGasto.Name = "CIsGasto";
            this.CIsGasto.ReadOnly = true;
            this.CIsGasto.Width = 83;
            // 
            // CIsMantenimiento
            // 
            this.CIsMantenimiento.DataPropertyName = "IsMantenimiento";
            this.CIsMantenimiento.HeaderText = "Es para Mantenimiento:";
            this.CIsMantenimiento.Name = "CIsMantenimiento";
            this.CIsMantenimiento.ReadOnly = true;
            this.CIsMantenimiento.Width = 169;
            // 
            // CFullName
            // 
            this.CFullName.DataPropertyName = "FullName";
            this.CFullName.HeaderText = "Autorizador";
            this.CFullName.Name = "CFullName";
            this.CFullName.ReadOnly = true;
            this.CFullName.Width = 108;
            // 
            // CDescripcion
            // 
            this.CDescripcion.DataPropertyName = "Descripcion";
            this.CDescripcion.HeaderText = "Tienda Servicio";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            this.CDescripcion.Width = 117;
            // 
            // CNombre
            // 
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Compañia";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            this.CNombre.Width = 104;
            // 
            // CFullNameChofer
            // 
            this.CFullNameChofer.DataPropertyName = "FullNameChofer";
            this.CFullNameChofer.HeaderText = "Chofer";
            this.CFullNameChofer.Name = "CFullNameChofer";
            this.CFullNameChofer.ReadOnly = true;
            this.CFullNameChofer.Width = 77;
            // 
            // CPlaca
            // 
            this.CPlaca.DataPropertyName = "Placa";
            this.CPlaca.HeaderText = "Placa";
            this.CPlaca.Name = "CPlaca";
            this.CPlaca.ReadOnly = true;
            this.CPlaca.Width = 70;
            // 
            // txtCodigoOrden
            // 
            this.txtCodigoOrden.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoOrden.Location = new System.Drawing.Point(321, 572);
            this.txtCodigoOrden.MaxLength = 100;
            this.txtCodigoOrden.Name = "txtCodigoOrden";
            this.txtCodigoOrden.Size = new System.Drawing.Size(249, 24);
            this.txtCodigoOrden.TabIndex = 150;
            this.txtCodigoOrden.Leave += new System.EventHandler(this.txtCodigoOrden_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 19);
            this.label2.TabIndex = 151;
            this.label2.Text = "Código Orden de Compra:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 600);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 166;
            this.label7.Text = "Detalle:";
            // 
            // txtDetalleOrdenCompra
            // 
            this.txtDetalleOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleOrdenCompra.Location = new System.Drawing.Point(321, 622);
            this.txtDetalleOrdenCompra.MaxLength = 96;
            this.txtDetalleOrdenCompra.Multiline = true;
            this.txtDetalleOrdenCompra.Name = "txtDetalleOrdenCompra";
            this.txtDetalleOrdenCompra.Size = new System.Drawing.Size(249, 150);
            this.txtDetalleOrdenCompra.TabIndex = 165;
            this.txtDetalleOrdenCompra.Leave += new System.EventHandler(this.txtDetalleOrdenCompra_Leave);
            // 
            // DTFechaOrdenCompra
            // 
            this.DTFechaOrdenCompra.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaOrdenCompra.CustomFormat = "dd/MM/yyyy";
            this.DTFechaOrdenCompra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechaOrdenCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTFechaOrdenCompra.Location = new System.Drawing.Point(967, 688);
            this.DTFechaOrdenCompra.Name = "DTFechaOrdenCompra";
            this.DTFechaOrdenCompra.Size = new System.Drawing.Size(187, 23);
            this.DTFechaOrdenCompra.TabIndex = 189;
            this.DTFechaOrdenCompra.ValueChanged += new System.EventHandler(this.DTFechaOrdenCompra_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(925, 663);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 19);
            this.label3.TabIndex = 188;
            this.label3.Text = "Fecha asignada para ejecutar la Orden:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1013, 550);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 19);
            this.label18.TabIndex = 191;
            this.label18.Text = "Compañia:";
            // 
            // cbCompany
            // 
            this.cbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompany.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(967, 572);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(187, 25);
            this.cbCompany.TabIndex = 190;
            this.cbCompany.SelectionChangeCommitted += new System.EventHandler(this.cbCompany_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(992, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 19);
            this.label8.TabIndex = 193;
            this.label8.Text = "Tienda de Servicio:";
            // 
            // cbPlace
            // 
            this.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlace.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlace.FormattingEnabled = true;
            this.cbPlace.Location = new System.Drawing.Point(967, 522);
            this.cbPlace.Name = "cbPlace";
            this.cbPlace.Size = new System.Drawing.Size(187, 25);
            this.cbPlace.TabIndex = 192;
            this.cbPlace.SelectionChangeCommitted += new System.EventHandler(this.cbPlace_SelectionChangeCommitted);
            // 
            // LblPassRequerido
            // 
            this.LblPassRequerido.BackColor = System.Drawing.Color.Transparent;
            this.LblPassRequerido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassRequerido.ForeColor = System.Drawing.Color.Red;
            this.LblPassRequerido.Location = new System.Drawing.Point(978, 500);
            this.LblPassRequerido.Name = "LblPassRequerido";
            this.LblPassRequerido.Size = new System.Drawing.Size(12, 19);
            this.LblPassRequerido.TabIndex = 198;
            this.LblPassRequerido.Text = "*";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(999, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 19);
            this.label6.TabIndex = 199;
            this.label6.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(985, 600);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 19);
            this.label9.TabIndex = 201;
            this.label9.Text = "Usuario autorizador:";
            // 
            // cbUser
            // 
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(967, 626);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(187, 25);
            this.cbUser.TabIndex = 200;
            this.cbUser.SelectionChangeCommitted += new System.EventHandler(this.cbUser_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(971, 600);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 19);
            this.label10.TabIndex = 202;
            this.label10.Text = "*";
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
            this.groupBox2.Location = new System.Drawing.Point(594, 632);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 139);
            this.groupBox2.TabIndex = 203;
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
            this.btnLimpiarChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
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
            this.btnBuscarChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtPlaca);
            this.groupBox1.Controls.Add(this.txtIDCarro);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnLimpiarCarro);
            this.groupBox1.Controls.Add(this.btnBuscarCarro);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(594, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 139);
            this.groupBox1.TabIndex = 204;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehiculo";
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
            this.txtPlaca.Size = new System.Drawing.Size(286, 24);
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
            this.btnLimpiarCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
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
            this.btnBuscarCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(989, 719);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 206;
            this.label4.Text = "Costo aproximado:";
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(938, 747);
            this.txtCosto.MaxLength = 50;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(249, 24);
            this.txtCosto.TabIndex = 205;
            this.txtCosto.Enter += new System.EventHandler(this.txtCosto_Enter);
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            this.txtCosto.Leave += new System.EventHandler(this.txtCosto_Leave);
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
            this.btnVerArchivo2.Location = new System.Drawing.Point(1472, 571);
            this.btnVerArchivo2.Name = "btnVerArchivo2";
            this.btnVerArchivo2.Size = new System.Drawing.Size(28, 24);
            this.btnVerArchivo2.TabIndex = 216;
            this.btnVerArchivo2.UseVisualStyleBackColor = false;
            this.btnVerArchivo2.Click += new System.EventHandler(this.btnVerArchivo2_Click);
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
            this.btnVerArchivo.Location = new System.Drawing.Point(1472, 521);
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Size = new System.Drawing.Size(28, 24);
            this.btnVerArchivo.TabIndex = 215;
            this.btnVerArchivo.UseVisualStyleBackColor = false;
            this.btnVerArchivo.Click += new System.EventHandler(this.btnVerArchivo_Click);
            // 
            // btnLimpiarArchivo2
            // 
            this.btnLimpiarArchivo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnLimpiarArchivo2.FlatAppearance.BorderSize = 0;
            this.btnLimpiarArchivo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarArchivo2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnLimpiarArchivo2.IconColor = System.Drawing.Color.White;
            this.btnLimpiarArchivo2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarArchivo2.IconSize = 20;
            this.btnLimpiarArchivo2.Location = new System.Drawing.Point(1432, 571);
            this.btnLimpiarArchivo2.Name = "btnLimpiarArchivo2";
            this.btnLimpiarArchivo2.Size = new System.Drawing.Size(28, 24);
            this.btnLimpiarArchivo2.TabIndex = 214;
            this.btnLimpiarArchivo2.UseVisualStyleBackColor = false;
            this.btnLimpiarArchivo2.Click += new System.EventHandler(this.btnLimpiarArchivo2_Click);
            // 
            // btnLimpiarArchivo
            // 
            this.btnLimpiarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnLimpiarArchivo.FlatAppearance.BorderSize = 0;
            this.btnLimpiarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarArchivo.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnLimpiarArchivo.IconColor = System.Drawing.Color.White;
            this.btnLimpiarArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarArchivo.IconSize = 20;
            this.btnLimpiarArchivo.Location = new System.Drawing.Point(1432, 521);
            this.btnLimpiarArchivo.Name = "btnLimpiarArchivo";
            this.btnLimpiarArchivo.Size = new System.Drawing.Size(28, 24);
            this.btnLimpiarArchivo.TabIndex = 213;
            this.btnLimpiarArchivo.UseVisualStyleBackColor = false;
            this.btnLimpiarArchivo.Click += new System.EventHandler(this.btnLimpiarArchivo_Click);
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
            this.btnSelectArchivo2.Location = new System.Drawing.Point(1392, 571);
            this.btnSelectArchivo2.Name = "btnSelectArchivo2";
            this.btnSelectArchivo2.Size = new System.Drawing.Size(28, 24);
            this.btnSelectArchivo2.TabIndex = 212;
            this.btnSelectArchivo2.UseVisualStyleBackColor = false;
            this.btnSelectArchivo2.Click += new System.EventHandler(this.btnSelectArchivo2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1270, 550);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 19);
            this.label11.TabIndex = 211;
            this.label11.Text = "Archivo 2";
            // 
            // txtArchivo2
            // 
            this.txtArchivo2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivo2.Location = new System.Drawing.Point(1274, 572);
            this.txtArchivo2.Name = "txtArchivo2";
            this.txtArchivo2.ReadOnly = true;
            this.txtArchivo2.Size = new System.Drawing.Size(112, 24);
            this.txtArchivo2.TabIndex = 210;
            this.txtArchivo2.TextChanged += new System.EventHandler(this.txtArchivo2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1270, 500);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 19);
            this.label12.TabIndex = 209;
            this.label12.Text = "Archivo 1:";
            // 
            // txtArchivo
            // 
            this.txtArchivo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivo.Location = new System.Drawing.Point(1274, 522);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(112, 24);
            this.txtArchivo.TabIndex = 208;
            this.txtArchivo.TextChanged += new System.EventHandler(this.txtArchivo_TextChanged);
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
            this.btnSelectArchivo.Location = new System.Drawing.Point(1392, 521);
            this.btnSelectArchivo.Name = "btnSelectArchivo";
            this.btnSelectArchivo.Size = new System.Drawing.Size(28, 24);
            this.btnSelectArchivo.TabIndex = 207;
            this.btnSelectArchivo.UseVisualStyleBackColor = false;
            this.btnSelectArchivo.Click += new System.EventHandler(this.btnSelectArchivo_Click);
            // 
            // checkIsGasto
            // 
            this.checkIsGasto.AutoSize = true;
            this.checkIsGasto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIsGasto.Location = new System.Drawing.Point(1278, 623);
            this.checkIsGasto.Name = "checkIsGasto";
            this.checkIsGasto.Size = new System.Drawing.Size(146, 23);
            this.checkIsGasto.TabIndex = 217;
            this.checkIsGasto.Text = "Es para un Gasto";
            this.checkIsGasto.UseVisualStyleBackColor = true;
            this.checkIsGasto.CheckedChanged += new System.EventHandler(this.checkIsGasto_CheckedChanged);
            // 
            // checkIsMantenimiento
            // 
            this.checkIsMantenimiento.AutoSize = true;
            this.checkIsMantenimiento.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIsMantenimiento.Location = new System.Drawing.Point(1278, 655);
            this.checkIsMantenimiento.Name = "checkIsMantenimiento";
            this.checkIsMantenimiento.Size = new System.Drawing.Size(211, 23);
            this.checkIsMantenimiento.TabIndex = 218;
            this.checkIsMantenimiento.Text = "Es para un mantenimiento";
            this.checkIsMantenimiento.UseVisualStyleBackColor = true;
            this.checkIsMantenimiento.CheckedChanged += new System.EventHandler(this.checkIsMantenimiento_CheckedChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(521, 45);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(747, 24);
            this.txtFiltro.TabIndex = 219;
            this.txtFiltro.Text = "Buscar...";
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltro.Click += new System.EventHandler(this.txtFiltro_Click);
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // checkActivos
            // 
            this.checkActivos.AutoSize = true;
            this.checkActivos.Checked = true;
            this.checkActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkActivos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkActivos.Location = new System.Drawing.Point(1290, 46);
            this.checkActivos.Name = "checkActivos";
            this.checkActivos.Size = new System.Drawing.Size(165, 23);
            this.checkActivos.TabIndex = 220;
            this.checkActivos.Text = "Ver Ordenes sin usar";
            this.checkActivos.UseVisualStyleBackColor = true;
            this.checkActivos.Click += new System.EventHandler(this.checkActivos_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(1649, 648);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 27);
            this.btnLimpiar.TabIndex = 223;
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
            this.btnEditar.Location = new System.Drawing.Point(1649, 571);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 27);
            this.btnEditar.TabIndex = 222;
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
            this.btnAgregar.Location = new System.Drawing.Point(1649, 533);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 27);
            this.btnAgregar.TabIndex = 221;
            this.btnAgregar.Text = "       Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnDesactivar.FlatAppearance.BorderSize = 0;
            this.btnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivar.ForeColor = System.Drawing.Color.White;
            this.btnDesactivar.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.btnDesactivar.IconColor = System.Drawing.Color.White;
            this.btnDesactivar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDesactivar.IconSize = 25;
            this.btnDesactivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesactivar.Location = new System.Drawing.Point(1649, 609);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(117, 27);
            this.btnDesactivar.TabIndex = 224;
            this.btnDesactivar.Text = "       Desactivar";
            this.btnDesactivar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesactivar.UseVisualStyleBackColor = false;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.label13.Location = new System.Drawing.Point(1317, 719);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(407, 45);
            this.label13.TabIndex = 225;
            this.label13.Text = "Ordenes de Compra";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir.IconColor = System.Drawing.Color.White;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 25;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(108, 581);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(117, 27);
            this.btnImprimir.TabIndex = 228;
            this.btnImprimir.Text = "        Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.btnExportar.IconColor = System.Drawing.Color.White;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.IconSize = 25;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(108, 522);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(117, 27);
            this.btnExportar.TabIndex = 229;
            this.btnExportar.Text = "        Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // FrmOrdendeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1873, 823);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.checkActivos);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.checkIsMantenimiento);
            this.Controls.Add(this.checkIsGasto);
            this.Controls.Add(this.btnVerArchivo2);
            this.Controls.Add(this.btnVerArchivo);
            this.Controls.Add(this.btnLimpiarArchivo2);
            this.Controls.Add(this.btnLimpiarArchivo);
            this.Controls.Add(this.btnSelectArchivo2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtArchivo2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.btnSelectArchivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblPassRequerido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPlace);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.DTFechaOrdenCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDetalleOrdenCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoOrden);
            this.Controls.Add(this.DgvListaM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDOrdenCompra);
            this.Controls.Add(this.panelNavRight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrdendeCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de Compra";
            this.Load += new System.EventHandler(this.FrmOrdendeCompra_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaM)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton btnMini;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelNavRight;
        private System.Windows.Forms.TextBox txtIDOrdenCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvListaM;
        private System.Windows.Forms.TextBox txtCodigoOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDetalleOrdenCompra;
        private System.Windows.Forms.DateTimePicker DTFechaOrdenCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPlace;
        private System.Windows.Forms.Label LblPassRequerido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNombreChofer;
        private System.Windows.Forms.TextBox txtIDChofer;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconButton btnLimpiarChofer;
        private FontAwesome.Sharp.IconButton btnBuscarChofer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtIDCarro;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton btnLimpiarCarro;
        private FontAwesome.Sharp.IconButton btnBuscarCarro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCosto;
        private FontAwesome.Sharp.IconButton btnVerArchivo2;
        private FontAwesome.Sharp.IconButton btnVerArchivo;
        private FontAwesome.Sharp.IconButton btnLimpiarArchivo2;
        private FontAwesome.Sharp.IconButton btnLimpiarArchivo;
        private FontAwesome.Sharp.IconButton btnSelectArchivo2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtArchivo2;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtArchivo;
        private FontAwesome.Sharp.IconButton btnSelectArchivo;
        private System.Windows.Forms.CheckBox checkIsGasto;
        private System.Windows.Forms.CheckBox checkIsMantenimiento;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.CheckBox checkActivos;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnDesactivar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDOrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDetalleOrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaParaRealizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaImpresion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaCreacionOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaUtilizada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIsGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIsMantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFullNameChofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPlaca;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private FontAwesome.Sharp.IconButton btnExportar;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}