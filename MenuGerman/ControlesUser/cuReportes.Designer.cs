namespace MenuGerman.ControlesUser
{
    partial class cuReportes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcReportes = new System.Windows.Forms.TabControl();
            this.tpVenta = new System.Windows.Forms.TabPage();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.dgvVerVenta = new System.Windows.Forms.DataGridView();
            this.gbFechas = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cdtpFechaHasta = new MenuGerman.customDateTimePicker();
            this.cdtpFechaDesde = new MenuGerman.customDateTimePicker();
            this.btnBuscar = new MenuGerman.customButton();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tcReportes.SuspendLayout();
            this.tpVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerVenta)).BeginInit();
            this.gbFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcReportes
            // 
            this.tcReportes.Controls.Add(this.tpVenta);
            this.tcReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcReportes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcReportes.Location = new System.Drawing.Point(0, 0);
            this.tcReportes.Name = "tcReportes";
            this.tcReportes.SelectedIndex = 0;
            this.tcReportes.Size = new System.Drawing.Size(1152, 564);
            this.tcReportes.TabIndex = 0;
            // 
            // tpVenta
            // 
            this.tpVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tpVenta.Controls.Add(this.lblTotal);
            this.tpVenta.Controls.Add(this.label10);
            this.tpVenta.Controls.Add(this.label11);
            this.tpVenta.Controls.Add(this.lblDescuento);
            this.tpVenta.Controls.Add(this.label3);
            this.tpVenta.Controls.Add(this.label5);
            this.tpVenta.Controls.Add(this.lblSubTotal);
            this.tpVenta.Controls.Add(this.label1);
            this.tpVenta.Controls.Add(this.label4);
            this.tpVenta.Controls.Add(this.chkFechas);
            this.tpVenta.Controls.Add(this.dgvVerVenta);
            this.tpVenta.Controls.Add(this.gbFechas);
            this.tpVenta.Controls.Add(this.btnBuscar);
            this.tpVenta.Controls.Add(this.txtIdVenta);
            this.tpVenta.Controls.Add(this.label6);
            this.tpVenta.Location = new System.Drawing.Point(4, 30);
            this.tpVenta.Name = "tpVenta";
            this.tpVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tpVenta.Size = new System.Drawing.Size(1144, 530);
            this.tpVenta.TabIndex = 0;
            this.tpVenta.Text = "Ventas";
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFechas.Location = new System.Drawing.Point(533, 14);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(15, 14);
            this.chkFechas.TabIndex = 75;
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
            // 
            // dgvVerVenta
            // 
            this.dgvVerVenta.AllowUserToAddRows = false;
            this.dgvVerVenta.AllowUserToDeleteRows = false;
            this.dgvVerVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvVerVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVerVenta.ColumnHeadersHeight = 35;
            this.dgvVerVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVerVenta.EnableHeadersVisualStyles = false;
            this.dgvVerVenta.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvVerVenta.Location = new System.Drawing.Point(16, 146);
            this.dgvVerVenta.Name = "dgvVerVenta";
            this.dgvVerVenta.ReadOnly = true;
            this.dgvVerVenta.RowHeadersVisible = false;
            this.dgvVerVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerVenta.Size = new System.Drawing.Size(1109, 317);
            this.dgvVerVenta.TabIndex = 74;
            this.dgvVerVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerVenta_CellDoubleClick);
            // 
            // gbFechas
            // 
            this.gbFechas.Controls.Add(this.cdtpFechaHasta);
            this.gbFechas.Controls.Add(this.label9);
            this.gbFechas.Controls.Add(this.cdtpFechaDesde);
            this.gbFechas.Controls.Add(this.label8);
            this.gbFechas.Enabled = false;
            this.gbFechas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFechas.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.gbFechas.Location = new System.Drawing.Point(533, 34);
            this.gbFechas.Name = "gbFechas";
            this.gbFechas.Size = new System.Drawing.Size(592, 106);
            this.gbFechas.TabIndex = 73;
            this.gbFechas.TabStop = false;
            this.gbFechas.Text = "Por fechas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(302, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "Hasta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(11, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 70;
            this.label8.Text = "Desde:";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.AccessibleName = "";
            this.txtIdVenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVenta.Location = new System.Drawing.Point(16, 99);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(197, 27);
            this.txtIdVenta.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Id venta";
            // 
            // cdtpFechaHasta
            // 
            this.cdtpFechaHasta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cdtpFechaHasta.BorderSize = 0;
            this.cdtpFechaHasta.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdtpFechaHasta.Location = new System.Drawing.Point(306, 47);
            this.cdtpFechaHasta.MinimumSize = new System.Drawing.Size(4, 35);
            this.cdtpFechaHasta.Name = "cdtpFechaHasta";
            this.cdtpFechaHasta.Size = new System.Drawing.Size(268, 35);
            this.cdtpFechaHasta.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.cdtpFechaHasta.TabIndex = 71;
            this.cdtpFechaHasta.TextColor = System.Drawing.Color.White;
            // 
            // cdtpFechaDesde
            // 
            this.cdtpFechaDesde.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cdtpFechaDesde.BorderSize = 0;
            this.cdtpFechaDesde.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdtpFechaDesde.Location = new System.Drawing.Point(15, 47);
            this.cdtpFechaDesde.MinimumSize = new System.Drawing.Size(4, 35);
            this.cdtpFechaDesde.Name = "cdtpFechaDesde";
            this.cdtpFechaDesde.Size = new System.Drawing.Size(269, 35);
            this.cdtpFechaDesde.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.cdtpFechaDesde.TabIndex = 71;
            this.cdtpFechaDesde.TextColor = System.Drawing.Color.White;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscar.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscar.BorderRadius = 4;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::MenuGerman.Properties.Resources.search_30px;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(219, 98);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(43, 27);
            this.btnBuscar.TabIndex = 71;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblSubTotal.Location = new System.Drawing.Point(470, 480);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(41, 21);
            this.lblSubTotal.TabIndex = 78;
            this.lblSubTotal.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(424, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 77;
            this.label1.Text = "RD$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(326, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 76;
            this.label4.Text = "SubTotal";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblDescuento.Location = new System.Drawing.Point(794, 480);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(41, 21);
            this.lblDescuento.TabIndex = 81;
            this.lblDescuento.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(748, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 80;
            this.label3.Text = "RD$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(651, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 79;
            this.label5.Text = "Descuento";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTotal.Location = new System.Drawing.Point(1066, 480);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 21);
            this.lblTotal.TabIndex = 84;
            this.lblTotal.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label10.Location = new System.Drawing.Point(1019, 480);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 21);
            this.label10.TabIndex = 83;
            this.label10.Text = "RD$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label11.Location = new System.Drawing.Point(965, 480);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 21);
            this.label11.TabIndex = 82;
            this.label11.Text = "Total";
            // 
            // cuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcReportes);
            this.Name = "cuReportes";
            this.Size = new System.Drawing.Size(1152, 564);
            this.tcReportes.ResumeLayout(false);
            this.tpVenta.ResumeLayout(false);
            this.tpVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerVenta)).EndInit();
            this.gbFechas.ResumeLayout(false);
            this.gbFechas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcReportes;
        private System.Windows.Forms.TabPage tpVenta;
        private customButton btnBuscar;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbFechas;
        private customDateTimePicker cdtpFechaHasta;
        private System.Windows.Forms.Label label9;
        private customDateTimePicker cdtpFechaDesde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvVerVenta;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
