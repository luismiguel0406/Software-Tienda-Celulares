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
    public partial class FrmArticulos : Form
    {
        Articulo articuloModel = new Articulo();
        Categoria categoriaModel = new Categoria();
        bool editar = false;
        public FrmArticulos()
        {
            InitializeComponent();
        }
        public void DatosFormulario()
        {
            articuloModel.idArticulo = string.IsNullOrEmpty(txtIdArticulo.Text) ? 0 : Convert.ToInt32(txtIdArticulo.Text);
            articuloModel.codigo = string.IsNullOrEmpty(txtCodigo.Text) ? 0 : Convert.ToInt32(txtCodigo.Text);
            articuloModel.nombre = string.IsNullOrEmpty(txtNombre.Text) ? string.Empty : txtNombre.Text;
            articuloModel.idCategoria = string.IsNullOrEmpty(cbCategoria.Text) ? 0 : Convert.ToInt32(cbCategoria.SelectedValue);
            articuloModel.precioVenta = string.IsNullOrEmpty(txtPrecioventa.Text) ? 0 : (float)Convert.ToDouble(txtPrecioventa.Text);
            articuloModel.stock = string.IsNullOrEmpty(txtStock.Text) ? 0 : Convert.ToInt32(txtStock.Text);
            articuloModel.descripcion = string.IsNullOrEmpty(rtDescripcion.Text)? string.Empty : rtDescripcion.Text;
            articuloModel.estado = string.IsNullOrEmpty(cbEstado.Text) ? 1 : Convert.ToInt32(cbEstado.Text);
                       
        }
        public void DatosdataGridView()
        {
           txtIdArticulo.Text = dgvArticulo.CurrentRow.Cells["IDARTICULO"].Value.ToString();
           cbCategoria.SelectedValue = (int)dgvArticulo.CurrentRow.Cells["IDCATEGORIA"].Value; 
           cbCategoria.SelectedText =  dgvArticulo.CurrentRow.Cells["CATEGORIA"].Value.ToString();
           txtCodigo.Text = dgvArticulo.CurrentRow.Cells["CODIGO"].Value.ToString();
           txtNombre.Text = dgvArticulo.CurrentRow.Cells["NOMBRE"].Value.ToString();
           txtPrecioventa.Text = dgvArticulo.CurrentRow.Cells["PRECIO_VENTA"].Value.ToString();
           txtStock.Text = dgvArticulo.CurrentRow.Cells["STOCK"].Value.ToString();
           rtDescripcion.Text = dgvArticulo.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
           cbEstado.Text = dgvArticulo.CurrentRow.Cells["ESTADO"].Value.ToString();

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvArticulo))
            {
                DialogResult dialogo = MessageBox.Show("Esta seguro que desea eliminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    articuloModel.idArticulo = Convert.ToInt32(dgvArticulo.CurrentRow.Cells["IDARTICULO"].Value);
                    dgvArticulo.DataSource = ArticuloDTO.MantenimientoArticulo(articuloModel, GlobalClass.Delete);
                }
                else
                {
                    return;
                }
            }                
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvArticulo))
            {
                DatosdataGridView();
                txtIdArticulo.Enabled = false;
                editar = true;
            }
           
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {   
            DatosFormulario();
            dgvArticulo.DataSource = ArticuloDTO.MantenimientoArticulo(articuloModel, GlobalClass.Select);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        { 
            try
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
                GlobalClass.limpiar(this);

            }
            catch (Exception ex )
            {
                MessageBox.Show($"Ha ocurrido un error,{ex}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                editar = false;
            }
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
           
            var dt = CategoriaDTO.MantenimientoCategoria(categoriaModel, GlobalClass.Select);
            cbCategoria.DataSource = dt;
            cbCategoria.DisplayMember = dt.Columns["NOMBRE"].ToString();
            cbCategoria.ValueMember = dt.Columns["IDCATEGORIA"].ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {   
            GlobalClass.limpiar(this);
            GlobalClass.limpiar(dgvArticulo);
            editar = false;
            txtIdArticulo.Enabled = true;
        }
    }
}
