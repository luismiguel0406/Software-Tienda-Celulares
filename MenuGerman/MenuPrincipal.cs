using CapaNegocio;
using MenuGerman.ControlesUser;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Utilidades;

namespace MenuGerman
{
    public partial class MenuPrincipal : Form
    {
        private login _frmLogin;
        public MenuPrincipal(login frmLogin )
        {   _frmLogin = frmLogin;
            InitializeComponent();
        }
        public MenuPrincipal()
        {
            InitializeComponent();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public MenuStrip cargaMenuDinamico(MenuStrip menuStrip, int tipoMenu)
        {
            int numQuery = 1;

            menuDinamicoDTO menu = new menuDinamicoDTO();
            DataTable tablaMenu = menu.menuDinamico(numQuery, tipoMenu, null);

            foreach (DataRow itemMenuRow in tablaMenu.Rows)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem();
                menuItem.Text = itemMenuRow["NOMBRE"].ToString();

                numQuery = 2;
                DataTable tablaSubMenu = menu.menuDinamico(numQuery, tipoMenu, Convert.ToInt32(itemMenuRow["ID"]));

                foreach (DataRow itemSubMenuRow in tablaSubMenu.Rows)
                {
                    ToolStripMenuItem subMenuItem = new ToolStripMenuItem();
                    subMenuItem.Text = itemSubMenuRow["NOMBRE"].ToString();

                    menuItem.DropDownItems.Add(subMenuItem);
                }

                menuStrip.Items.Add(menuItem);

            }

            return menuStrip;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
           // MainMenuStrip = cargaMenuDinamico(msMenu, 1);
            //label1.Text = GlobalClass.Usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
                FrmArticulos frmarticulos = new FrmArticulos();
                frmarticulos.ShowDialog();                                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            frmCategoria frmCategoria = new frmCategoria();
            frmCategoria.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (GlobalClass.administrador(GlobalClass.idRol, GlobalClass.rol))
            {
                frmPersona frmPersona = new frmPersona();
                frmPersona.ShowDialog();
                return;
            }
            MessageBox.Show("Debe ser administrador para usar esta opcion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (GlobalClass.administrador(GlobalClass.idRol, GlobalClass.rol))
            {
                frmRol frmRol = new frmRol();
                frmRol.ShowDialog();
                return;
            }
            MessageBox.Show("Debe ser administrador para usar esta opcion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (GlobalClass.administrador(GlobalClass.idRol, GlobalClass.rol))
            {
                frmUsuario frmUsuario = new frmUsuario();
                frmUsuario.ShowDialog();
                return;
            }
            MessageBox.Show("Debe ser administrador para usar esta opcion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

              
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmIngreso frmIngreso = new frmIngreso();
            frmIngreso.ShowDialog();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmLogin.Show();

        }

        private void upPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnArticulosMenu_Click(object sender, EventArgs e)
        {
            cuArticulo cu = new cuArticulo();
            this.mainPanel.Controls.Add(cu);
           
        }
    }
}
