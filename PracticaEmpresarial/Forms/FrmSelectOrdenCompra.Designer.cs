namespace PracticaEmpresarial.Forms
{
    partial class FrmSelectOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectOrdenCompra));
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnSeleccionarOrden = new FontAwesome.Sharp.IconButton();
            this.DgvListaOrden = new System.Windows.Forms.DataGridView();
            this.CIDOrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDetalleOrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaParaRealizar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelNavRight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaOrden)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(233, 52);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(693, 24);
            this.txtFiltro.TabIndex = 155;
            this.txtFiltro.Text = "Buscar...";
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltro.Click += new System.EventHandler(this.txtFiltro_Click);
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
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
            this.btnCancelar.Location = new System.Drawing.Point(1055, 564);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 29);
            this.btnCancelar.TabIndex = 157;
            this.btnCancelar.Text = "       Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionarOrden
            // 
            this.btnSeleccionarOrden.BackColor = System.Drawing.Color.Teal;
            this.btnSeleccionarOrden.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarOrden.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarOrden.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarOrden.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnSeleccionarOrden.IconColor = System.Drawing.Color.White;
            this.btnSeleccionarOrden.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeleccionarOrden.IconSize = 25;
            this.btnSeleccionarOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarOrden.Location = new System.Drawing.Point(991, 512);
            this.btnSeleccionarOrden.Name = "btnSeleccionarOrden";
            this.btnSeleccionarOrden.Size = new System.Drawing.Size(176, 29);
            this.btnSeleccionarOrden.TabIndex = 156;
            this.btnSeleccionarOrden.Text = "       Seleccionar Orden";
            this.btnSeleccionarOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarOrden.UseVisualStyleBackColor = false;
            this.btnSeleccionarOrden.Click += new System.EventHandler(this.btnSeleccionarOrden_Click);
            // 
            // DgvListaOrden
            // 
            this.DgvListaOrden.AllowUserToAddRows = false;
            this.DgvListaOrden.AllowUserToDeleteRows = false;
            this.DgvListaOrden.AllowUserToResizeColumns = false;
            this.DgvListaOrden.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaOrden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListaOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDOrdenCompra,
            this.CCodigo,
            this.CDetalleOrdenCompra,
            this.CCosto,
            this.CFechaParaRealizar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaOrden.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaOrden.Location = new System.Drawing.Point(51, 96);
            this.DgvListaOrden.MultiSelect = false;
            this.DgvListaOrden.Name = "DgvListaOrden";
            this.DgvListaOrden.ReadOnly = true;
            this.DgvListaOrden.RowHeadersVisible = false;
            this.DgvListaOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaOrden.Size = new System.Drawing.Size(1116, 382);
            this.DgvListaOrden.TabIndex = 158;
            this.DgvListaOrden.VirtualMode = true;
            // 
            // CIDOrdenCompra
            // 
            this.CIDOrdenCompra.DataPropertyName = "IDOrdenCompra";
            this.CIDOrdenCompra.HeaderText = "ID Orden Compra";
            this.CIDOrdenCompra.Name = "CIDOrdenCompra";
            this.CIDOrdenCompra.ReadOnly = true;
            this.CIDOrdenCompra.Width = 120;
            // 
            // CCodigo
            // 
            this.CCodigo.DataPropertyName = "Codigo";
            this.CCodigo.HeaderText = "Código";
            this.CCodigo.Name = "CCodigo";
            this.CCodigo.ReadOnly = true;
            this.CCodigo.Width = 120;
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
            this.CCosto.HeaderText = "Costo";
            this.CCosto.Name = "CCosto";
            this.CCosto.ReadOnly = true;
            this.CCosto.Width = 130;
            // 
            // CFechaParaRealizar
            // 
            this.CFechaParaRealizar.DataPropertyName = "FechaParaRealizar";
            this.CFechaParaRealizar.HeaderText = "Realizar el:";
            this.CFechaParaRealizar.Name = "CFechaParaRealizar";
            this.CFechaParaRealizar.ReadOnly = true;
            this.CFechaParaRealizar.Width = 105;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 29);
            this.panel1.TabIndex = 159;
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
            this.BtnClose.Location = new System.Drawing.Point(1172, -3);
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
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 606);
            this.panel3.TabIndex = 160;
            // 
            // panelNavRight
            // 
            this.panelNavRight.BackColor = System.Drawing.Color.Teal;
            this.panelNavRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNavRight.Location = new System.Drawing.Point(1196, 29);
            this.panelNavRight.Name = "panelNavRight";
            this.panelNavRight.Size = new System.Drawing.Size(10, 606);
            this.panelNavRight.TabIndex = 161;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 625);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1186, 10);
            this.panel2.TabIndex = 162;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(70, 521);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(600, 45);
            this.label13.TabIndex = 163;
            this.label13.Text = "Seleccionar Orden de Compra";
            // 
            // FrmSelectOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 635);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNavRight);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvListaOrden);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionarOrden);
            this.Controls.Add(this.txtFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSelectOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Orden de Compra";
            this.Load += new System.EventHandler(this.FrmSelectOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaOrden)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnSeleccionarOrden;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView DgvListaOrden;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelNavRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDOrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDetalleOrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaParaRealizar;
        private System.Windows.Forms.Label label13;
    }
}