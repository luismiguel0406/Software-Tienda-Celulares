using CapaDeDatos.Models;
using CapaNegocio.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;
using Utilidades;

namespace MenuGerman
{
    public partial class frmCategoria : Form
    {
        Categoria categoriaModel = new Categoria();
        bool editar = false;
        public frmCategoria()
        {
            InitializeComponent();
        }

       
        private void DatosFormulario()
        {
            categoriaModel.nombre = string.IsNullOrEmpty(txtNombre.Text) ? string.Empty : txtNombre.Text;
           // categoriaModel.descripcion = string.IsNullOrEmpty(rtDescripcion.Text) ? string.Empty : rtDescripcion.Text;
            categoriaModel.idCategoria = string.IsNullOrEmpty(txtIdcategoria.Text) ? 0 : Convert.ToInt32(txtIdcategoria.Text);
            categoriaModel.estado = string.IsNullOrEmpty(cbEstado.Text) ? 1 : Convert.ToInt32(cbEstado.Text);
        }

        private void DatosdataGridView() 
        {
            txtIdcategoria.Text = dgvCategoria.CurrentRow.Cells["IDCATEGORIA"].Value.ToString();
            txtNombre.Text = dgvCategoria.CurrentRow.Cells["NOMBRE"].Value.ToString();
           // rtDescripcion.Text = dgvCategoria.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
            cbEstado.Text = dgvCategoria.CurrentRow.Cells["ESTADO"].Value.ToString();
             
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DatosFormulario();
            dgvCategoria.DataSource = CategoriaDTO.MantenimientoCategoria(categoriaModel, GlobalClass.Select);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvCategoria))
            {
                DatosdataGridView();
                editar = true;
                txtIdcategoria.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvCategoria))
            {
                DialogResult dialogo = MessageBox.Show("Esta seguro que desea eliminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    categoriaModel.idCategoria = Convert.ToInt32(dgvCategoria.CurrentRow.Cells["IDCATEGORIA"].Value);
                    dgvCategoria.DataSource = CategoriaDTO.MantenimientoCategoria(categoriaModel, GlobalClass.Delete);

                }
                else
                {
                    return;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (editar)
                {
                    DatosFormulario();
                    dgvCategoria.DataSource = CategoriaDTO.MantenimientoCategoria(categoriaModel, GlobalClass.Update);
                    txtIdcategoria.Enabled = true;
                }
                else
                {
                    DatosFormulario();
                    dgvCategoria.DataSource = CategoriaDTO.MantenimientoCategoria(categoriaModel, GlobalClass.Insert);
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

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Crimson;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Transparent;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCategoria_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataGridView.Visible = false;
        }

        private void dgvCategoria_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvCategoria.Rows.Count == 0)
                lblDataGridView.Visible = true;
        }
    }
}
