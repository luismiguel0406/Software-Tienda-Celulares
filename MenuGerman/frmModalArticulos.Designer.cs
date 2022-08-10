namespace MenuGerman
{
    partial class frmModalArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModalArticulos));
            this.label7 = new System.Windows.Forms.Label();
            this.upperPanelCategoria = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new MenuGerman.customButton();
            this.dgvModalArticulo = new System.Windows.Forms.DataGridView();
            this.seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new MenuGerman.customButton();
            this.btnProcesar = new MenuGerman.customButton();
            this.upperPanelCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label7.Location = new System.Drawing.Point(215, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(486, 21);
            this.label7.TabIndex = 62;
            this.label7.Text = "Seleccione y digite la cantidad a ingresar, Doble click en cantidad.";
            // 
            // upperPanelCategoria
            // 
            this.upperPanelCategoria.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.upperPanelCategoria.Controls.Add(this.label1);
            this.upperPanelCategoria.Controls.Add(this.btnCerrar);
            this.upperPanelCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanelCategoria.Location = new System.Drawing.Point(0, 0);
            this.upperPanelCategoria.Name = "upperPanelCategoria";
            this.upperPanelCategoria.Size = new System.Drawing.Size(1000, 26);
            this.upperPanelCategoria.TabIndex = 63;
            this.upperPanelCategoria.MouseDown += new System.Windows.Forms.MouseEventHandler(this.upperPanelCategoria_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Lista de articulos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackGroundColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BorderColor = System.Drawing.Color.Crimson;
            this.btnCerrar.BorderRadius = 0;
            this.btnCerrar.BorderSize = 0;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = global::MenuGerman.Properties.Resources.Close_thin2_30px;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(963, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(37, 20);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.TextColor = System.Drawing.Color.White;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrar_MouseMove);
            // 
            // dgvModalArticulo
            // 
            this.dgvModalArticulo.AllowUserToAddRows = false;
            this.dgvModalArticulo.AllowUserToDeleteRows = false;
            this.dgvModalArticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModalArticulo.BackgroundColor = System.Drawing.Color.White;
            this.dgvModalArticulo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModalArticulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModalArticulo.ColumnHeadersHeight = 35;
            this.dgvModalArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvModalArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccionar,
            this.cantidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModalArticulo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvModalArticulo.EnableHeadersVisualStyles = false;
            this.dgvModalArticulo.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.dgvModalArticulo.Location = new System.Drawing.Point(12, 130);
            this.dgvModalArticulo.Name = "dgvModalArticulo";
            this.dgvModalArticulo.RowHeadersVisible = false;
            this.dgvModalArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModalArticulo.Size = new System.Drawing.Size(976, 222);
            this.dgvModalArticulo.TabIndex = 64;
            //this.dgvModalArticulo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModalArticulo_CellValueChanged);
            // 
            // seleccionar
            // 
            this.seleccionar.HeaderText = "SEL.";
            this.seleccionar.Name = "seleccionar";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AccessibleName = "";
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(636, 97);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(303, 27);
            this.txtBuscar.TabIndex = 66;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscar.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBuscar.BorderRadius = 4;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.Enabled = false;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::MenuGerman.Properties.Resources.search_30px;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(945, 97);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(43, 27);
            this.btnBuscar.TabIndex = 67;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnProcesar.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnProcesar.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnProcesar.BorderRadius = 15;
            this.btnProcesar.BorderSize = 0;
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Image = global::MenuGerman.Properties.Resources.process_30px;
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesar.Location = new System.Drawing.Point(866, 376);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(122, 46);
            this.btnProcesar.TabIndex = 65;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcesar.TextColor = System.Drawing.Color.White;
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // frmModalArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1000, 443);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.dgvModalArticulo);
            this.Controls.Add(this.upperPanelCategoria);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModalArticulos";
            this.Text = "Añadir Articulos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmModalArticulos_FormClosed);
            this.Load += new System.EventHandler(this.frmModalArticulos_Load);
            this.upperPanelCategoria.ResumeLayout(false);
            this.upperPanelCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel upperPanelCategoria;
        private System.Windows.Forms.Label label1;
        private customButton btnCerrar;
        private System.Windows.Forms.DataGridView dgvModalArticulo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private customButton btnProcesar;
        private System.Windows.Forms.TextBox txtBuscar;
        private customButton btnBuscar;
    }
}