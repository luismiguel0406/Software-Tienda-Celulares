using CapaDeDatos;
using CapaDeDatos.Models;
using CapaNegocio.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Utilidades;

namespace MenuGerman.ControlesUser
{
    public partial class cuIngreso : UserControl
    {
        Ingreso ingresoModel = new Ingreso();
        List<IDetalleIngresoDetails> detalleActual = new List<IDetalleIngresoDetails>();
        public cuIngreso()
        {
            InitializeComponent();
        }
        private void calcularTotal()
        {
            float total = 0;
            foreach (DataGridViewRow row in dgvIngreso.Rows)
            {
                float subTotal = (float)row.Cells["SUBTOTAL"].Value;
                total += subTotal;

            }
            lblTotal.Text = GlobalClass.money(total);
        }
        private void DatosFormulario()
        {
            ingresoModel.idIngreso = string.IsNullOrWhiteSpace(txtIdIngreso.Text) ? 0 : Convert.ToInt32(txtIdIngreso.Text);
            ingresoModel.idUsuario = GlobalClass.idUsuario;
            ingresoModel.comentario = string.IsNullOrWhiteSpace(rtComentario.Text)? string.Empty : rtComentario.Text;
            ingresoModel.numeroComprobante = string.IsNullOrWhiteSpace(txtComprobante.Text) ? string.Empty : txtComprobante.Text;
            ingresoModel.fecha = string.IsNullOrWhiteSpace(cdtpFecha.Text) ? DateTime.Now : Convert.ToDateTime(cdtpFecha.Value.ToString("yyyy-MM-dd"));
            ingresoModel.fechaDesde = chkFechas.Checked ? Convert.ToDateTime(cdtpFechaDesde.Value.ToString("yyyy-MM-dd")):DateTime.MinValue;
            ingresoModel.fechaHasta = chkFechas.Checked ? Convert.ToDateTime(cdtpFechaHasta.Value.ToString("yyyy-MM-dd")) : DateTime.Now;
            ingresoModel.total = string.IsNullOrWhiteSpace(lblTotal.Text) ? 0 : Convert.ToDouble(lblTotal.Text);
            
            List<DetalleIngreso> detalle = new List<DetalleIngreso>();
            foreach (DataGridViewRow row in dgvIngreso.Rows)
            {
                detalle.Add(new DetalleIngreso
                {
                    idArticulo = Convert.ToInt32(row.Cells["IDARTICULO"].Value),
                    cantidad = Convert.ToInt32(row.Cells["CANTIDAD"].Value),
                    precio = Convert.ToSingle(row.Cells["PRECIO"].Value),
                    subTotal = Convert.ToSingle(row.Cells["SUBTOTAL"].Value),

                });
            }
            ingresoModel.detalleIngreso = detalle;

        }
        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {
            frmModalArticulos frmModalArticulos = new frmModalArticulos(this);
            frmModalArticulos.ShowDialog();
        }
        public void RecibirListaArticulos(List<IDetalleIngresoDetails> detalle)
        {
            detalleActual.AddRange(detalle);
            dgvIngreso.DataSource = null;
            dgvIngreso.DataSource = detalleActual;
            
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvIngreso))
            {
                int deleteId = (int)dgvIngreso.CurrentRow.Cells["idArticulo"].Value;

                var query = from d in detalleActual.AsEnumerable()
                            where d.idArticulo != deleteId
                            select d;
                detalleActual = query.ToList();
                dgvIngreso.DataSource = detalleActual;
            }
           
        }
        private bool camposVacios()
        {
            if (dgvIngreso.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar articulos para poder hacer un ingreso.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            else
            {          
                return false;
            }           
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!camposVacios())
                {                 
                    DatosFormulario();
                    dgvVerIngreso.DataSource = IngresoDTO.MantenimientoIngreso(ingresoModel, GlobalClass.Insert);
                 
                    MessageBox.Show("Operacion exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GlobalClass.limpiar(gbIngreso);
                    GlobalClass.limpiar(dgvIngreso);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btnEliminarIngreso_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvVerIngreso))
            {
                DialogResult dialogo = MessageBox.Show("Esta seguro que desea eliminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    ingresoModel.idIngreso = Convert.ToInt32(dgvVerIngreso.CurrentRow.Cells["ID"].Value);
                    dgvVerIngreso.DataSource = IngresoDTO.MantenimientoIngreso(ingresoModel, GlobalClass.Delete);
                    MessageBox.Show("Operacion exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DatosFormulario();
            dgvVerIngreso.DataSource = IngresoDTO.MantenimientoIngreso(ingresoModel, GlobalClass.Select);
            if (dgvVerIngreso.Rows.Count == 0)
            {
                MessageBox.Show("Sin datos para Mostrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GlobalClass.limpiar(tcIngresos);
            GlobalClass.limpiar(dgvIngreso);
            txtIdUsuario.Text = GlobalClass.idUsuario.ToString();
        }

        private void dgvVerIngreso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GlobalClass.validaDgv(dgvVerIngreso))
            {
                ingresoModel.idIngreso = Convert.ToInt32(dgvVerIngreso.CurrentRow.Cells["ID"].Value);
                ingresoModel.impuesto = Convert.ToDouble(dgvVerIngreso.CurrentRow.Cells["IMPUESTO"].Value);
                ingresoModel.total = Convert.ToDouble(dgvVerIngreso.CurrentRow.Cells["TOTAL"].Value);
                ingresoModel.numeroComprobante = dgvVerIngreso.CurrentRow.Cells["NCF"].Value.ToString();
                DataTable dt = IngresoDTO.MantenimientoIngreso(ingresoModel, GlobalClass.detalle);
                frmVisorReporteIngresocs frmDetalle = new frmVisorReporteIngresocs(dt, ingresoModel);
                frmDetalle.ShowDialog();
            }
        }

        private void dgvIngreso_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calcularTotal();
        }

        private void dgvIngreso_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calcularTotal();
        }

        private void chkFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFechas.Checked)
            {
                gbFechas.Enabled = true;

            }
            else
            {
                gbFechas.Enabled = false;
            }
        }

        
    }
}
