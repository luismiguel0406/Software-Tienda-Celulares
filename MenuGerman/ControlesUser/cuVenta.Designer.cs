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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.btnFacturar = new MenuGerman.customButton();
            this.btnCancelar = new MenuGerman.customButton();
            this.gbTotales = new System.Windows.Forms.GroupBox();
            this.btnAgregarArticulo = new MenuGerman.customButton();
            this.btnEliminarArticulo = new MenuGerman.customButton();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVenta.ColumnHeadersHeight = 35;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVenta.EnableHeadersVisualStyles = false;
            this.dgvVenta.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvVenta.Location = new System.Drawing.Point(15, 316);
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.RowHeadersVisible = false;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size = new System.Drawing.Size(628, 212);
            this.dgvVenta.TabIndex = 16;
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
            this.btnFacturar.Location = new System.Drawing.Point(294, 152);
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
            this.btnCancelar.Location = new System.Drawing.Point(154, 200);
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
            this.gbTotales.Controls.Add(this.btnFacturar);
            this.gbTotales.Controls.Add(this.btnCancelar);
            this.gbTotales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotales.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.gbTotales.Location = new System.Drawing.Point(685, 271);
            this.gbTotales.Name = "gbTotales";
            this.gbTotales.Size = new System.Drawing.Size(441, 257);
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
            this.btnAgregarArticulo.Location = new System.Drawing.Point(15, 258);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(119, 40);
            this.btnAgregarArticulo.TabIndex = 31;
            this.btnAgregarArticulo.Text = "Articulos";
            this.btnAgregarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarArticulo.TextColor = System.Drawing.Color.White;
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
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
            this.btnEliminarArticulo.Location = new System.Drawing.Point(586, 270);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(57, 40);
            this.btnEliminarArticulo.TabIndex = 32;
            this.btnEliminarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarArticulo.TextColor = System.Drawing.Color.White;
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.AccessibleName = "";
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(15, 69);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(197, 27);
            this.txtIdUsuario.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(11, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Usuario";
            // 
            // cuVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.gbTotales);
            this.Controls.Add(this.dgvVenta);
            this.Name = "cuVenta";
            this.Size = new System.Drawing.Size(1152, 564);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.gbTotales.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label5;
    }
}
