namespace MenuGerman.ControlesUser
{
    partial class cuVenta
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
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.btnFacturar = new MenuGerman.customButton();
            this.btnCancelar = new MenuGerman.customButton();
            this.gbTotales = new System.Windows.Forms.GroupBox();
            this.btnAgregarArticulo = new MenuGerman.customButton();
            this.btnEliminarArticulo = new MenuGerman.customButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblItbis = new System.Windows.Forms.Label();
            this.lblDescuentos = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.rtComentario = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.gbTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.AllowUserToDeleteRows = false;
            this.dgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVenta.ColumnHeadersHeight = 35;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVenta.EnableHeadersVisualStyles = false;
            this.dgvVenta.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvVenta.Location = new System.Drawing.Point(15, 109);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.RowHeadersVisible = false;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size = new System.Drawing.Size(628, 212);
            this.dgvVenta.TabIndex = 16;
            this.dgvVenta.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvVenta_RowsAdded);
            this.dgvVenta.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvVenta_RowsRemoved);
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFacturar.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFacturar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFacturar.BorderRadius = 15;
            this.btnFacturar.BorderSize = 0;
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.Image = global::MenuGerman.Properties.Resources.deposit_64px;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.Location = new System.Drawing.Point(294, 231);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(141, 88);
            this.btnFacturar.TabIndex = 24;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacturar.TextColor = System.Drawing.Color.White;
            this.btnFacturar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.BackGroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.BorderRadius = 15;
            this.btnCancelar.BorderSize = 1;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.Image = global::MenuGerman.Properties.Resources.cancel_purple_30px;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(154, 279);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 40);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // gbTotales
            // 
            this.gbTotales.Controls.Add(this.lblTotal);
            this.gbTotales.Controls.Add(this.lblItbis);
            this.gbTotales.Controls.Add(this.lblDescuentos);
            this.gbTotales.Controls.Add(this.lblSubTotal);
            this.gbTotales.Controls.Add(this.label9);
            this.gbTotales.Controls.Add(this.label8);
            this.gbTotales.Controls.Add(this.label7);
            this.gbTotales.Controls.Add(this.label6);
            this.gbTotales.Controls.Add(this.label4);
            this.gbTotales.Controls.Add(this.label3);
            this.gbTotales.Controls.Add(this.label2);
            this.gbTotales.Controls.Add(this.label1);
            this.gbTotales.Controls.Add(this.btnFacturar);
            this.gbTotales.Controls.Add(this.btnCancelar);
            this.gbTotales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotales.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.gbTotales.Location = new System.Drawing.Point(685, 203);
            this.gbTotales.Name = "gbTotales";
            this.gbTotales.Size = new System.Drawing.Size(441, 325);
            this.gbTotales.TabIndex = 25;
            this.gbTotales.TabStop = false;
            this.gbTotales.Text = "Detalle";
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregarArticulo.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregarArticulo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregarArticulo.BorderRadius = 4;
            this.btnAgregarArticulo.BorderSize = 0;
            this.btnAgregarArticulo.FlatAppearance.BorderSize = 0;
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregarArticulo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarArticulo.Image = global::MenuGerman.Properties.Resources.add_30px;
            this.btnAgregarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(15, 43);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(119, 40);
            this.btnAgregarArticulo.TabIndex = 31;
            this.btnAgregarArticulo.Text = "Articulos";
            this.btnAgregarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarArticulo.TextColor = System.Drawing.Color.White;
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarArticulo.BackGroundColor = System.Drawing.Color.Crimson;
            this.btnEliminarArticulo.BorderColor = System.Drawing.Color.Crimson;
            this.btnEliminarArticulo.BorderRadius = 4;
            this.btnEliminarArticulo.BorderSize = 0;
            this.btnEliminarArticulo.FlatAppearance.BorderSize = 0;
            this.btnEliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarArticulo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarArticulo.Image = global::MenuGerman.Properties.Resources.Delete_30px;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(649, 109);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(57, 40);
            this.btnEliminarArticulo.TabIndex = 32;
            this.btnEliminarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarArticulo.TextColor = System.Drawing.Color.White;
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Sub Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Descuentos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Itbis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(126, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "RD$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(126, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "RD$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(126, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "RD$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label9.Location = new System.Drawing.Point(126, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "RD$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTotal.Location = new System.Drawing.Point(172, 146);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 21);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "0.00";
            // 
            // lblItbis
            // 
            this.lblItbis.AutoSize = true;
            this.lblItbis.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItbis.Location = new System.Drawing.Point(172, 109);
            this.lblItbis.Name = "lblItbis";
            this.lblItbis.Size = new System.Drawing.Size(40, 21);
            this.lblItbis.TabIndex = 28;
            this.lblItbis.Text = "0.00";
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescuentos.Location = new System.Drawing.Point(172, 72);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(40, 21);
            this.lblDescuentos.TabIndex = 29;
            this.lblDescuentos.Text = "0.00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSubTotal.Location = new System.Drawing.Point(172, 35);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(40, 21);
            this.lblSubTotal.TabIndex = 30;
            this.lblSubTotal.Text = "0.00";
            // 
            // rtComentario
            // 
            this.rtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtComentario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtComentario.Location = new System.Drawing.Point(15, 447);
            this.rtComentario.Name = "rtComentario";
            this.rtComentario.Size = new System.Drawing.Size(628, 81);
            this.rtComentario.TabIndex = 36;
            this.rtComentario.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(11, 424);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "Comentario";
            // 
            // cuVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtComentario);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.gbTotales);
            this.Controls.Add(this.dgvVenta);
            this.Name = "cuVenta";
            this.Size = new System.Drawing.Size(1152, 564);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.gbTotales.ResumeLayout(false);
            this.gbTotales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVenta;
        private customButton btnCancelar;
        private customButton btnFacturar;
        private System.Windows.Forms.GroupBox gbTotales;
        private customButton btnAgregarArticulo;
        private customButton btnEliminarArticulo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblItbis;
        private System.Windows.Forms.Label lblDescuentos;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtComentario;
        private System.Windows.Forms.Label label14;
    }
}
