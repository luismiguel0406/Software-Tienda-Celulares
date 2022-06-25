using CapaDeDatos.Models;
using CapaNegocio.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

namespace MenuGerman.ControlesUser
{
    public partial class cuUsuarios : UserControl
    {
        Rol rolModel = new Rol();
        Usuario usuarioModel = new Usuario();
        bool editar = false;

    

        public cuUsuarios()
        {
            InitializeComponent();
        }

        
        private void DatosFormulario()
        {

            usuarioModel.idUsuario = string.IsNullOrEmpty(txtIdUsuario.Text) ? 0 : Convert.ToInt32(txtIdUsuario.Text);
            usuarioModel.idRol = string.IsNullOrEmpty(cbRol.Text) ? 0 : Convert.ToInt32(cbRol.SelectedValue);
            usuarioModel.usuario = string.IsNullOrEmpty(txtUsuario.Text) ? string.Empty : txtUsuario.Text;
            usuarioModel.password = Encryptar.encrypta(string.IsNullOrEmpty(txtContrasena.Text) ? string.Empty : txtContrasena.Text);
            usuarioModel.nombre = string.IsNullOrEmpty(txtNombre.Text) ? string.Empty : txtNombre.Text;
            usuarioModel.email = string.IsNullOrEmpty(txtEmail.Text) ? string.Empty : txtEmail.Text;
            usuarioModel.estado = string.IsNullOrEmpty(cbEstado.Text) ? 1 : Convert.ToInt32(cbEstado.Text);
        }
        private void DatosdataGridView()
        {
            txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells["IDUSUARIO"].Value.ToString();
            cbRol.SelectedValue = dgvUsuarios.CurrentRow.Cells["IDROL"].Value;
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["USUARIO"].Value.ToString();
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells["NOMBRE"].Value.ToString();
            txtEmail.Text = dgvUsuarios.CurrentRow.Cells["EMAIL"].Value.ToString();
            txtContrasena.Text = Encryptar.desencrypta(dgvUsuarios.CurrentRow.Cells["PASSWORD"].Value.ToString());

        }
        private void comboBoxRol()
        {
            DataTable dt = RolDTO.MantenimeintoRol(rolModel, GlobalClass.Select);
            cbRol.DataSource = dt;
            cbRol.DisplayMember = dt.Columns["NOMBRE"].ToString();
            cbRol.ValueMember = dt.Columns["IDROL"].ToString();
        }

        private void cuUsuarios_Load(object sender, EventArgs e)
        {
            comboBoxRol();       
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DatosFormulario();
            dgvUsuarios.DataSource = UsuariosDTO.MantenimientoUsuario(usuarioModel, GlobalClass.Select);
            if (dgvUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("Sin datos para Mostrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvUsuarios))
            {
                DatosdataGridView();
                txtIdUsuario.Enabled = false;
                gbUsuario.Text = "Editando...";
                editar = true;
                
                
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (editar)
                {
                    DatosFormulario();
                    dgvUsuarios.DataSource = UsuariosDTO.MantenimientoUsuario(usuarioModel, GlobalClass.Update);
                    txtIdUsuario.Enabled = true;
                    gbUsuario.Text = "Nuevo Usuario";
                    
                }
                else
                {
                    DatosFormulario();
                    dgvUsuarios.DataSource = UsuariosDTO.MantenimientoUsuario(usuarioModel, GlobalClass.Insert);
                }
                MessageBox.Show("Operacion exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GlobalClass.limpiar(gbUsuario);
                GlobalClass.limpiar(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error,{ex}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
               
                editar = false;
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GlobalClass.limpiar(gbUsuario);
            GlobalClass.limpiar(dgvUsuarios);
            editar = false;
            txtIdUsuario.Enabled = true;
            gbUsuario.Text = "Nuevo Usuario";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvUsuarios))
            {
                DialogResult dialogo = MessageBox.Show("Esta seguro que desea eliminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    usuarioModel.idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IDUSUARIO"].Value);
                    dgvUsuarios.DataSource = UsuariosDTO.MantenimientoUsuario(usuarioModel, GlobalClass.Delete);
                }
                else
                {
                    return;
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloLetras(e);
        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void pbVerContrasena_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasena.PasswordChar = (char)48;
        }

        private void dgvUsuarios_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvUsuarios.Columns.Contains("PASSWORD"))
            {
                dgvUsuarios.Columns["PASSWORD"].Visible = false;
            }
        }
    }
}
