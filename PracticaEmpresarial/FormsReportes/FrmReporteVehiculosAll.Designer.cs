namespace PracticaEmpresarial.FormsReportes
{
    partial class FrmReporteVehiculosAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteVehiculosAll));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelNavRight = new System.Windows.Forms.Panel();
            this.DgvListaVehiculos = new System.Windows.Forms.DataGridView();
            this.CPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CKilometraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COilDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMarchamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Size = new System.Drawing.Size(1431, 51);
            this.panel1.TabIndex = 94;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PracticaEmpresarial.Properties.Resources.report;
            this.pictureBox1.Location = new System.Drawing.Point(884, 3);
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
            this.label7.Location = new System.Drawing.Point(513, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 49);
            this.label7.TabIndex = 98;
            this.label7.Text = "Reporte Vehículos";
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
            this.BtnClose.Location = new System.Drawing.Point(1397, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(31, 39);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 740);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1431, 10);
            this.panel2.TabIndex = 98;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 689);
            this.panel3.TabIndex = 99;
            // 
            // panelNavRight
            // 
            this.panelNavRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(141)))), ((int)(((byte)(246)))));
            this.panelNavRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNavRight.Location = new System.Drawing.Point(1421, 51);
            this.panelNavRight.Name = "panelNavRight";
            this.panelNavRight.Size = new System.Drawing.Size(10, 689);
            this.panelNavRight.TabIndex = 100;
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
            this.CDescripcion,
            this.CMarca,
            this.CAnio,
            this.CKilometraje,
            this.CRTV,
            this.COilDate,
            this.CMarchamo,
            this.CFullName,
            this.CNombre});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaVehiculos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaVehiculos.Location = new System.Drawing.Point(36, 87);
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
            this.DgvListaVehiculos.Size = new System.Drawing.Size(1363, 568);
            this.DgvListaVehiculos.TabIndex = 101;
            // 
            // CPlaca
            // 
            this.CPlaca.DataPropertyName = "Placa";
            this.CPlaca.HeaderText = "Placa";
            this.CPlaca.Name = "CPlaca";
            this.CPlaca.ReadOnly = true;
            // 
            // CDescripcion
            // 
            this.CDescripcion.DataPropertyName = "Descripcion";
            this.CDescripcion.FillWeight = 150F;
            this.CDescripcion.HeaderText = "Tipo Vehículo";
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.ReadOnly = true;
            this.CDescripcion.Width = 150;
            // 
            // CMarca
            // 
            this.CMarca.DataPropertyName = "Marca";
            this.CMarca.FillWeight = 120F;
            this.CMarca.HeaderText = "Marca";
            this.CMarca.Name = "CMarca";
            this.CMarca.ReadOnly = true;
            this.CMarca.Width = 120;
            // 
            // CAnio
            // 
            this.CAnio.DataPropertyName = "Anio";
            this.CAnio.HeaderText = "Año";
            this.CAnio.Name = "CAnio";
            this.CAnio.ReadOnly = true;
            // 
            // CKilometraje
            // 
            this.CKilometraje.DataPropertyName = "Kilometraje";
            this.CKilometraje.FillWeight = 110F;
            this.CKilometraje.HeaderText = "Kilometraje";
            this.CKilometraje.Name = "CKilometraje";
            this.CKilometraje.ReadOnly = true;
            this.CKilometraje.Width = 110;
            // 
            // CRTV
            // 
            this.CRTV.DataPropertyName = "RTV";
            this.CRTV.FillWeight = 180F;
            this.CRTV.HeaderText = "Proxima Revisión";
            this.CRTV.Name = "CRTV";
            this.CRTV.ReadOnly = true;
            this.CRTV.Width = 180;
            // 
            // COilDate
            // 
            this.COilDate.DataPropertyName = "OilDate";
            this.COilDate.FillWeight = 180F;
            this.COilDate.HeaderText = "Proximo Cambio Aceite";
            this.COilDate.Name = "COilDate";
            this.COilDate.ReadOnly = true;
            this.COilDate.Width = 180;
            // 
            // CMarchamo
            // 
            this.CMarchamo.DataPropertyName = "Marchamo";
            this.CMarchamo.HeaderText = "Marchamo";
            this.CMarchamo.Name = "CMarchamo";
            this.CMarchamo.ReadOnly = true;
            // 
            // CFullName
            // 
            this.CFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CFullName.DataPropertyName = "FullName";
            this.CFullName.HeaderText = "Chofer";
            this.CFullName.Name = "CFullName";
            this.CFullName.ReadOnly = true;
            // 
            // CNombre
            // 
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.FillWeight = 120F;
            this.CNombre.HeaderText = "Compañia";
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            this.CNombre.Width = 120;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cargando
            // 
            this.Cargando.Image = global::PracticaEmpresarial.Properties.Resources.loading_25;
            this.Cargando.Location = new System.Drawing.Point(1058, 686);
            this.Cargando.Name = "Cargando";
            this.Cargando.Size = new System.Drawing.Size(28, 28);
            this.Cargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cargando.TabIndex = 103;
            this.Cargando.TabStop = false;
            this.Cargando.Visible = false;
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExportar.IconColor = System.Drawing.Color.Black;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.Location = new System.Drawing.Point(1092, 680);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(144, 38);
            this.btnExportar.TabIndex = 102;
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
            this.btnCrystalReport.Location = new System.Drawing.Point(1242, 680);
            this.btnCrystalReport.Name = "btnCrystalReport";
            this.btnCrystalReport.Size = new System.Drawing.Size(157, 38);
            this.btnCrystalReport.TabIndex = 104;
            this.btnCrystalReport.Text = "       Crystal Report";
            this.btnCrystalReport.UseVisualStyleBackColor = true;
            this.btnCrystalReport.Click += new System.EventHandler(this.btnCrystalReport_Click);
            // 
            // FrmReporteVehiculosAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 750);
            this.Controls.Add(this.btnCrystalReport);
            this.Controls.Add(this.Cargando);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.DgvListaVehiculos);
            this.Controls.Add(this.panelNavRight);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteVehiculosAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Vehiculos";
            this.Load += new System.EventHandler(this.FrmReporteVehiculosAll_Load);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelNavRight;
        private System.Windows.Forms.DataGridView DgvListaVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CKilometraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn COilDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMarchamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private FontAwesome.Sharp.IconButton btnExportar;
        private System.Windows.Forms.PictureBox Cargando;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnCrystalReport;
    }
}