﻿using CapaDeDatos.Models;
using CapaNegocio;
using CapaNegocio.DTO;
using MenuGerman.ControlesUser;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Utilidades;

namespace MenuGerman
{
    public partial class MenuPrincipal : Form
    {   Usuario usuarioModel = new Usuario();
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
            lblUsuario.Text = GlobalClass.Usuario;
            if (GlobalClass.idRol == 3)
            {
                btnUsuarioMenu.Enabled = false;
                btnIngresoMenu.Enabled = false;
                btnArticulosMenu.Enabled = false;
            }
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmLogin.Show();

        }

        private void upPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

     

        private void btnArticulosMenu_Click(object sender, EventArgs e)
        {
            cuArticulo articulos = new cuArticulo();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(articulos);
           
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogo = MessageBox.Show("Desea salir de la aplicación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {                   
                    Close();
                }
               
            }
            catch (Exception)
            {

                return;
            }   

        }
        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Crimson;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Transparent;
        }

        private void btnIngresoMenu_Click(object sender, EventArgs e)
        {
            cuIngreso ingreso = new cuIngreso();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(ingreso);
        }

        private void btnUsuarioMenu_Click(object sender, EventArgs e)
        {
            cuUsuarios usuario = new cuUsuarios();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(usuario);
        }

        private void btnVentasMenu_Click(object sender, EventArgs e)
        {
            cuVenta venta = new cuVenta();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(venta);
        }

        private void btnReportesMenu_Click(object sender, EventArgs e)
        {
            cuReportes reportes = new cuReportes();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(reportes);
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            usuarioModel.idUsuario = GlobalClass.idUsuario;
            usuarioModel.empresa = GlobalClass.empresa;
            UsuariosDTO.MantenimientoUsuario(usuarioModel, GlobalClass.setOffLine);
            MessageBox.Show($"{ GlobalClass.Usuario} ha cerrado sesión", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
