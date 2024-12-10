namespace PracticaEmpresarial.Forms
{
    partial class FrmGestionArchivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionArchivos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelNavRight = new System.Windows.Forms.Panel();
            this.DgvListaArchivos = new System.Windows.Forms.DataGridView();
            this.CIDImg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcionTipoArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerArchivo = new FontAwesome.Sharp.IconButton();
            this.btnGuardarArchivo = new FontAwesome.Sharp.IconButton();
            this.btnEditarArchivo = new FontAwesome.Sharp.IconButton();
            this.btnSeleccionarArchivo = new FontAwesome.Sharp.IconButton();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnExaminar = new FontAwesome.Sharp.IconButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipoArchivo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaArchivos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 40);
            this.panel1.TabIndex = 5;
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
            this.BtnClose.Location = new System.Drawing.Point(1079, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(31, 39);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 559);
            this.panel3.TabIndex = 118;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 589);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 10);
            this.panel2.TabIndex = 120;
            // 
            // panelNavRight
            // 
            this.panelNavRight.BackColor = System.Drawing.Color.Teal;
            this.panelNavRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNavRight.Location = new System.Drawing.Point(1103, 40);
            this.panelNavRight.Name = "panelNavRight";
            this.panelNavRight.Size = new System.Drawing.Size(10, 549);
            this.panelNavRight.TabIndex = 121;
            // 
            // DgvListaArchivos
            // 
            this.DgvListaArchivos.AllowUserToAddRows = false;
            this.DgvListaArchivos.AllowUserToDeleteRows = false;
            this.DgvListaArchivos.AllowUserToResizeColumns = false;
            this.DgvListaArchivos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaArchivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListaArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDImg,
            this.CNombre,
            this.CDescripcionTipoArchivo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaArchivos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaArchivos.Location = new System.Drawing.Point(36, 84);
            this.DgvListaArchivos.MultiSelect = false;
            this.DgvListaArchivos.Name = "DgvListaArchivos";
            this.DgvListaArchivos.ReadOnly = true;
            this.DgvListaArchivos.RowHeadersVisible = false;
            this.DgvListaArchivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaArchivos.Size = new System.Drawing.Size(1044, 273);
            this.DgvListaArchivos.TabIndex = 122;
            this.DgvListaArchivos.VirtualMode = true;
            this.DgvListaArchivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaArchivos_CellClick);
            // 
            // CIDImg
            // 
            this.CIDImg.DataPropertyName = "IDImg";
            this.CIDImg.HeaderText = "Codigo Archivo";
            this.CIDImg.Name = "CIDImg";
            this.CIDImg.ReadOnly = true;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Nombre del Archivo";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CDescripcionTipoArchivo
            // 
            this.CDescripcionTipoArchivo.DataPropertyName = "DescripcionTipoArchivo";
            this.CDescripcionTipoArchivo.HeaderText = "Tipo Archivo";
            this.CDescripcionTipoArchivo.Name = "CDescripcionTipoArchivo";
            this.CDescripcionTipoArchivo.ReadOnly = true;
            this.CDescripcionTipoArchivo.Width = 200;
            // 
            // btnVerArchivo
            // 
            this.btnVerArchivo.BackColor = System.Drawing.Color.Teal;
            this.btnVerArchivo.FlatAppearance.BorderSize = 0;
            this.btnVerArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerArchivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerArchivo.ForeColor = System.Drawing.Color.White;
            this.btnVerArchivo.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnVerArchivo.IconColor = System.Drawing.Color.White;
            this.btnVerArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerArchivo.IconSize = 25;
            this.btnVerArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerArchivo.Location = new System.Drawing.Point(944, 407);
            this.btnVerArchivo.Name = "btnVerArchivo";
            this.btnVerArchivo.Size = new System.Drawing.Size(136, 29);
            this.btnVerArchivo.TabIndex = 123;
            this.btnVerArchivo.Text = "         Ver Archivo";
            this.btnVerArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerArchivo.UseVisualStyleBackColor = false;
            this.btnVerArchivo.Click += new System.EventHandler(this.btnVerArchivo_Click);
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.BackColor = System.Drawing.Color.Teal;
            this.btnGuardarArchivo.FlatAppearance.BorderSize = 0;
            this.btnGuardarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarArchivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarArchivo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnGuardarArchivo.IconColor = System.Drawing.Color.White;
            this.btnGuardarArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarArchivo.IconSize = 25;
            this.btnGuardarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarArchivo.Location = new System.Drawing.Point(366, 431);
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.Size = new System.Drawing.Size(112, 29);
            this.btnGuardarArchivo.TabIndex = 124;
            this.btnGuardarArchivo.Text = "       Guardar";
            this.btnGuardarArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarArchivo.UseVisualStyleBackColor = false;
            this.btnGuardarArchivo.Click += new System.EventHandler(this.btnGuardarArchivo_Click);
            // 
            // btnEditarArchivo
            // 
            this.btnEditarArchivo.BackColor = System.Drawing.Color.Teal;
            this.btnEditarArchivo.FlatAppearance.BorderSize = 0;
            this.btnEditarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarArchivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnEditarArchivo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditarArchivo.IconColor = System.Drawing.Color.White;
            this.btnEditarArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarArchivo.IconSize = 23;
            this.btnEditarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarArchivo.Location = new System.Drawing.Point(366, 466);
            this.btnEditarArchivo.Name = "btnEditarArchivo";
            this.btnEditarArchivo.Size = new System.Drawing.Size(112, 29);
            this.btnEditarArchivo.TabIndex = 125;
            this.btnEditarArchivo.Text = "       Editar";
            this.btnEditarArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarArchivo.UseVisualStyleBackColor = false;
            this.btnEditarArchivo.Click += new System.EventHandler(this.btnEditarArchivo_Click);
            // 
            // btnSeleccionarArchivo
            // 
            this.btnSeleccionarArchivo.BackColor = System.Drawing.Color.Teal;
            this.btnSeleccionarArchivo.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarArchivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarArchivo.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnSeleccionarArchivo.IconColor = System.Drawing.Color.White;
            this.btnSeleccionarArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeleccionarArchivo.IconSize = 25;
            this.btnSeleccionarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarArchivo.Location = new System.Drawing.Point(904, 371);
            this.btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            this.btnSeleccionarArchivo.Size = new System.Drawing.Size(176, 29);
            this.btnSeleccionarArchivo.TabIndex = 126;
            this.btnSeleccionarArchivo.Text = "       Seleccionar Archivo";
            this.btnSeleccionarArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarArchivo.UseVisualStyleBackColor = false;
            this.btnSeleccionarArchivo.Click += new System.EventHandler(this.btnSeleccionarArchivo_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(36, 399);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(311, 24);
            this.txtRuta.TabIndex = 127;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(36, 444);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(311, 24);
            this.txtNombre.TabIndex = 128;
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 129;
            this.label4.Text = "Ruta del Archivo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 130;
            this.label1.Text = "Nombre del Archivo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Teal;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(968, 554);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 29);
            this.btnCancelar.TabIndex = 131;
            this.btnCancelar.Text = "       Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.Teal;
            this.btnExaminar.FlatAppearance.BorderSize = 0;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.Color.White;
            this.btnExaminar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnExaminar.IconColor = System.Drawing.Color.White;
            this.btnExaminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExaminar.IconSize = 25;
            this.btnExaminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExaminar.Location = new System.Drawing.Point(366, 396);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(112, 29);
            this.btnExaminar.TabIndex = 132;
            this.btnExaminar.Text = "       Examinar";
            this.btnExaminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(547, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(434, 49);
            this.label9.TabIndex = 133;
            this.label9.Text = "Gestor de Evidencias";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(226, 54);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(693, 24);
            this.txtFiltro.TabIndex = 134;
            this.txtFiltro.Text = "Buscar...";
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltro.Click += new System.EventHandler(this.txtFiltro_Click);
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
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
            this.btnLimpiar.Location = new System.Drawing.Point(366, 500);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 29);
            this.btnLimpiar.TabIndex = 135;
            this.btnLimpiar.Text = "       Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 137;
            this.label8.Text = "Tipo Archivo";
            // 
            // cbTipoArchivo
            // 
            this.cbTipoArchivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoArchivo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoArchivo.FormattingEnabled = true;
            this.cbTipoArchivo.Location = new System.Drawing.Point(36, 498);
            this.cbTipoArchivo.Name = "cbTipoArchivo";
            this.cbTipoArchivo.Size = new System.Drawing.Size(311, 25);
            this.cbTipoArchivo.TabIndex = 136;
            this.cbTipoArchivo.SelectionChangeCommitted += new System.EventHandler(this.cbTipoArchivo_SelectionChangeCommitted);
            // 
            // FrmGestionArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 599);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbTipoArchivo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.btnSeleccionarArchivo);
            this.Controls.Add(this.btnEditarArchivo);
            this.Controls.Add(this.btnGuardarArchivo);
            this.Controls.Add(this.btnVerArchivo);
            this.Controls.Add(this.DgvListaArchivos);
            this.Controls.Add(this.panelNavRight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionArchivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Archivos";
            this.Load += new System.EventHandler(this.FrmGestionArchivos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaArchivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelNavRight;
        private System.Windows.Forms.DataGridView DgvListaArchivos;
        private FontAwesome.Sharp.IconButton btnVerArchivo;
        private FontAwesome.Sharp.IconButton btnGuardarArchivo;
        private FontAwesome.Sharp.IconButton btnEditarArchivo;
        private FontAwesome.Sharp.IconButton btnSeleccionarArchivo;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnExaminar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFiltro;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTipoArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcionTipoArchivo;
    }
}