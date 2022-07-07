using CapaDeDatos.Models;
using CapaNegocio.DTO;
using System;
using System.Drawing;
using System.Text;
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

       private void modoEdicion(bool activado)
        {
            if (activado)
            {
                editar = true;
                btnBuscar.Enabled = false;
                txtIdcategoria.Enabled = false;
            }
            if (!activado)
            {
                editar = false;
                btnBuscar.Enabled = true;
                txtIdcategoria.Enabled = true;
            }

        }

        private bool camposVacios()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                stringBuilder.AppendLine("El NOMBRE es requerido.");
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
            categoriaModel.nombre = string.IsNullOrEmpty(txtNombre.Text) ? string.Empty : txtNombre.Text;
            categoriaModel.idCategoria = string.IsNullOrEmpty(txtIdcategoria.Text) ? 0 : Convert.ToInt32(txtIdcategoria.Text);
            categoriaModel.estado = string.IsNullOrEmpty(cbEstado.Text) ? 1 : Convert.ToInt32(cbEstado.Text);
        }

        private void DatosdataGridView() 
        {
            txtIdcategoria.Text = dgvCategoria.CurrentRow.Cells["IDCATEGORIA"].Value.ToString();
            txtNombre.Text = dgvCategoria.CurrentRow.Cells["NOMBRE"].Value.ToString();
            cbEstado.Text = dgvCategoria.CurrentRow.Cells["ESTADO"].Value.ToString();
             
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DatosFormulario();
            dgvCategoria.DataSource = CategoriaDTO.MantenimientoCategoria(categoriaModel, GlobalClass.Select);
            if (dgvCategoria.Rows.Count == 0)
            {
                MessageBox.Show("Sin datos para Mostrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvCategoria))
            {
                DatosdataGridView();
                modoEdicion(true);                
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
                if (!camposVacios())
                {
                    if (editar)
                    {
                        DatosFormulario();
                        dgvCategoria.DataSource = CategoriaDTO.MantenimientoCategoria(categoriaModel, GlobalClass.Update);
                        modoEdicion(false);
                    }
                    else
                    {
                        DatosFormulario();
                        dgvCategoria.DataSource = CategoriaDTO.MantenimientoCategoria(categoriaModel, GlobalClass.Insert);
                    }
                    MessageBox.Show("Operacion exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GlobalClass.limpiar(this);
                }
               
            }
            catch (Exception )
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GlobalClass.limpiar(this);
            GlobalClass.limpiar(dgvCategoria);
            modoEdicion(false);
        }
    }
}
