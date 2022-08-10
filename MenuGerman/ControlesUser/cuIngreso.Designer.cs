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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcIngresos = new System.Windows.Forms.TabControl();
            this.tpRealizarIngresos = new System.Windows.Forms.TabPage();
            this.btnEliminar = new MenuGerman.customButton();
            this.btnNuevoIngreso = new MenuGerman.customButton();
            this.gbIngreso = new System.Windows.Forms.GroupBox();
            this.cdtpFecha = new MenuGerman.customDateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtComentario = new System.Windows.Forms.RichTextBox();
            this.btnCancelar = new MenuGerman.customButton();
            this.txtComprobante = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new MenuGerman.customButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvIngreso = new System.Windows.Forms.DataGridView();
            this.tpVerIngresos = new System.Windows.Forms.TabPage();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.gbFechas = new System.Windows.Forms.GroupBox();
            this.cdtpFechaHasta = new MenuGerman.customDateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cdtpFechaDesde = new MenuGerman.customDateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminarIngreso = new MenuGerman.customButton();
            this.btnBuscar = new MenuGerman.customButton();
            this.txtIdIngreso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvVerIngreso = new System.Windows.Forms.DataGridView();
            this.tcIngresos.SuspendLayout();
            this.tpRealizarIngresos.SuspendLayout();
            this.gbIngreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).BeginInit();
            this.tpVerIngresos.SuspendLayout();
            this.gbFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerIngreso)).BeginInit();
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
            this.btnEliminar.Location = new System.Drawing.Point(885, 69);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 40);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // gbIngreso
            // 
            this.gbIngreso.Controls.Add(this.cdtpFecha);
            this.gbIngreso.Controls.Add(this.label7);
            this.gbIngreso.Controls.Add(this.lblTotal);
            this.gbIngreso.Controls.Add(this.label4);
            this.gbIngreso.Controls.Add(this.rtComentario);
            this.gbIngreso.Controls.Add(this.btnCancelar);
            this.gbIngreso.Controls.Add(this.txtComprobante);
            this.gbIngreso.Controls.Add(this.txtIdUsuario);
            this.gbIngreso.Controls.Add(this.label5);
            this.gbIngreso.Controls.Add(this.label1);
            this.gbIngreso.Controls.Add(this.label2);
            this.gbIngreso.Controls.Add(this.btnGuardar);
            this.gbIngreso.Controls.Add(this.label3);
            this.gbIngreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngreso.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.gbIngreso.Location = new System.Drawing.Point(18, 246);
            this.gbIngreso.Name = "gbIngreso";
            this.gbIngreso.Size = new System.Drawing.Size(924, 278);
            this.gbIngreso.TabIndex = 28;
            this.gbIngreso.TabStop = false;
            // 
            // cdtpFecha
            // 
            this.cdtpFecha.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cdtpFecha.BorderSize = 0;
            this.cdtpFecha.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdtpFecha.Enabled = false;
            this.cdtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdtpFecha.Location = new System.Drawing.Point(238, 53);
            this.cdtpFecha.MinimumSize = new System.Drawing.Size(4, 35);
            this.cdtpFecha.Name = "cdtpFecha";
            this.cdtpFecha.Size = new System.Drawing.Size(302, 35);
            this.cdtpFecha.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.cdtpFecha.TabIndex = 32;
            this.cdtpFecha.TextColor = System.Drawing.Color.White;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label7.Location = new System.Drawing.Point(57, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "RD$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTotal.Location = new System.Drawing.Point(103, 236);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 20);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(6, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Total:";
            // 
            // rtComentario
            // 
            this.rtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtComentario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtComentario.Location = new System.Drawing.Point(10, 129);
            this.rtComentario.Name = "rtComentario";
            this.rtComentario.Size = new System.Drawing.Size(887, 81);
            this.rtComentario.TabIndex = 29;
            this.rtComentario.Text = "";
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
            this.btnCancelar.Location = new System.Drawing.Point(778, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 40);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtComprobante
            // 
            this.txtComprobante.AccessibleName = "";
            this.txtComprobante.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComprobante.Location = new System.Drawing.Point(573, 61);
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.Size = new System.Drawing.Size(197, 27);
            this.txtComprobante.TabIndex = 15;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.AccessibleName = "";
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsuario.Location = new System.Drawing.Point(10, 61);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(197, 27);
            this.txtIdUsuario.TabIndex = 15;
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
            this.label1.Location = new System.Drawing.Point(570, 33);
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
            this.btnGuardar.Location = new System.Drawing.Point(635, 225);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 40);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar   ";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // dgvIngreso
            // 
            this.dgvIngreso.AllowUserToAddRows = false;
            this.dgvIngreso.AllowUserToDeleteRows = false;
            this.dgvIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngreso.BackgroundColor = System.Drawing.Color.White;
            this.dgvIngreso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumSlateBlue;
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
            this.dgvIngreso.Size = new System.Drawing.Size(861, 171);
            this.dgvIngreso.TabIndex = 15;
            this.dgvIngreso.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvIngreso_RowsAdded);
            this.dgvIngreso.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvIngreso_RowsRemoved);
            // 
            // tpVerIngresos
            // 
            this.tpVerIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tpVerIngresos.Controls.Add(this.chkFechas);
            this.tpVerIngresos.Controls.Add(this.gbFechas);
            this.tpVerIngresos.Controls.Add(this.btnEliminarIngreso);
            this.tpVerIngresos.Controls.Add(this.btnBuscar);
            this.tpVerIngresos.Controls.Add(this.txtIdIngreso);
            this.tpVerIngresos.Controls.Add(this.label6);
            this.tpVerIngresos.Controls.Add(this.dgvVerIngreso);
            this.tpVerIngresos.Location = new System.Drawing.Point(4, 30);
            this.tpVerIngresos.Name = "tpVerIngresos";
            this.tpVerIngresos.Padding = new System.Windows.Forms.Padding(3);
            this.tpVerIngresos.Size = new System.Drawing.Size(1144, 530);
            this.tpVerIngresos.TabIndex = 1;
            this.tpVerIngresos.Text = "Ver Ingresos";
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFechas.Location = new System.Drawing.Point(420, 65);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(15, 14);
            this.chkFechas.TabIndex = 73;
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
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
            this.gbFechas.Location = new System.Drawing.Point(420, 74);
            this.gbFechas.Name = "gbFechas";
            this.gbFechas.Size = new System.Drawing.Size(566, 106);
            this.gbFechas.TabIndex = 72;
            this.gbFechas.TabStop = false;
            this.gbFechas.Text = "Por fechas";
            // 
            // cdtpFechaHasta
            // 
            this.cdtpFechaHasta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cdtpFechaHasta.BorderSize = 0;
            this.cdtpFechaHasta.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdtpFechaHasta.Location = new System.Drawing.Point(291, 47);
            this.cdtpFechaHasta.MinimumSize = new System.Drawing.Size(4, 35);
            this.cdtpFechaHasta.Name = "cdtpFechaHasta";
            this.cdtpFechaHasta.Size = new System.Drawing.Size(263, 35);
            this.cdtpFechaHasta.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.cdtpFechaHasta.TabIndex = 71;
            this.cdtpFechaHasta.TextColor = System.Drawing.Color.White;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(287, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "Hasta:";
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
            this.cdtpFechaDesde.Size = new System.Drawing.Size(263, 35);
            this.cdtpFechaDesde.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.cdtpFechaDesde.TabIndex = 71;
            this.cdtpFechaDesde.TextColor = System.Drawing.Color.White;
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
            // btnEliminarIngreso
            // 
            this.btnEliminarIngreso.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarIngreso.BackGroundColor = System.Drawing.Color.Crimson;
            this.btnEliminarIngreso.BorderColor = System.Drawing.Color.Crimson;
            this.btnEliminarIngreso.BorderRadius = 15;
            this.btnEliminarIngreso.BorderSize = 0;
            this.btnEliminarIngreso.FlatAppearance.BorderSize = 0;
            this.btnEliminarIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarIngreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminarIngreso.ForeColor = System.Drawing.Color.White;
            this.btnEliminarIngreso.Image = global::MenuGerman.Properties.Resources.Delete_30px;
            this.btnEliminarIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarIngreso.Location = new System.Drawing.Point(1008, 113);
            this.btnEliminarIngreso.Name = "btnEliminarIngreso";
            this.btnEliminarIngreso.Size = new System.Drawing.Size(119, 40);
            this.btnEliminarIngreso.TabIndex = 69;
            this.btnEliminarIngreso.Text = "Eliminar";
            this.btnEliminarIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarIngreso.TextColor = System.Drawing.Color.White;
            this.btnEliminarIngreso.UseVisualStyleBackColor = false;
            this.btnEliminarIngreso.Click += new System.EventHandler(this.btnEliminarIngreso_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(222, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(43, 27);
            this.btnBuscar.TabIndex = 68;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdIngreso
            // 
            this.txtIdIngreso.AccessibleName = "";
            this.txtIdIngreso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdIngreso.Location = new System.Drawing.Point(19, 86);
            this.txtIdIngreso.Name = "txtIdIngreso";
            this.txtIdIngreso.Size = new System.Drawing.Size(197, 27);
            this.txtIdIngreso.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(15, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Id Ingreso";
            // 
            // dgvVerIngreso
            // 
            this.dgvVerIngreso.AllowUserToAddRows = false;
            this.dgvVerIngreso.AllowUserToDeleteRows = false;
            this.dgvVerIngreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerIngreso.BackgroundColor = System.Drawing.Color.White;
            this.dgvVerIngreso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerIngreso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVerIngreso.ColumnHeadersHeight = 35;
            this.dgvVerIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerIngreso.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVerIngreso.EnableHeadersVisualStyles = false;
            this.dgvVerIngreso.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvVerIngreso.Location = new System.Drawing.Point(18, 186);
            this.dgvVerIngreso.Name = "dgvVerIngreso";
            this.dgvVerIngreso.ReadOnly = true;
            this.dgvVerIngreso.RowHeadersVisible = false;
            this.dgvVerIngreso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerIngreso.Size = new System.Drawing.Size(1109, 338);
            this.dgvVerIngreso.TabIndex = 15;
            this.dgvVerIngreso.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerIngreso_CellDoubleClick);
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
            this.gbIngreso.ResumeLayout(false);
            this.gbIngreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngreso)).EndInit();
            this.tpVerIngresos.ResumeLayout(false);
            this.tpVerIngresos.PerformLayout();
            this.gbFechas.ResumeLayout(false);
            this.gbFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerIngreso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcIngresos;
        private System.Windows.Forms.TabPage tpRealizarIngresos;
        private System.Windows.Forms.TabPage tpVerIngresos;
        private System.Windows.Forms.DataGridView dgvVerIngreso;
        private System.Windows.Forms.DataGridView dgvIngreso;
        private System.Windows.Forms.GroupBox gbIngreso;
        private customButton btnCancelar;
        private System.Windows.Forms.TextBox txtComprobante;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private customButton btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtComentario;
        private customButton btnNuevoIngreso;
        private customButton btnEliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdIngreso;
        private System.Windows.Forms.Label label6;
        private customButton btnBuscar;
        private customButton btnEliminarIngreso;
        private System.Windows.Forms.Label label7;
        private customDateTimePicker cdtpFecha;
        private customDateTimePicker cdtpFechaDesde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbFechas;
        private System.Windows.Forms.CheckBox chkFechas;
        private customDateTimePicker cdtpFechaHasta;
        private System.Windows.Forms.Label label9;
    }
}
