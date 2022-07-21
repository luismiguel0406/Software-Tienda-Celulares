using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDatos.Models;
using CapaNegocio;
using CapaNegocio.DTO;
using Utilidades;

namespace MenuGerman
{
    public partial class login : Form
    { Usuario usuarioModel = new Usuario();
        Empresa empresaModel = new Empresa();
        public login()
        {
            InitializeComponent();
           
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnInicioSesion_MouseMove(object sender, MouseEventArgs e)
        {
            btnInicioSesion.BackColor = Color.Green;
            btnInicioSesion.ForeColor = Color.White;
        }

        private void btnInicioSesion_MouseLeave(object sender, EventArgs e)
        {
            btnInicioSesion.BackColor = Color.White;
            btnInicioSesion.ForeColor = Color.Black;
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {

            usuarioModel.password = Encryptar.encrypta(txtContraseña.Text.Trim());
            usuarioModel.usuario = txtUsuario.Text.Trim();
            usuarioModel.empresa = Convert.ToInt32(cbEmpresa.SelectedValue);
            var usuarioValido = UsuariosDTO.MantenimientoUsuario(usuarioModel, GlobalClass.Login);

            if (usuarioValido.Rows.Count == 0)
            {
                MessageBox.Show("Usuario Invalido, intente de nuevo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GlobalClass.limpiar(this);

            foreach (DataRow item in usuarioValido.Rows)
            {
                GlobalClass.Usuario = item["USUARIO"].ToString();
                GlobalClass.idUsuario = Convert.ToInt32(item["IDUSUARIO"]);
                GlobalClass.rol = item["ROL"].ToString();
                GlobalClass.idRol = Convert.ToInt32(item["IDROL"]);
                GlobalClass.empresa = Convert.ToInt32(item["EMPRESA"]);
            }

            usuarioModel.idUsuario = GlobalClass.idUsuario;
            UsuariosDTO.MantenimientoUsuario(usuarioModel, GlobalClass.setOnLine);


            MessageBox.Show($"Bienvenido: {GlobalClass.Usuario}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();

            login frmLogin = this;
            MenuPrincipal frmMenu = new MenuPrincipal(frmLogin);
            frmMenu.ShowDialog();

        }

        private void login_Load(object sender, EventArgs e)
        {
            comboBoxEmpresa();
        }
        private void comboBoxEmpresa()
        {
            DataTable dt = EmpresaDTO.MantenimientoEmpresa(empresaModel, GlobalClass.Select);
            if (dt != null)
            cbEmpresa.DataSource = dt;
            cbEmpresa.DisplayMember = dt.Columns["NOMBRE"].ToString();
            cbEmpresa.ValueMember = dt.Columns["ID"].ToString();
        }

        private void btnCerrarLogin_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrarLogin.BackColor = Color.Crimson;
        }

        private void btnCerrarLogin_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarLogin.BackColor = Color.Transparent;
        }

        private void upperPanelCategoria_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
