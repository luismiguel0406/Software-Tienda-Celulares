using CapaDeDatos;
using CapaDeDatos.Models;
using CapaNegocio.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Utilidades;

namespace MenuGerman.ControlesUser
{
    public partial class cuIngreso : UserControl
    {
        Ingreso ingresoModel = new Ingreso();
        bool editar = false;
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
            ingresoModel.idIngreso = string.IsNullOrEmpty(txtIdIngreso.Text) ? 0 : Convert.ToInt32(txtIdIngreso.Text);
            ingresoModel.idUsuario = string.IsNullOrEmpty(txtIdUsuario.Text) ? 0 : Convert.ToInt32(txtIdUsuario.Text);
            ingresoModel.comentario = string.IsNullOrEmpty(rtComentario.Text)? string.Empty : rtComentario.Text;
            ingresoModel.numeroComprobante = string.IsNullOrEmpty(txtComprobante.Text) ? string.Empty : txtComprobante.Text;
            ingresoModel.fecha = string.IsNullOrEmpty(cdtpFecha.Text) ? DateTime.Now : Convert.ToDateTime(cdtpFecha.Value.ToString("yyyy-MM-dd"));
            ingresoModel.fechaDesde = chkFechas.Checked ? Convert.ToDateTime(cdtpFechaDesde.Value.ToString("yyyy-MM-dd")):DateTime.MinValue;
            ingresoModel.fechaHasta = chkFechas.Checked ? Convert.ToDateTime(cdtpFechaHasta.Value.ToString("yyyy-MM-dd")) : DateTime.Now;
            ingresoModel.total = string.IsNullOrEmpty(lblTotal.Text) ? 0 : Convert.ToDouble(lblTotal.Text);
            ingresoModel.empresa = GlobalClass.empresa;
            
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
        public void RecibirListaArticulos(IEnumerable<IDetalleIngresoDetails> detalle)
        {
            dgvIngreso.DataSource = detalle;
            
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvIngreso.Rows.Count >0)
            {
                dgvIngreso.Rows.RemoveAt(dgvIngreso.CurrentRow.Index);
                
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
                    GlobalClass.limpiar(gbIngreso);
                    GlobalClass.limpiar(dgvIngreso);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show($"Ha ocurrido un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                editar = false;
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
        }

        private void tpRealizarIngresos_Click(object sender, EventArgs e)
        {
            txtIdUsuario.Text = string.IsNullOrEmpty(GlobalClass.idUsuario.ToString()) ? string.Empty : GlobalClass.idUsuario.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GlobalClass.limpiar(tcIngresos);
            GlobalClass.limpiar(dgvIngreso);
            editar = false;
            txtIdIngreso.Enabled = true;
            txtIdUsuario.Text = GlobalClass.idUsuario.ToString();
        }

        private void dgvVerIngreso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GlobalClass.validaDgv(dgvVerIngreso))
            {
                ingresoModel.idIngreso = Convert.ToInt32(dgvVerIngreso.CurrentRow.Cells["IDINGRESO"].Value);
                ingresoModel.impuesto = Convert.ToDouble(dgvVerIngreso.CurrentRow.Cells["IMPUESTO"].Value);
                ingresoModel.total = Convert.ToDouble(dgvVerIngreso.CurrentRow.Cells["TOTAL"].Value);
                ingresoModel.numeroComprobante = dgvVerIngreso.CurrentRow.Cells["NUM_COMPROBANTE"].Value.ToString();
                DataTable dt = IngresoDTO.MantenimientoIngreso(ingresoModel, GlobalClass.detalleIngreso);
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
