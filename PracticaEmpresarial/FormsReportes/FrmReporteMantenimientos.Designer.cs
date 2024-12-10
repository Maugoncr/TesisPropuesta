namespace PracticaEmpresarial.FormsReportes
{
    partial class FrmReporteMantenimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteMantenimientos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Cargando = new System.Windows.Forms.PictureBox();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            this.panelNavRight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvListaMantenimiento = new System.Windows.Forms.DataGridView();
            this.CConsecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CKilometraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaMantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDetalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCrystalReport = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cargando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1787, 51);
            this.panel1.TabIndex = 96;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PracticaEmpresarial.Properties.Resources.report;
            this.pictureBox1.Location = new System.Drawing.Point(1108, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(596, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(519, 49);
            this.label7.TabIndex = 98;
            this.label7.Text = "Reportes Mantenimientos";
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
            this.BtnClose.Location = new System.Drawing.Point(1746, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(31, 39);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 647);
            this.panel3.TabIndex = 107;
            // 
            // Cargando
            // 
            this.Cargando.Image = global::PracticaEmpresarial.Properties.Resources.loading_25;
            this.Cargando.Location = new System.Drawing.Point(1364, 640);
            this.Cargando.Name = "Cargando";
            this.Cargando.Size = new System.Drawing.Size(28, 28);
            this.Cargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cargando.TabIndex = 109;
            this.Cargando.TabStop = false;
            this.Cargando.Visible = false;
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExportar.IconColor = System.Drawing.Color.Black;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.Location = new System.Drawing.Point(1398, 634);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(183, 38);
            this.btnExportar.TabIndex = 108;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // panelNavRight
            // 
            this.panelNavRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.panelNavRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNavRight.Location = new System.Drawing.Point(1777, 51);
            this.panelNavRight.Name = "panelNavRight";
            this.panelNavRight.Size = new System.Drawing.Size(10, 647);
            this.panelNavRight.TabIndex = 110;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 688);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1767, 10);
            this.panel2.TabIndex = 111;
            // 
            // DgvListaMantenimiento
            // 
            this.DgvListaMantenimiento.AllowUserToAddRows = false;
            this.DgvListaMantenimiento.AllowUserToDeleteRows = false;
            this.DgvListaMantenimiento.AllowUserToResizeColumns = false;
            this.DgvListaMantenimiento.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaMantenimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListaMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaMantenimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CConsecutivo,
            this.CDetalle,
            this.CCosto,
            this.CDescripcion,
            this.CPlaca,
            this.CKilometraje,
            this.CFullName,
            this.CFechaRegistro,
            this.CFechaMantenimiento,
            this.CNombre,
            this.CDetalles});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaMantenimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaMantenimiento.Location = new System.Drawing.Point(27, 86);
            this.DgvListaMantenimiento.MultiSelect = false;
            this.DgvListaMantenimiento.Name = "DgvListaMantenimiento";
            this.DgvListaMantenimiento.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaMantenimiento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListaMantenimiento.RowHeadersVisible = false;
            this.DgvListaMantenimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaMantenimiento.Size = new System.Drawing.Size(1730, 533);
            this.DgvListaMantenimiento.TabIndex = 112;
            // 
            // CConsecutivo
            // 
            this.CConsecutivo.DataPropertyName = "Consecutivo";
            this.CConsecutivo.HeaderText = "Num Factura";
            this.CConsecutivo.Name = "CConsecutivo";
            this.CConsecutivo.ReadOnly = true;
            this.CConsecutivo.Width = 150;
            // 
            // CDetalle
            // 
            this.CDetalle.DataPropertyName = "Detalle";
            this.CDetalle.HeaderText = "Tipo";
            this.CDetalle.Name = "CDetalle";
            this.CDetalle.ReadOnly = true;
            this.CDetalle.Width = 150;
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
            this.CDescripcion.HeaderText = "Tienda de Servicio";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            this.CDescripcion.Width = 200;
            // 
            // CPlaca
            // 
            this.CPlaca.DataPropertyName = "Placa";
            this.CPlaca.HeaderText = "Placa";
            this.CPlaca.Name = "CPlaca";
            this.CPlaca.ReadOnly = true;
            this.CPlaca.Width = 150;
            // 
            // CKilometraje
            // 
            this.CKilometraje.DataPropertyName = "Kilometraje";
            this.CKilometraje.HeaderText = "Kilometraje";
            this.CKilometraje.Name = "CKilometraje";
            this.CKilometraje.ReadOnly = true;
            this.CKilometraje.Width = 120;
            // 
            // CFullName
            // 
            this.CFullName.DataPropertyName = "FullName";
            this.CFullName.HeaderText = "Chofer";
            this.CFullName.Name = "CFullName";
            this.CFullName.ReadOnly = true;
            this.CFullName.Width = 180;
            // 
            // CFechaRegistro
            // 
            this.CFechaRegistro.DataPropertyName = "FechaRegistro";
            this.CFechaRegistro.HeaderText = "Fecha Registro";
            this.CFechaRegistro.Name = "CFechaRegistro";
            this.CFechaRegistro.ReadOnly = true;
            this.CFechaRegistro.Width = 140;
            // 
            // CFechaMantenimiento
            // 
            this.CFechaMantenimiento.DataPropertyName = "FechaMantenimiento";
            this.CFechaMantenimiento.HeaderText = "Fecha Mantenimiento";
            this.CFechaMantenimiento.Name = "CFechaMantenimiento";
            this.CFechaMantenimiento.ReadOnly = true;
            this.CFechaMantenimiento.Width = 140;
            // 
            // CNombre
            // 
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Compañia";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            this.CNombre.Width = 120;
            // 
            // CDetalles
            // 
            this.CDetalles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDetalles.DataPropertyName = "Detalles";
            this.CDetalles.HeaderText = "Más Detalles";
            this.CDetalles.Name = "CDetalles";
            this.CDetalles.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCrystalReport
            // 
            this.btnCrystalReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrystalReport.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnCrystalReport.IconColor = System.Drawing.Color.Black;
            this.btnCrystalReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrystalReport.IconSize = 30;
            this.btnCrystalReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrystalReport.Location = new System.Drawing.Point(1600, 634);
            this.btnCrystalReport.Name = "btnCrystalReport";
            this.btnCrystalReport.Size = new System.Drawing.Size(157, 38);
            this.btnCrystalReport.TabIndex = 113;
            this.btnCrystalReport.Text = "       Crystal Report";
            this.btnCrystalReport.UseVisualStyleBackColor = true;
            this.btnCrystalReport.Click += new System.EventHandler(this.btnCrystalReport_Click);
            // 
            // FrmReporteMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 698);
            this.Controls.Add(this.btnCrystalReport);
            this.Controls.Add(this.DgvListaMantenimiento);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNavRight);
            this.Controls.Add(this.Cargando);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteMantenimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Mantenimientos";
            this.Load += new System.EventHandler(this.FrmReporteMantenimientos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cargando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaMantenimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox Cargando;
        private FontAwesome.Sharp.IconButton btnExportar;
        private System.Windows.Forms.Panel panelNavRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvListaMantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CConsecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CKilometraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaMantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDetalles;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnCrystalReport;
    }
}