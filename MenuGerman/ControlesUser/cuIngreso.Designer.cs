namespace MenuGerman.ControlesUser
{
    partial class cuIngreso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcIngresos = new System.Windows.Forms.TabControl();
            this.tpRealizarIngresos = new System.Windows.Forms.TabPage();
            this.tpVerIngresos = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.dgvIngreso = new System.Windows.Forms.DataGridView();
            this.gbIngreso = new System.Windows.Forms.GroupBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new MenuGerman.customButton();
            this.btnGuardar = new MenuGerman.customButton();
            this.rtDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnNuevoIngreso = new MenuGerman.customButton();
            this.btnEliminar = new MenuGerman.customButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tcIngresos.SuspendLayout();
            this.tpRealizarIngresos.SuspendLayout();
            this.tpVerIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).BeginInit();
            this.gbIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcIngresos
            // 
            this.tcIngresos.Controls.Add(this.tpRealizarIngresos);
            this.tcIngresos.Controls.Add(this.tpVerIngresos);
            this.tcIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcIngresos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcIngresos.HotTrack = true;
            this.tcIngresos.Location = new System.Drawing.Point(0, 0);
            this.tcIngresos.Name = "tcIngresos";
            this.tcIngresos.SelectedIndex = 0;
            this.tcIngresos.Size = new System.Drawing.Size(1152, 564);
            this.tcIngresos.TabIndex = 0;
            // 
            // tpRealizarIngresos
            // 
            this.tpRealizarIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tpRealizarIngresos.Controls.Add(this.btnEliminar);
            this.tpRealizarIngresos.Controls.Add(this.btnNuevoIngreso);
            this.tpRealizarIngresos.Controls.Add(this.gbIngreso);
            this.tpRealizarIngresos.Controls.Add(this.dgvIngreso);
            this.tpRealizarIngresos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpRealizarIngresos.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tpRealizarIngresos.Location = new System.Drawing.Point(4, 30);
            this.tpRealizarIngresos.Name = "tpRealizarIngresos";
            this.tpRealizarIngresos.Padding = new System.Windows.Forms.Padding(3);
            this.tpRealizarIngresos.Size = new System.Drawing.Size(1144, 530);
            this.tpRealizarIngresos.TabIndex = 0;
            this.tpRealizarIngresos.Text = "Ingresos";
            // 
            // tpVerIngresos
            // 
            this.tpVerIngresos.Controls.Add(this.dgvUsuarios);
            this.tpVerIngresos.Location = new System.Drawing.Point(4, 30);
            this.tpVerIngresos.Name = "tpVerIngresos";
            this.tpVerIngresos.Padding = new System.Windows.Forms.Padding(3);
            this.tpVerIngresos.Size = new System.Drawing.Size(1144, 530);
            this.tpVerIngresos.TabIndex = 1;
            this.tpVerIngresos.Text = "Ver Ingresos";
            this.tpVerIngresos.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.ColumnHeadersHeight = 35;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvUsuarios.Location = new System.Drawing.Point(6, 222);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1132, 302);
            this.dgvUsuarios.TabIndex = 15;
            // 
            // dgvIngreso
            // 
            this.dgvIngreso.AllowUserToAddRows = false;
            this.dgvIngreso.AllowUserToDeleteRows = false;
            this.dgvIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngreso.BackgroundColor = System.Drawing.Color.White;
            this.dgvIngreso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIngreso.ColumnHeadersHeight = 35;
            this.dgvIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngreso.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIngreso.EnableHeadersVisualStyles = false;
            this.dgvIngreso.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvIngreso.Location = new System.Drawing.Point(18, 69);
            this.dgvIngreso.Name = "dgvIngreso";
            this.dgvIngreso.ReadOnly = true;
            this.dgvIngreso.RowHeadersVisible = false;
            this.dgvIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngreso.Size = new System.Drawing.Size(683, 171);
            this.dgvIngreso.TabIndex = 15;
            // 
            // gbIngreso
            // 
            this.gbIngreso.Controls.Add(this.lblTotal);
            this.gbIngreso.Controls.Add(this.label4);
            this.gbIngreso.Controls.Add(this.rtDescripcion);
            this.gbIngreso.Controls.Add(this.dtpFecha);
            this.gbIngreso.Controls.Add(this.btnCancelar);
            this.gbIngreso.Controls.Add(this.txtContrasena);
            this.gbIngreso.Controls.Add(this.txtUsuario);
            this.gbIngreso.Controls.Add(this.label5);
            this.gbIngreso.Controls.Add(this.label1);
            this.gbIngreso.Controls.Add(this.label2);
            this.gbIngreso.Controls.Add(this.btnGuardar);
            this.gbIngreso.Controls.Add(this.label3);
            this.gbIngreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngreso.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.gbIngreso.Location = new System.Drawing.Point(18, 246);
            this.gbIngreso.Name = "gbIngreso";
            this.gbIngreso.Size = new System.Drawing.Size(755, 278);
            this.gbIngreso.TabIndex = 28;
            this.gbIngreso.TabStop = false;
            // 
            // txtContrasena
            // 
            this.txtContrasena.AccessibleName = "";
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(461, 58);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '.';
            this.txtContrasena.Size = new System.Drawing.Size(197, 27);
            this.txtContrasena.TabIndex = 15;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AccessibleName = "";
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(10, 58);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(197, 27);
            this.txtUsuario.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(457, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Comprobante NCF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(234, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Comentario";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpFecha.CalendarTitleForeColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpFecha.Location = new System.Drawing.Point(238, 56);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(197, 29);
            this.dtpFecha.TabIndex = 29;
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
            this.btnCancelar.Location = new System.Drawing.Point(619, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 40);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BorderRadius = 15;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::MenuGerman.Properties.Resources.save_30px;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(476, 225);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 40);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar   ";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // rtDescripcion
            // 
            this.rtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtDescripcion.Location = new System.Drawing.Point(10, 129);
            this.rtDescripcion.Name = "rtDescripcion";
            this.rtDescripcion.Size = new System.Drawing.Size(728, 81);
            this.rtDescripcion.TabIndex = 29;
            this.rtDescripcion.Text = "";
            // 
            // btnNuevoIngreso
            // 
            this.btnNuevoIngreso.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNuevoIngreso.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNuevoIngreso.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNuevoIngreso.BorderRadius = 4;
            this.btnNuevoIngreso.BorderSize = 0;
            this.btnNuevoIngreso.FlatAppearance.BorderSize = 0;
            this.btnNuevoIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoIngreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNuevoIngreso.ForeColor = System.Drawing.Color.White;
            this.btnNuevoIngreso.Image = global::MenuGerman.Properties.Resources.add_30px;
            this.btnNuevoIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoIngreso.Location = new System.Drawing.Point(18, 23);
            this.btnNuevoIngreso.Name = "btnNuevoIngreso";
            this.btnNuevoIngreso.Size = new System.Drawing.Size(163, 40);
            this.btnNuevoIngreso.TabIndex = 30;
            this.btnNuevoIngreso.Text = "Nuevo ingreso";
            this.btnNuevoIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoIngreso.TextColor = System.Drawing.Color.White;
            this.btnNuevoIngreso.UseVisualStyleBackColor = false;
            this.btnNuevoIngreso.Click += new System.EventHandler(this.btnNuevoIngreso_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.BackGroundColor = System.Drawing.Color.Crimson;
            this.btnEliminar.BorderColor = System.Drawing.Color.Crimson;
            this.btnEliminar.BorderRadius = 4;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::MenuGerman.Properties.Resources.Delete_30px;
            this.btnEliminar.Location = new System.Drawing.Point(716, 69);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 40);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(56, 236);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 20);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "0.00";
            // 
            // cuIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcIngresos);
            this.Name = "cuIngreso";
            this.Size = new System.Drawing.Size(1152, 564);
            this.tcIngresos.ResumeLayout(false);
            this.tpRealizarIngresos.ResumeLayout(false);
            this.tpVerIngresos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).EndInit();
            this.gbIngreso.ResumeLayout(false);
            this.gbIngreso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcIngresos;
        private System.Windows.Forms.TabPage tpRealizarIngresos;
        private System.Windows.Forms.TabPage tpVerIngresos;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridView dgvIngreso;
        private System.Windows.Forms.GroupBox gbIngreso;
        private customButton btnCancelar;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private customButton btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.RichTextBox rtDescripcion;
        private customButton btnNuevoIngreso;
        private customButton btnEliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
    }
}
