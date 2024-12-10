﻿namespace PracticaEmpresarial.Forms
{
    partial class FrmGestionTiposMantenimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionTiposMantenimientos));
            this.DgvListaTipos = new System.Windows.Forms.DataGridView();
            this.CIDTipoMantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtIDTipoMantenimiento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.btnMini = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelNavRight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnInfo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaTipos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListaTipos
            // 
            this.DgvListaTipos.AllowUserToAddRows = false;
            this.DgvListaTipos.AllowUserToDeleteRows = false;
            this.DgvListaTipos.AllowUserToResizeColumns = false;
            this.DgvListaTipos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaTipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListaTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaTipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDTipoMantenimiento,
            this.CDetalle});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaTipos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaTipos.Location = new System.Drawing.Point(46, 119);
            this.DgvListaTipos.MultiSelect = false;
            this.DgvListaTipos.Name = "DgvListaTipos";
            this.DgvListaTipos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaTipos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListaTipos.RowHeadersVisible = false;
            this.DgvListaTipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaTipos.Size = new System.Drawing.Size(620, 228);
            this.DgvListaTipos.TabIndex = 87;
            this.DgvListaTipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaTipos_CellClick);
            // 
            // CIDTipoMantenimiento
            // 
            this.CIDTipoMantenimiento.DataPropertyName = "IDTipoMantenimiento";
            this.CIDTipoMantenimiento.HeaderText = "Código";
            this.CIDTipoMantenimiento.Name = "CIDTipoMantenimiento";
            this.CIDTipoMantenimiento.ReadOnly = true;
            this.CIDTipoMantenimiento.Width = 150;
            // 
            // CDetalle
            // 
            this.CDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDetalle.DataPropertyName = "Detalle";
            this.CDetalle.HeaderText = "Tipo";
            this.CDetalle.Name = "CDetalle";
            this.CDetalle.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 19);
            this.label2.TabIndex = 86;
            this.label2.Text = "Tipo de mantenimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 85;
            this.label1.Text = "Codigo:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(157, 451);
            this.txtDetalle.MaxLength = 100;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(384, 24);
            this.txtDetalle.TabIndex = 84;
            this.txtDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDetalle.Leave += new System.EventHandler(this.txtDetalle_Leave);
            // 
            // txtIDTipoMantenimiento
            // 
            this.txtIDTipoMantenimiento.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDTipoMantenimiento.Location = new System.Drawing.Point(189, 388);
            this.txtIDTipoMantenimiento.Name = "txtIDTipoMantenimiento";
            this.txtIDTipoMantenimiento.ReadOnly = true;
            this.txtIDTipoMantenimiento.Size = new System.Drawing.Size(319, 24);
            this.txtIDTipoMantenimiento.TabIndex = 83;
            this.txtIDTipoMantenimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(108, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(506, 49);
            this.label7.TabIndex = 91;
            this.label7.Text = "Tipos de Mantenimientos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 41);
            this.panel1.TabIndex = 92;
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
            this.BtnClose.Location = new System.Drawing.Point(672, 3);
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
            this.btnMini.Location = new System.Drawing.Point(635, 3);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(31, 39);
            this.btnMini.TabIndex = 4;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 539);
            this.panel3.TabIndex = 93;
            // 
            // panelNavRight
            // 
            this.panelNavRight.BackColor = System.Drawing.Color.Teal;
            this.panelNavRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNavRight.Location = new System.Drawing.Point(701, 41);
            this.panelNavRight.Name = "panelNavRight";
            this.panelNavRight.Size = new System.Drawing.Size(10, 539);
            this.panelNavRight.TabIndex = 94;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 570);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 10);
            this.panel2.TabIndex = 95;
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
            this.btnLimpiar.Location = new System.Drawing.Point(428, 519);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 29);
            this.btnLimpiar.TabIndex = 90;
            this.btnLimpiar.Text = "        Limpiar";
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
            this.btnEditar.Location = new System.Drawing.Point(295, 519);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 29);
            this.btnEditar.TabIndex = 89;
            this.btnEditar.Text = "        Editar";
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
            this.btnAgregar.Location = new System.Drawing.Point(157, 519);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 29);
            this.btnAgregar.TabIndex = 88;
            this.btnAgregar.Text = "       Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnInfo.Location = new System.Drawing.Point(117, 445);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(30, 35);
            this.btnInfo.TabIndex = 96;
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // FrmGestionTiposMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 580);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNavRight);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.DgvListaTipos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtIDTipoMantenimiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionTiposMantenimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Tipos de Mantenimientos";
            this.Load += new System.EventHandler(this.FrmGestionTiposMantenimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaTipos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.DataGridView DgvListaTipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtIDTipoMantenimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnClose;
        private FontAwesome.Sharp.IconButton btnMini;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelNavRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDTipoMantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDetalle;
        private FontAwesome.Sharp.IconButton btnInfo;
    }
}