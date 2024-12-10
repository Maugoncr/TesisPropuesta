namespace PracticaEmpresarial.FormsReportes
{
    partial class FrmReporteVehiculoPorPlaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteVehiculoPorPlaca));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelNavRight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvListaVehiculos = new System.Windows.Forms.DataGridView();
            this.CPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CKilometraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CConsecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDetalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaMantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Cargando = new System.Windows.Forms.PictureBox();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            this.btnCrystalReport = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cargando)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1326, 51);
            this.panel1.TabIndex = 95;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PracticaEmpresarial.Properties.Resources.report;
            this.pictureBox1.Location = new System.Drawing.Point(742, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(377, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 49);
            this.label7.TabIndex = 98;
            this.label7.Text = "Reporte Vehículo";
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
            this.BtnClose.Location = new System.Drawing.Point(1285, 6);
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
            this.panel3.Size = new System.Drawing.Size(10, 519);
            this.panel3.TabIndex = 100;
            // 
            // panelNavRight
            // 
            this.panelNavRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.panelNavRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNavRight.Location = new System.Drawing.Point(1316, 51);
            this.panelNavRight.Name = "panelNavRight";
            this.panelNavRight.Size = new System.Drawing.Size(10, 519);
            this.panelNavRight.TabIndex = 101;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1306, 10);
            this.panel2.TabIndex = 102;
            // 
            // DgvListaVehiculos
            // 
            this.DgvListaVehiculos.AllowUserToAddRows = false;
            this.DgvListaVehiculos.AllowUserToDeleteRows = false;
            this.DgvListaVehiculos.AllowUserToResizeColumns = false;
            this.DgvListaVehiculos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListaVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPlaca,
            this.CKilometraje,
            this.CDetalle,
            this.CConsecutivo,
            this.CCosto,
            this.CDetalles,
            this.CFechaMantenimiento});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaVehiculos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaVehiculos.Location = new System.Drawing.Point(42, 73);
            this.DgvListaVehiculos.MultiSelect = false;
            this.DgvListaVehiculos.Name = "DgvListaVehiculos";
            this.DgvListaVehiculos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaVehiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvListaVehiculos.RowHeadersVisible = false;
            this.DgvListaVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaVehiculos.Size = new System.Drawing.Size(1259, 401);
            this.DgvListaVehiculos.TabIndex = 103;
            // 
            // CPlaca
            // 
            this.CPlaca.DataPropertyName = "Placa";
            this.CPlaca.HeaderText = "Placa";
            this.CPlaca.Name = "CPlaca";
            this.CPlaca.ReadOnly = true;
            this.CPlaca.Width = 110;
            // 
            // CKilometraje
            // 
            this.CKilometraje.DataPropertyName = "Kilometraje";
            this.CKilometraje.HeaderText = "Kilometraje";
            this.CKilometraje.Name = "CKilometraje";
            this.CKilometraje.ReadOnly = true;
            this.CKilometraje.Width = 120;
            // 
            // CDetalle
            // 
            this.CDetalle.DataPropertyName = "Detalle";
            this.CDetalle.HeaderText = "Mantenimiento";
            this.CDetalle.Name = "CDetalle";
            this.CDetalle.ReadOnly = true;
            this.CDetalle.Width = 180;
            // 
            // CConsecutivo
            // 
            this.CConsecutivo.DataPropertyName = "Consecutivo";
            this.CConsecutivo.HeaderText = "Num Factura";
            this.CConsecutivo.Name = "CConsecutivo";
            this.CConsecutivo.ReadOnly = true;
            this.CConsecutivo.Width = 150;
            // 
            // CCosto
            // 
            this.CCosto.DataPropertyName = "Costo";
            this.CCosto.HeaderText = "Costo";
            this.CCosto.Name = "CCosto";
            this.CCosto.ReadOnly = true;
            // 
            // CDetalles
            // 
            this.CDetalles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDetalles.DataPropertyName = "Detalles";
            this.CDetalles.HeaderText = "Detalles";
            this.CDetalles.Name = "CDetalles";
            this.CDetalles.ReadOnly = true;
            // 
            // CFechaMantenimiento
            // 
            this.CFechaMantenimiento.DataPropertyName = "FechaMantenimiento";
            this.CFechaMantenimiento.FillWeight = 125F;
            this.CFechaMantenimiento.HeaderText = "Fecha Mantenimiento";
            this.CFechaMantenimiento.Name = "CFechaMantenimiento";
            this.CFechaMantenimiento.ReadOnly = true;
            this.CFechaMantenimiento.Width = 125;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cargando
            // 
            this.Cargando.Image = global::PracticaEmpresarial.Properties.Resources.loading_25;
            this.Cargando.Location = new System.Drawing.Point(921, 502);
            this.Cargando.Name = "Cargando";
            this.Cargando.Size = new System.Drawing.Size(28, 28);
            this.Cargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cargando.TabIndex = 105;
            this.Cargando.TabStop = false;
            this.Cargando.Visible = false;
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExportar.IconColor = System.Drawing.Color.Black;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.Location = new System.Drawing.Point(955, 497);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(183, 38);
            this.btnExportar.TabIndex = 104;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnCrystalReport
            // 
            this.btnCrystalReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrystalReport.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnCrystalReport.IconColor = System.Drawing.Color.Black;
            this.btnCrystalReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrystalReport.IconSize = 30;
            this.btnCrystalReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrystalReport.Location = new System.Drawing.Point(1144, 497);
            this.btnCrystalReport.Name = "btnCrystalReport";
            this.btnCrystalReport.Size = new System.Drawing.Size(157, 38);
            this.btnCrystalReport.TabIndex = 106;
            this.btnCrystalReport.Text = "       Crystal Report";
            this.btnCrystalReport.UseVisualStyleBackColor = true;
            this.btnCrystalReport.Click += new System.EventHandler(this.btnCrystalReport_Click);
            // 
            // FrmReporteVehiculoPorPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 570);
            this.Controls.Add(this.btnCrystalReport);
            this.Controls.Add(this.Cargando);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.DgvListaVehiculos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNavRight);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteVehiculoPorPlaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Vehículo";
            this.Load += new System.EventHandler(this.FrmReporteVehiculoPorPlaca_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cargando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelNavRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvListaVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CKilometraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CConsecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaMantenimiento;
        private FontAwesome.Sharp.IconButton btnExportar;
        private System.Windows.Forms.PictureBox Cargando;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnCrystalReport;
    }
}