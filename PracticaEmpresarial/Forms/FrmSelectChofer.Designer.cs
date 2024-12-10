namespace PracticaEmpresarial.Forms
{
    partial class FrmSelectChofer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectChofer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelNavRight = new System.Windows.Forms.Panel();
            this.DgvListaChofer = new System.Windows.Forms.DataGridView();
            this.CIDChofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnSeleccionarChofer = new FontAwesome.Sharp.IconButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDChofer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaChofer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 29);
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
            this.BtnClose.Location = new System.Drawing.Point(872, -3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(31, 39);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(180)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 586);
            this.panel3.TabIndex = 144;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(180)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 605);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 10);
            this.panel2.TabIndex = 145;
            // 
            // panelNavRight
            // 
            this.panelNavRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(180)))));
            this.panelNavRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNavRight.Location = new System.Drawing.Point(893, 29);
            this.panelNavRight.Name = "panelNavRight";
            this.panelNavRight.Size = new System.Drawing.Size(10, 576);
            this.panelNavRight.TabIndex = 146;
            // 
            // DgvListaChofer
            // 
            this.DgvListaChofer.AllowUserToAddRows = false;
            this.DgvListaChofer.AllowUserToDeleteRows = false;
            this.DgvListaChofer.AllowUserToResizeColumns = false;
            this.DgvListaChofer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaChofer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListaChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaChofer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDChofer,
            this.CFullName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaChofer.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListaChofer.Location = new System.Drawing.Point(42, 89);
            this.DgvListaChofer.MultiSelect = false;
            this.DgvListaChofer.Name = "DgvListaChofer";
            this.DgvListaChofer.ReadOnly = true;
            this.DgvListaChofer.RowHeadersVisible = false;
            this.DgvListaChofer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaChofer.Size = new System.Drawing.Size(817, 382);
            this.DgvListaChofer.TabIndex = 147;
            this.DgvListaChofer.VirtualMode = true;
            this.DgvListaChofer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaChofer_CellClick);
            // 
            // CIDChofer
            // 
            this.CIDChofer.DataPropertyName = "IDChofer";
            this.CIDChofer.HeaderText = "Codigo Chofer";
            this.CIDChofer.Name = "CIDChofer";
            this.CIDChofer.ReadOnly = true;
            // 
            // CFullName
            // 
            this.CFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CFullName.DataPropertyName = "FullName";
            this.CFullName.HeaderText = "Nombre del Chofer";
            this.CFullName.Name = "CFullName";
            this.CFullName.ReadOnly = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(103, 49);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(693, 24);
            this.txtFiltro.TabIndex = 148;
            this.txtFiltro.Text = "Buscar...";
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltro.Click += new System.EventHandler(this.txtFiltro_Click);
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnSeleccionarChofer
            // 
            this.btnSeleccionarChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnSeleccionarChofer.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarChofer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarChofer.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarChofer.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnSeleccionarChofer.IconColor = System.Drawing.Color.White;
            this.btnSeleccionarChofer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeleccionarChofer.IconSize = 25;
            this.btnSeleccionarChofer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarChofer.Location = new System.Drawing.Point(683, 502);
            this.btnSeleccionarChofer.Name = "btnSeleccionarChofer";
            this.btnSeleccionarChofer.Size = new System.Drawing.Size(176, 29);
            this.btnSeleccionarChofer.TabIndex = 149;
            this.btnSeleccionarChofer.Text = "       Seleccionar Chofer";
            this.btnSeleccionarChofer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarChofer.UseVisualStyleBackColor = false;
            this.btnSeleccionarChofer.Click += new System.EventHandler(this.btnSeleccionarChofer_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(103, 553);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(348, 24);
            this.txtNombre.TabIndex = 151;
            // 
            // txtIDChofer
            // 
            this.txtIDChofer.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDChofer.Location = new System.Drawing.Point(103, 507);
            this.txtIDChofer.Name = "txtIDChofer";
            this.txtIDChofer.ReadOnly = true;
            this.txtIDChofer.Size = new System.Drawing.Size(348, 24);
            this.txtIDChofer.TabIndex = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 153;
            this.label1.Text = "Nombre del Chofer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 152;
            this.label4.Text = "Código del Chofer";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(714, 548);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 29);
            this.btnCancelar.TabIndex = 154;
            this.btnCancelar.Text = "       Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmSelectChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 615);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDChofer);
            this.Controls.Add(this.btnSeleccionarChofer);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.DgvListaChofer);
            this.Controls.Add(this.panelNavRight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSelectChofer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Chofer";
            this.Load += new System.EventHandler(this.FrmSelectChofer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaChofer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelNavRight;
        private System.Windows.Forms.DataGridView DgvListaChofer;
        private System.Windows.Forms.TextBox txtFiltro;
        private FontAwesome.Sharp.IconButton btnSeleccionarChofer;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIDChofer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDChofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFullName;
    }
}