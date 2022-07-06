using CapaDeDatos.Models;
using CapaNegocio.DTO;
using System;
using System.Text;
using System.Windows.Forms;
using Utilidades;

namespace MenuGerman.ControlesUser
{
    public partial class cuArticulo : UserControl
    {
        Articulo articuloModel = new Articulo();
        Categoria categoriaModel = new Categoria();
        bool editar = false;
        public cuArticulo()
        {
            InitializeComponent();
        }
        private void comboBoxCategoria()
        {
            var dt = CategoriaDTO.MantenimientoCategoria(categoriaModel, GlobalClass.Select);
            if (dt.Columns.Contains("NOMBRE") && dt.Columns.Contains("IDCATEGORIA"))
            {
                cbCategoria.DataSource = dt;
                cbCategoria.DisplayMember = dt.Columns["NOMBRE"].ToString();
                cbCategoria.ValueMember = dt.Columns["IDCATEGORIA"].ToString();
            }
            
        }
        private bool camposVacios()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                stringBuilder.AppendLine("El CODIGO es requerido.");
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                stringBuilder.AppendLine("El NOMBRE es requerido.");
            }
            if (string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                stringBuilder.AppendLine("El PRECIO es requerido.");
            }
            if (string.IsNullOrWhiteSpace(txtStock.Text))
            {
                stringBuilder.AppendLine("EL STOCK es requerido.");
            }
            if (string.IsNullOrEmpty(cbCategoria.Text))
            {
                stringBuilder.AppendLine("La CATEGORIA es requerida.");
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

        public void DatosFormulario()
        {
            articuloModel.idArticulo = string.IsNullOrWhiteSpace(txtIdArticulo.Text) ? 0 : Convert.ToInt32(txtIdArticulo.Text);
            articuloModel.codigo = string.IsNullOrWhiteSpace(txtCodigo.Text) ? 0 : Convert.ToInt32(txtCodigo.Text);
            articuloModel.nombre = string.IsNullOrWhiteSpace(txtNombre.Text) ? string.Empty : txtNombre.Text;
            articuloModel.idCategoria = string.IsNullOrWhiteSpace(cbCategoria.Text) ? 0 : Convert.ToInt32(cbCategoria.SelectedValue);
            articuloModel.precioVenta = string.IsNullOrWhiteSpace(txtPrecioVenta.Text) ? 0 : (float)Convert.ToDouble(txtPrecioVenta.Text);
            articuloModel.stock = string.IsNullOrWhiteSpace(txtStock.Text) ? 0 : Convert.ToInt32(txtStock.Text);
            articuloModel.descripcion = string.IsNullOrWhiteSpace(rtDescripcion.Text) ? string.Empty : rtDescripcion.Text;
            articuloModel.estado = string.IsNullOrWhiteSpace(cbEstado.Text) ? 1 : Convert.ToInt32(cbEstado.Text);
            articuloModel.empresa = GlobalClass.empresa;
        }
        public void DatosdataGridView()
        {
            txtIdArticulo.Text = dgvArticulo.CurrentRow.Cells["ID"].Value.ToString();
            cbCategoria.SelectedValue = (int)dgvArticulo.CurrentRow.Cells["IDCATEGORIA"].Value;
            cbCategoria.SelectedText = dgvArticulo.CurrentRow.Cells["CATEGORIA"].Value.ToString();
            txtCodigo.Text = dgvArticulo.CurrentRow.Cells["CODIGO"].Value.ToString();
            txtNombre.Text = dgvArticulo.CurrentRow.Cells["NOMBRE"].Value.ToString();
            txtPrecioVenta.Text = dgvArticulo.CurrentRow.Cells["PRECIO_VENTA"].Value.ToString();
            txtStock.Text = dgvArticulo.CurrentRow.Cells["STOCK"].Value.ToString();
            rtDescripcion.Text = dgvArticulo.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
            cbEstado.Text = dgvArticulo.CurrentRow.Cells["ESTADO"].Value.ToString();

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
                        dgvArticulo.DataSource = ArticuloDTO.MantenimientoArticulo(articuloModel, GlobalClass.Update);
                        txtIdArticulo.Enabled = true;
                    }
                    else
                    {
                        DatosFormulario();
                        dgvArticulo.DataSource = ArticuloDTO.MantenimientoArticulo(articuloModel, GlobalClass.Insert);
                    }
                    MessageBox.Show("Operacion exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GlobalClass.limpiar(gbArticulo);
                    GlobalClass.limpiar(this);
                }         

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                editar = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GlobalClass.limpiar(gbArticulo);
            GlobalClass.limpiar(dgvArticulo);
            editar = false;
            txtIdArticulo.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DatosFormulario();
            dgvArticulo.DataSource = ArticuloDTO.MantenimientoArticulo(articuloModel, GlobalClass.Select);
            if (dgvArticulo.Rows.Count==0)
            {
                MessageBox.Show("Sin datos para Mostrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Validaciones.validaDgv(dgvArticulo))
            {
                DatosdataGridView();
                txtIdArticulo.Enabled = false;
                editar = true;

                
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Validaciones.validaDgv(dgvArticulo))
            {
                DialogResult dialogo = MessageBox.Show("Esta seguro que desea eliminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    articuloModel.idArticulo = Convert.ToInt32(dgvArticulo.CurrentRow.Cells["ID"].Value);
                    dgvArticulo.DataSource = ArticuloDTO.MantenimientoArticulo(articuloModel, GlobalClass.Delete);
                    MessageBox.Show("Operacion exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
        }

        private void cuArticulo_Load(object sender, EventArgs e)
        {
            comboBoxCategoria();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria frmCategoria = new frmCategoria();
            frmCategoria.ShowDialog();
            comboBoxCategoria();
        }


        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.soloNumeros(e);
        }

        private void dgvArticulo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblDataGridView.Visible = false;
        }

        private void dgvArticulo_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvArticulo.Rows.Count == 0)
                lblDataGridView.Visible = true;

        }
    }
}
