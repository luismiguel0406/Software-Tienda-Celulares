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

namespace MenuGerman
{
    public partial class frmUsuario : Form
    {
        Rol rolModel = new Rol();
        Usuario usuarioModel = new Usuario();
        bool editar = false;

        public frmUsuario()
        {
            InitializeComponent();
        }
        private void DatosFormulario()
        {

            usuarioModel.idUsuario = string.IsNullOrEmpty(txtIdUsuario.Text) ? 0 : Convert.ToInt32(txtIdUsuario.Text);
            usuarioModel.idRol = string.IsNullOrEmpty(cbRol.Text) ? 0 : Convert.ToInt32(cbRol.SelectedValue);
            usuarioModel.usuario = string.IsNullOrEmpty(txtUsuario.Text) ? string.Empty : txtUsuario.Text;
            usuarioModel.password = string.IsNullOrEmpty(txtContraseña.Text) ? string.Empty : txtContraseña.Text;
            usuarioModel.direccion = string.IsNullOrEmpty(txtDireccion.Text) ? string.Empty : txtDireccion.Text;
            usuarioModel.telefono = string.IsNullOrEmpty(txtTelefono.Text) ? string.Empty : txtTelefono.Text;
            usuarioModel.email = string.IsNullOrEmpty(txtEmail.Text) ? string.Empty : txtEmail.Text;
            usuarioModel.estado = string.IsNullOrEmpty(cbEstado.Text) ? 1 : Convert.ToInt32(cbEstado.Text);
        }
        private void DatosdataGridView()
        {
            txtIdUsuario.Text = dgvUsuario.CurrentRow.Cells["IDUSUARIO"].Value.ToString();
            cbRol.SelectedValue = dgvUsuario.CurrentRow.Cells["IDROL"].Value;
            txtUsuario.Text = dgvUsuario.CurrentRow.Cells["USUARIO"].Value.ToString();
            txtDireccion.Text = dgvUsuario.CurrentRow.Cells["DIRECCION"].Value.ToString();
            txtTelefono.Text = dgvUsuario.CurrentRow.Cells["TELEFONO"].Value.ToString();
            txtEmail.Text = dgvUsuario.CurrentRow.Cells["EMAIL"].Value.ToString();
            txtContraseña.Text = dgvUsuario.CurrentRow.Cells["PASSWORD"].Value.ToString();

        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {    
            
            DataTable dt = RolDTO.MantenimeintoRol(rolModel, GlobalClass.Select);
            cbRol.DataSource = dt;
            cbRol.DisplayMember = dt.Columns["NOMBRE"].ToString();
            cbRol.ValueMember = dt.Columns["IDROL"].ToString();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DatosFormulario();
            dgvUsuario.DataSource = UsuariosDTO.MantenimientoUsuario(usuarioModel, GlobalClass.Select);           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (editar)
                {
                    DatosFormulario();
                    dgvUsuario.DataSource = UsuariosDTO.MantenimientoUsuario(usuarioModel, GlobalClass.Update);
                    txtIdUsuario.Enabled = true;
                }
                else
                {
                    DatosFormulario();
                    dgvUsuario.DataSource = UsuariosDTO.MantenimientoUsuario(usuarioModel, GlobalClass.Insert);                  
                }
                MessageBox.Show("Operacion exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvUsuario))
            {
                DatosdataGridView();
                txtIdUsuario.Enabled = false;
                editar = true;
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvUsuario))
            {
                DialogResult dialogo = MessageBox.Show("Esta seguro que desea eliminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    usuarioModel.idUsuario = Convert.ToInt32(dgvUsuario.CurrentRow.Cells["IDUSUARIO"].Value);
                    dgvUsuario.DataSource = UsuariosDTO.MantenimientoUsuario(usuarioModel, GlobalClass.Delete);
                }
                else
                {
                    return;
                }
            }
       
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GlobalClass.limpiar(this);
            GlobalClass.limpiar(dgvUsuario);
            editar = false;
            txtIdUsuario.Enabled = true;
        }
    }
}
