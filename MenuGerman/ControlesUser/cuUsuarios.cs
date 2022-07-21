using CapaDeDatos.Models;
using CapaNegocio.DTO;
using System;
using System.Data;
using System.Text;
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

        private void modoEdicion(bool activado) 
        {
            if (activado)
            {
                txtIdUsuario.Enabled = false;
                gbUsuario.Text = "Editando...";
                btnBuscar.Enabled = false;
                editar = true;
            }
            if (!activado)
            {
                txtIdUsuario.Enabled = true;
                gbUsuario.Text = "Nuevo Usuario";
                btnBuscar.Enabled = true;
                editar = false;
            }
        }
         private bool camposVacios()
         {
            StringBuilder stringBuilder = new StringBuilder();
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                stringBuilder.AppendLine("El USUARIO es requerido.");
                
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                stringBuilder.AppendLine("El NOMBRE es requerido.");
                
            }
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                stringBuilder.AppendLine("La CONTRASEÑA es requerida.");
                
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                stringBuilder.AppendLine("El EMAIL es requerido.");
                
            }

            if (stringBuilder.Length > 0)
            {
                MessageBox.Show(stringBuilder.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
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
            usuarioModel.empresa = GlobalClass.empresa;
        }
        private void DatosdataGridView()
        {
            txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString();
            cbRol.SelectedValue = (int)dgvUsuarios.CurrentRow.Cells["IDROL"].Value;
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
                modoEdicion(true);               
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!camposVacios())
                {
                    if (editar)
                    {
                        DatosFormulario();
                        dgvUsuarios.DataSource = UsuariosDTO.MantenimientoUsuario(usuarioModel, GlobalClass.Update);
                        modoEdicion(false);
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
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GlobalClass.limpiar(gbUsuario);
            GlobalClass.limpiar(dgvUsuarios);
            modoEdicion(false);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvUsuarios))
            {
                DialogResult dialogo = MessageBox.Show("Esta seguro que desea eliminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    usuarioModel.idUsuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["ID"].Value);
                    dgvUsuarios.DataSource = UsuariosDTO.MantenimientoUsuario(usuarioModel, GlobalClass.Delete);
                }
                else
                {
                    return;
                }
            }
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
            if (dgvUsuarios.Columns.Contains("IDROL"))
            {
                dgvUsuarios.Columns["IDROL"].Visible = false;
            }

            lblDataGridView.Visible = false;
        }

        private void dgvUsuarios_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvUsuarios.Rows.Count == 0)
                lblDataGridView.Visible = true;
        }
    }
}
