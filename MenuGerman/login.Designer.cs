namespace MenuGerman
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInicioSesion = new MenuGerman.customButton();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbEmpresa = new System.Windows.Forms.PictureBox();
            this.pbContraseña = new System.Windows.Forms.PictureBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrarLogin = new MenuGerman.customButton();
            this.upperPanelCategoria = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCerrar = new MenuGerman.customButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.upperPanelCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(77, 211);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(241, 27);
            this.txtContraseña.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(77, 158);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(241, 27);
            this.txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 6;
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInicioSesion.BackGroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInicioSesion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInicioSesion.BorderRadius = 15;
            this.btnInicioSesion.BorderSize = 0;
            this.btnInicioSesion.FlatAppearance.BorderSize = 0;
            this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnInicioSesion.ForeColor = System.Drawing.Color.White;
            this.btnInicioSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicioSesion.Location = new System.Drawing.Point(77, 326);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(241, 40);
            this.btnInicioSesion.TabIndex = 22;
            this.btnInicioSesion.Text = "Inicio Sesion";
            this.btnInicioSesion.TextColor = System.Drawing.Color.White;
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cbEmpresa.Location = new System.Drawing.Point(77, 268);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(241, 28);
            this.cbEmpresa.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MenuGerman.Properties.Resources.inicio;
            this.pictureBox1.Location = new System.Drawing.Point(156, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pbEmpresa
            // 
            this.pbEmpresa.BackgroundImage = global::MenuGerman.Properties.Resources.enterprise_resource_planning_24px;
            this.pbEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbEmpresa.Location = new System.Drawing.Point(34, 268);
            this.pbEmpresa.Name = "pbEmpresa";
            this.pbEmpresa.Size = new System.Drawing.Size(37, 28);
            this.pbEmpresa.TabIndex = 7;
            this.pbEmpresa.TabStop = false;
            // 
            // pbContraseña
            // 
            this.pbContraseña.BackgroundImage = global::MenuGerman.Properties.Resources.key_24px;
            this.pbContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbContraseña.Location = new System.Drawing.Point(34, 211);
            this.pbContraseña.Name = "pbContraseña";
            this.pbContraseña.Size = new System.Drawing.Size(37, 27);
            this.pbContraseña.TabIndex = 7;
            this.pbContraseña.TabStop = false;
            // 
            // pbUsuario
            // 
            this.pbUsuario.BackgroundImage = global::MenuGerman.Properties.Resources.user_24px;
            this.pbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUsuario.Location = new System.Drawing.Point(34, 158);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(37, 27);
            this.pbUsuario.TabIndex = 7;
            this.pbUsuario.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "Empresa";
            // 
            // btnCerrarLogin
            // 
            this.btnCerrarLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarLogin.BackGroundColor = System.Drawing.Color.Transparent;
            this.btnCerrarLogin.BorderColor = System.Drawing.Color.Crimson;
            this.btnCerrarLogin.BorderRadius = 0;
            this.btnCerrarLogin.BorderSize = 0;
            this.btnCerrarLogin.FlatAppearance.BorderSize = 0;
            this.btnCerrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrarLogin.ForeColor = System.Drawing.Color.White;
            this.btnCerrarLogin.Image = global::MenuGerman.Properties.Resources.Close_thin2_30px;
            this.btnCerrarLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarLogin.Location = new System.Drawing.Point(337, 2);
            this.btnCerrarLogin.Name = "btnCerrarLogin";
            this.btnCerrarLogin.Size = new System.Drawing.Size(40, 27);
            this.btnCerrarLogin.TabIndex = 53;
            this.btnCerrarLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarLogin.TextColor = System.Drawing.Color.White;
            this.btnCerrarLogin.UseVisualStyleBackColor = false;
            this.btnCerrarLogin.MouseLeave += new System.EventHandler(this.btnCerrarLogin_MouseLeave);
            this.btnCerrarLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrarLogin_MouseMove);
            // 
            // upperPanelCategoria
            // 
            this.upperPanelCategoria.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.upperPanelCategoria.Controls.Add(this.label5);
            this.upperPanelCategoria.Controls.Add(this.btnCerrarLogin);
            this.upperPanelCategoria.Controls.Add(this.btnCerrar);
            this.upperPanelCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanelCategoria.Location = new System.Drawing.Point(0, 0);
            this.upperPanelCategoria.Name = "upperPanelCategoria";
            this.upperPanelCategoria.Size = new System.Drawing.Size(380, 29);
            this.upperPanelCategoria.TabIndex = 64;
            this.upperPanelCategoria.MouseDown += new System.Windows.Forms.MouseEventHandler(this.upperPanelCategoria_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(19, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 49;
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
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(380, 421);
            this.Controls.Add(this.upperPanelCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEmpresa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.pbEmpresa);
            this.Controls.Add(this.pbContraseña);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContraseña);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.upperPanelCategoria.ResumeLayout(false);
            this.upperPanelCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.PictureBox pbContraseña;
        private customButton btnInicioSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.PictureBox pbEmpresa;
        private System.Windows.Forms.Label label4;
        private customButton btnCerrarLogin;
        private System.Windows.Forms.Panel upperPanelCategoria;
        private System.Windows.Forms.Label label5;
        private customButton btnCerrar;
    }
}