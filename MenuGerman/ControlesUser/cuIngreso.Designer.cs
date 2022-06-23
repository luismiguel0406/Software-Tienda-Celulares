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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcIngresos = new System.Windows.Forms.TabControl();
            this.tpRealizarIngresos = new System.Windows.Forms.TabPage();
            this.tpVerIngresos = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbIngreso = new System.Windows.Forms.GroupBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new MenuGerman.customButton();
            this.btnGuardar = new MenuGerman.customButton();
            this.rtDescripcion = new System.Windows.Forms.RichTextBox();
            this.tcIngresos.SuspendLayout();
            this.tpRealizarIngresos.SuspendLayout();
            this.tpVerIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tpRealizarIngresos.Controls.Add(this.gbIngreso);
            this.tpRealizarIngresos.Controls.Add(this.dataGridView1);
            this.tpRealizarIngresos.Controls.Add(this.cbEstado);
            this.tpRealizarIngresos.Controls.Add(this.label4);
            this.tpRealizarIngresos.Controls.Add(this.label6);
            this.tpRealizarIngresos.Controls.Add(this.cbRol);
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvUsuarios.ColumnHeadersHeight = 35;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle16;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridView1.Location = new System.Drawing.Point(6, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1132, 188);
            this.dataGridView1.TabIndex = 15;
            // 
            // gbIngreso
            // 
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
            this.gbIngreso.Location = new System.Drawing.Point(6, 16);
            this.gbIngreso.Name = "gbIngreso";
            this.gbIngreso.Size = new System.Drawing.Size(550, 296);
            this.gbIngreso.TabIndex = 28;
            this.gbIngreso.TabStop = false;
            this.gbIngreso.Text = "Nuevo Ingreso";
            // 
            // txtContrasena
            // 
            this.txtContrasena.AccessibleName = "";
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(10, 195);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '.';
            this.txtContrasena.Size = new System.Drawing.Size(226, 27);
            this.txtContrasena.TabIndex = 15;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AccessibleName = "";
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(10, 56);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(226, 27);
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
            this.label1.Location = new System.Drawing.Point(6, 171);
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
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha";
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(700, 205);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(226, 28);
            this.cbRol.TabIndex = 20;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(700, 274);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(226, 28);
            this.cbEstado.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(696, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(283, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Comentario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(696, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Rol";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpFecha.CalendarTitleForeColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpFecha.Location = new System.Drawing.Point(10, 125);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(226, 29);
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
            this.btnCancelar.Location = new System.Drawing.Point(410, 250);
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
            this.btnGuardar.Location = new System.Drawing.Point(271, 250);
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
            this.rtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtDescripcion.Location = new System.Drawing.Point(287, 56);
            this.rtDescripcion.Name = "rtDescripcion";
            this.rtDescripcion.Size = new System.Drawing.Size(205, 107);
            this.rtDescripcion.TabIndex = 29;
            this.rtDescripcion.Text = "";
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
            this.tpRealizarIngresos.PerformLayout();
            this.tpVerIngresos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbIngreso.ResumeLayout(false);
            this.gbIngreso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcIngresos;
        private System.Windows.Forms.TabPage tpRealizarIngresos;
        private System.Windows.Forms.TabPage tpVerIngresos;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbIngreso;
        private customButton btnCancelar;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private customButton btnGuardar;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.RichTextBox rtDescripcion;
    }
}
