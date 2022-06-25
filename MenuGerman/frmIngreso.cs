using CapaDeDatos;
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
    public partial class frmIngreso : Form
    {   Persona personaModel = new Persona();
        Ingreso ingresoModel = new Ingreso();

        bool editar = false;
        public frmIngreso()
        {
            InitializeComponent();
            
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {
            
            var dt= PersonaDTO.MantenimientoPersona(personaModel, GlobalClass.Select);
            cbProveedor.DataSource = dt;
            cbProveedor.DisplayMember = dt.Columns["NOMBRE"].ToString();
            cbProveedor.ValueMember = dt.Columns["IDPERSONA"].ToString();
            txtIdUsuario.Text = GlobalClass.idUsuario.ToString();
        }


        public void RecibirListaArticulos(IEnumerable<IDetalleIngresoDetails> detalle)
        {       
            dgvIngreso.DataSource = detalle;
            float total = 0;
            foreach (DataGridViewRow row in dgvIngreso.Rows)
            {
                float subTotal = Convert.ToSingle(row.Cells["CANTIDAD"].Value) * Convert.ToSingle(row.Cells["PRECIO"].Value);
                row.Cells["SUBTOTAL"].Value = subTotal.ToString();
                total = total + subTotal;
                                
            }
               txtTotal.Text = total.ToString();

        }
        
        private void DatosFormulario()
        {
            ingresoModel.idIngreso = string.IsNullOrEmpty(txtIdIngreso.Text) ? 0 : Convert.ToInt32(txtIdIngreso.Text);
            ingresoModel.idProveedor = string.IsNullOrEmpty(cbProveedor.Text) ? 0 : Convert.ToInt32(cbProveedor.SelectedValue);
            ingresoModel.idUsuario =  string.IsNullOrEmpty(txtIdUsuario.Text) ? 0 : Convert.ToInt32(txtIdUsuario.Text);
            ingresoModel.serieComprobante = string.IsNullOrEmpty(cbSerieComprobante.Text) ? string.Empty : cbSerieComprobante.Text;
            ingresoModel.tipoComprobante = string.IsNullOrEmpty(cbTipoComprobante.Text) ? string.Empty : cbTipoComprobante.Text;
            ingresoModel.numeroComprobante = string.IsNullOrEmpty(txtNumeroComprobante.Text) ? string.Empty : txtNumeroComprobante.Text;
            ingresoModel.fecha = string.IsNullOrEmpty(dtFecha.Text)? DateTime.Now : Convert.ToDateTime(dtFecha.Value.ToString("yyyy-MM-dd"));
            ingresoModel.impuesto = string.IsNullOrEmpty(txtImpuesto.Text) ? 0 : Convert.ToDouble(txtImpuesto.Text);
            ingresoModel.total = string.IsNullOrEmpty(txtTotal.Text) ? 0 : Convert.ToDouble(txtTotal.Text);

            List<DetalleIngreso> detalle = new List<DetalleIngreso>();
            foreach (DataGridViewRow row in dgvIngreso.Rows)
            {
                detalle.Add(new DetalleIngreso
                {
                    idArticulo = Convert.ToInt32(row.Cells["IDARTICULO"].Value),
                    cantidad = Convert.ToInt32(row.Cells["CANTIDAD"].Value),
                    precio = Convert.ToSingle(row.Cells["PRECIO"].Value)
                    
                });
            }
            ingresoModel.detalleIngreso = detalle;
            
        }
        
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            //frmModalArticulos frmModalArticulos = new frmModalArticulos(this);
            //frmModalArticulos.ShowDialog();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
           txtImpuesto.Text = string.IsNullOrEmpty(txtTotal.Text)? string.Empty : (Convert.ToSingle(txtTotal.Text) * 0.18).ToString();
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (editar)
                {
                    DatosFormulario();
                    dgvVerIngreso.DataSource = IngresoDTO.MantenimientoIngreso(ingresoModel, GlobalClass.Update);
                }
                else
                {
                    DatosFormulario();
                    dgvVerIngreso.DataSource = IngresoDTO.MantenimientoIngreso(ingresoModel, GlobalClass.Insert);
                    
                }
                MessageBox.Show("Operacion exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GlobalClass.limpiar(tabControlIngresos);
                GlobalClass.limpiar(dgvIngreso);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DatosFormulario();
            dgvVerIngreso.DataSource = IngresoDTO.MantenimientoIngreso(ingresoModel, GlobalClass.Select);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GlobalClass.limpiar(tabControlIngresos);
            GlobalClass.limpiar(dgvIngreso);
            editar = false;
            txtIdIngreso.Enabled = true;
            txtIdUsuario.Text = GlobalClass.idUsuario.ToString();
        }

        private void txtNumeroComprobante_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbTipoComprobante.Text)&&string.IsNullOrEmpty(cbSerieComprobante.Text))
            {
                return;
            } 
            txtNumeroComprobante.Text = GlobalClass.numeroComprobante(cbSerieComprobante.Text, cbTipoComprobante.Text);
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvVerIngreso))
            {
                DialogResult dialogo = MessageBox.Show("Esta seguro que desea eliminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    ingresoModel.idIngreso = Convert.ToInt32(dgvVerIngreso.CurrentRow.Cells["IDINGRESO"].Value);
                    dgvVerIngreso.DataSource = IngresoDTO.MantenimientoIngreso(ingresoModel, GlobalClass.Delete);
                }
                else
                {
                    return;
                }
            }
        }

        private void dgvVerIngreso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GlobalClass.validaDgv(dgvVerIngreso))
            {
                ingresoModel.idIngreso =Convert.ToInt32(dgvVerIngreso.CurrentRow.Cells["IDINGRESO"].Value);
                ingresoModel.impuesto = Convert.ToDouble(dgvVerIngreso.CurrentRow.Cells["IMPUESTO"].Value);
                ingresoModel.total = Convert.ToDouble(dgvVerIngreso.CurrentRow.Cells["TOTAL"].Value);
                ingresoModel.numeroComprobante = dgvVerIngreso.CurrentRow.Cells["NUM_COMPROBANTE"].Value.ToString();
                DataTable dt = IngresoDTO.MantenimientoIngreso(ingresoModel, GlobalClass.detalleIngreso);
                frmVisorReporteIngresocs frmDetalle = new frmVisorReporteIngresocs(dt, ingresoModel);
                frmDetalle.ShowDialog();
            }
        }
    }
}
