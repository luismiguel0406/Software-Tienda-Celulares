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
    public partial class frmRol : Form
    {
        Rol rolModel = new Rol();
        bool editar  = false;
        public frmRol()
        {
            InitializeComponent();
        }
    
        private void DatosFormulario()
        {
            rolModel.idRol = string.IsNullOrEmpty(txtIdRol.Text) ? 0 :Convert.ToInt32(txtIdRol.Text);
            rolModel.nombre = string.IsNullOrEmpty(txtNombre.Text) ? string.Empty : txtNombre.Text;
            rolModel.descripcion = string.IsNullOrEmpty(txtDescripcion.Text) ? string.Empty : txtDescripcion.Text;
            rolModel.estado = string.IsNullOrEmpty(cbEstado.Text) ? 1 : Convert.ToInt32(cbEstado.Text);

        }
        private void DatosDataGridView()
        {
            txtIdRol.Text = dgvRol.CurrentRow.Cells["IDROL"].Value.ToString();
            txtNombre.Text = dgvRol.CurrentRow.Cells["NOMBRE"].Value.ToString();
            txtDescripcion.Text = dgvRol.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
            cbEstado.Text = dgvRol.CurrentRow.Cells["ESTADO"].Value.ToString();
        }
   

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (editar)
                {
                    DatosFormulario();
                    dgvRol.DataSource = RolDTO.MantenimeintoRol(rolModel,GlobalClass.Update);
                    txtIdRol.Enabled = true;
                }
                else
                {                   
                    DatosFormulario();
                    dgvRol.DataSource = RolDTO.MantenimeintoRol(rolModel, GlobalClass.Insert);
                    
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

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            DatosFormulario();
            dgvRol.DataSource = RolDTO.MantenimeintoRol(rolModel, GlobalClass.Select);
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvRol))
            {
                DatosDataGridView();
                txtIdRol.Enabled = false;
                editar = true;
            }
            
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvRol))
            {
                DialogResult dialogo = MessageBox.Show("Esta seguro que desea eliminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    rolModel.idRol = Convert.ToInt32(dgvRol.CurrentRow.Cells["IDROL"].Value);
                    dgvRol.DataSource = RolDTO.MantenimeintoRol(rolModel, GlobalClass.Delete);
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
            GlobalClass.limpiar(dgvRol);
            editar = false;
            txtIdRol.Enabled = true;
        }
    }
}
