namespace PracticaEmpresarial.Forms
{
    partial class FrmUsersRols
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsersRols));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.btnMini = new FontAwesome.Sharp.IconButton();
            this.DgvListaRolesUsuario = new System.Windows.Forms.DataGridView();
            this.CIDUserRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkAgregar = new System.Windows.Forms.CheckBox();
            this.checkEditar = new System.Windows.Forms.CheckBox();
            this.checkConsultar = new System.Windows.Forms.CheckBox();
            this.checkEliminar = new System.Windows.Forms.CheckBox();
            this.checkIsAdmin = new System.Windows.Forms.CheckBox();
            this.checkReport = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDUserRol = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panelNavRight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.checkChofer = new System.Windows.Forms.CheckBox();
            this.checkVehiculo = new System.Windows.Forms.CheckBox();
            this.checkMantenimientos = new System.Windows.Forms.CheckBox();
            this.checkGastos = new System.Windows.Forms.CheckBox();
            this.btnInfo = new FontAwesome.Sharp.IconButton();
            this.checkAutorizador = new System.Windows.Forms.CheckBox();
            this.checkOrdenes = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaRolesUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 41);
            this.panel1.TabIndex = 0;
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
            this.BtnClose.Location = new System.Drawing.Point(581, 3);
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
            this.btnMini.Location = new System.Drawing.Point(544, 3);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(31, 39);
            this.btnMini.TabIndex = 4;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // DgvListaRolesUsuario
            // 
            this.DgvListaRolesUsuario.AllowUserToAddRows = false;
            this.DgvListaRolesUsuario.AllowUserToDeleteRows = false;
            this.DgvListaRolesUsuario.AllowUserToResizeColumns = false;
            this.DgvListaRolesUsuario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaRolesUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListaRolesUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaRolesUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDUserRol,
            this.CDescripcion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaRolesUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaRolesUsuario.Location = new System.Drawing.Point(37, 104);
            this.DgvListaRolesUsuario.MultiSelect = false;
            this.DgvListaRolesUsuario.Name = "DgvListaRolesUsuario";
            this.DgvListaRolesUsuario.ReadOnly = true;
            this.DgvListaRolesUsuario.RowHeadersVisible = false;
            this.DgvListaRolesUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaRolesUsuario.Size = new System.Drawing.Size(538, 172);
            this.DgvListaRolesUsuario.TabIndex = 1;
            this.DgvListaRolesUsuario.VirtualMode = true;
            this.DgvListaRolesUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaRolesUsuario_CellClick);
            // 
            // CIDUserRol
            // 
            this.CIDUserRol.DataPropertyName = "IDUserRol";
            this.CIDUserRol.HeaderText = "Codigo";
            this.CIDUserRol.Name = "CIDUserRol";
            this.CIDUserRol.ReadOnly = true;
            // 
            // CDescripcion
            // 
            this.CDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDescripcion.DataPropertyName = "Descripcion";
            this.CDescripcion.HeaderText = "Descripcion";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            // 
            // checkAgregar
            // 
            this.checkAgregar.AutoSize = true;
            this.checkAgregar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAgregar.Location = new System.Drawing.Point(432, 289);
            this.checkAgregar.Name = "checkAgregar";
            this.checkAgregar.Size = new System.Drawing.Size(82, 23);
            this.checkAgregar.TabIndex = 2;
            this.checkAgregar.Text = "Agregar";
            this.checkAgregar.UseVisualStyleBackColor = true;
            this.checkAgregar.CheckedChanged += new System.EventHandler(this.checkAgregar_CheckedChanged);
            // 
            // checkEditar
            // 
            this.checkEditar.AutoSize = true;
            this.checkEditar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEditar.Location = new System.Drawing.Point(432, 313);
            this.checkEditar.Name = "checkEditar";
            this.checkEditar.Size = new System.Drawing.Size(68, 23);
            this.checkEditar.TabIndex = 3;
            this.checkEditar.Text = "Editar";
            this.checkEditar.UseVisualStyleBackColor = true;
            this.checkEditar.CheckedChanged += new System.EventHandler(this.checkEditar_CheckedChanged);
            // 
            // checkConsultar
            // 
            this.checkConsultar.AutoSize = true;
            this.checkConsultar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkConsultar.Location = new System.Drawing.Point(432, 360);
            this.checkConsultar.Name = "checkConsultar";
            this.checkConsultar.Size = new System.Drawing.Size(93, 23);
            this.checkConsultar.TabIndex = 5;
            this.checkConsultar.Text = "Consultar";
            this.checkConsultar.UseVisualStyleBackColor = true;
            this.checkConsultar.CheckedChanged += new System.EventHandler(this.checkConsultar_CheckedChanged);
            // 
            // checkEliminar
            // 
            this.checkEliminar.AutoSize = true;
            this.checkEliminar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEliminar.Location = new System.Drawing.Point(432, 336);
            this.checkEliminar.Name = "checkEliminar";
            this.checkEliminar.Size = new System.Drawing.Size(81, 23);
            this.checkEliminar.TabIndex = 4;
            this.checkEliminar.Text = "Eliminar";
            this.checkEliminar.UseVisualStyleBackColor = true;
            this.checkEliminar.CheckedChanged += new System.EventHandler(this.checkEliminar_CheckedChanged);
            // 
            // checkIsAdmin
            // 
            this.checkIsAdmin.AutoSize = true;
            this.checkIsAdmin.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIsAdmin.Location = new System.Drawing.Point(432, 585);
            this.checkIsAdmin.Name = "checkIsAdmin";
            this.checkIsAdmin.Size = new System.Drawing.Size(122, 23);
            this.checkIsAdmin.TabIndex = 7;
            this.checkIsAdmin.Text = "Administrador";
            this.checkIsAdmin.UseVisualStyleBackColor = true;
            this.checkIsAdmin.CheckedChanged += new System.EventHandler(this.checkIsAdmin_CheckedChanged);
            // 
            // checkReport
            // 
            this.checkReport.AutoSize = true;
            this.checkReport.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkReport.Location = new System.Drawing.Point(432, 383);
            this.checkReport.Name = "checkReport";
            this.checkReport.Size = new System.Drawing.Size(88, 23);
            this.checkReport.TabIndex = 6;
            this.checkReport.Text = "Reportes";
            this.checkReport.UseVisualStyleBackColor = true;
            this.checkReport.CheckedChanged += new System.EventHandler(this.checkReport_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo Rol de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripcion";
            // 
            // txtIDUserRol
            // 
            this.txtIDUserRol.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDUserRol.Location = new System.Drawing.Point(73, 347);
            this.txtIDUserRol.Name = "txtIDUserRol";
            this.txtIDUserRol.ReadOnly = true;
            this.txtIDUserRol.Size = new System.Drawing.Size(274, 24);
            this.txtIDUserRol.TabIndex = 14;
            this.txtIDUserRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(73, 412);
            this.txtDescripcion.MaxLength = 150;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(274, 24);
            this.txtDescripcion.TabIndex = 15;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // panelNavRight
            // 
            this.panelNavRight.BackColor = System.Drawing.Color.Teal;
            this.panelNavRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNavRight.Location = new System.Drawing.Point(607, 41);
            this.panelNavRight.Name = "panelNavRight";
            this.panelNavRight.Size = new System.Drawing.Size(10, 583);
            this.panelNavRight.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 614);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 10);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 573);
            this.panel3.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(194, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 33);
            this.label7.TabIndex = 45;
            this.label7.Text = "ROLES DE USUARIO";
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
            this.btnLimpiar.Location = new System.Drawing.Point(151, 534);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 29);
            this.btnLimpiar.TabIndex = 73;
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
            this.btnEditar.Location = new System.Drawing.Point(234, 476);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 29);
            this.btnEditar.TabIndex = 71;
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
            this.btnAgregar.Location = new System.Drawing.Point(65, 476);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 29);
            this.btnAgregar.TabIndex = 70;
            this.btnAgregar.Text = "       Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // checkChofer
            // 
            this.checkChofer.AutoSize = true;
            this.checkChofer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkChofer.Location = new System.Drawing.Point(432, 412);
            this.checkChofer.Name = "checkChofer";
            this.checkChofer.Size = new System.Drawing.Size(88, 23);
            this.checkChofer.TabIndex = 74;
            this.checkChofer.Text = "Choferes";
            this.checkChofer.UseVisualStyleBackColor = true;
            this.checkChofer.CheckedChanged += new System.EventHandler(this.checkChofer_CheckedChanged);
            // 
            // checkVehiculo
            // 
            this.checkVehiculo.AutoSize = true;
            this.checkVehiculo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkVehiculo.Location = new System.Drawing.Point(432, 441);
            this.checkVehiculo.Name = "checkVehiculo";
            this.checkVehiculo.Size = new System.Drawing.Size(93, 23);
            this.checkVehiculo.TabIndex = 75;
            this.checkVehiculo.Text = "Vehiculos";
            this.checkVehiculo.UseVisualStyleBackColor = true;
            this.checkVehiculo.CheckedChanged += new System.EventHandler(this.checkVehiculo_CheckedChanged);
            // 
            // checkMantenimientos
            // 
            this.checkMantenimientos.AutoSize = true;
            this.checkMantenimientos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMantenimientos.Location = new System.Drawing.Point(432, 470);
            this.checkMantenimientos.Name = "checkMantenimientos";
            this.checkMantenimientos.Size = new System.Drawing.Size(139, 23);
            this.checkMantenimientos.TabIndex = 76;
            this.checkMantenimientos.Text = "Mantenimientos";
            this.checkMantenimientos.UseVisualStyleBackColor = true;
            this.checkMantenimientos.CheckedChanged += new System.EventHandler(this.checkMantenimientos_CheckedChanged);
            // 
            // checkGastos
            // 
            this.checkGastos.AutoSize = true;
            this.checkGastos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGastos.Location = new System.Drawing.Point(432, 499);
            this.checkGastos.Name = "checkGastos";
            this.checkGastos.Size = new System.Drawing.Size(74, 23);
            this.checkGastos.TabIndex = 77;
            this.checkGastos.Text = "Gastos";
            this.checkGastos.UseVisualStyleBackColor = true;
            this.checkGastos.CheckedChanged += new System.EventHandler(this.checkGastos_CheckedChanged);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Teal;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnInfo.IconColor = System.Drawing.Color.White;
            this.btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfo.IconSize = 25;
            this.btnInfo.Location = new System.Drawing.Point(34, 406);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(30, 35);
            this.btnInfo.TabIndex = 98;
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // checkAutorizador
            // 
            this.checkAutorizador.AutoSize = true;
            this.checkAutorizador.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAutorizador.Location = new System.Drawing.Point(432, 528);
            this.checkAutorizador.Name = "checkAutorizador";
            this.checkAutorizador.Size = new System.Drawing.Size(106, 23);
            this.checkAutorizador.TabIndex = 99;
            this.checkAutorizador.Text = "Autorizador";
            this.checkAutorizador.UseVisualStyleBackColor = true;
            this.checkAutorizador.CheckedChanged += new System.EventHandler(this.checkAutorizador_CheckedChanged);
            // 
            // checkOrdenes
            // 
            this.checkOrdenes.AutoSize = true;
            this.checkOrdenes.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOrdenes.Location = new System.Drawing.Point(432, 556);
            this.checkOrdenes.Name = "checkOrdenes";
            this.checkOrdenes.Size = new System.Drawing.Size(170, 23);
            this.checkOrdenes.TabIndex = 100;
            this.checkOrdenes.Text = "Ordenes de Compra";
            this.checkOrdenes.UseVisualStyleBackColor = true;
            this.checkOrdenes.CheckedChanged += new System.EventHandler(this.checkOrdenes_CheckedChanged);
            // 
            // FrmUsersRols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 624);
            this.Controls.Add(this.checkOrdenes);
            this.Controls.Add(this.checkAutorizador);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.checkGastos);
            this.Controls.Add(this.checkMantenimientos);
            this.Controls.Add(this.checkVehiculo);
            this.Controls.Add(this.checkChofer);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNavRight);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIDUserRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkIsAdmin);
            this.Controls.Add(this.checkReport);
            this.Controls.Add(this.checkConsultar);
            this.Controls.Add(this.checkEliminar);
            this.Controls.Add(this.checkEditar);
            this.Controls.Add(this.checkAgregar);
            this.Controls.Add(this.DgvListaRolesUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsersRols";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Roles de Usuario";
            this.Load += new System.EventHandler(this.FrmUsersRols_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaRolesUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton btnMini;
        private System.Windows.Forms.DataGridView DgvListaRolesUsuario;
        private System.Windows.Forms.CheckBox checkAgregar;
        private System.Windows.Forms.CheckBox checkEditar;
        private System.Windows.Forms.CheckBox checkConsultar;
        private System.Windows.Forms.CheckBox checkEliminar;
        private System.Windows.Forms.CheckBox checkIsAdmin;
        private System.Windows.Forms.CheckBox checkReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDUserRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDUserRol;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel panelNavRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.CheckBox checkChofer;
        private System.Windows.Forms.CheckBox checkVehiculo;
        private System.Windows.Forms.CheckBox checkMantenimientos;
        private System.Windows.Forms.CheckBox checkGastos;
        private FontAwesome.Sharp.IconButton btnInfo;
        private System.Windows.Forms.CheckBox checkAutorizador;
        private System.Windows.Forms.CheckBox checkOrdenes;
    }
}