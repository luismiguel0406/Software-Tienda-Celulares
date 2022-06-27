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
            float subTotal = 0;
            foreach (DataGridViewRow row in dgvIngreso.Rows)
            {
                subTotal = (float)row.Cells["SUBTOTAL"].Value;
                total = total + subTotal;

            }
            lblTotal.Text = total.ToString();
        }
        private void DatosFormulario()
        {
            ingresoModel.idIngreso = string.IsNullOrEmpty(txtIdIngreso.Text) ? 0 : Convert.ToInt32(txtIdIngreso.Text);
            ingresoModel.idUsuario = string.IsNullOrEmpty(txtIdUsuario.Text) ? 0 : Convert.ToInt32(txtIdUsuario.Text);
            ingresoModel.comentario = string.IsNullOrEmpty(rtComentario.Text)? string.Empty : rtComentario.Text;
            ingresoModel.numeroComprobante = string.IsNullOrEmpty(txtComprobante.Text) ? string.Empty : txtComprobante.Text;
            ingresoModel.fecha = string.IsNullOrEmpty(dtpFecha.Text) ? DateTime.Now : Convert.ToDateTime(dtpFecha.Value.ToString("yyyy-MM-dd"));
            ingresoModel.total = string.IsNullOrEmpty(lblTotal.Text) ? 0 : Convert.ToDouble(lblTotal.Text);

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
            calcularTotal();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvIngreso.Rows.Count >0)
            {
                dgvIngreso.Rows.Remove(dgvIngreso.CurrentRow);
                calcularTotal();
            }
            
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
                GlobalClass.limpiar(tcIngresos);
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

        private void btnEliminarIngreso_Click(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DatosFormulario();
            dgvVerIngreso.DataSource = IngresoDTO.MantenimientoIngreso(ingresoModel, GlobalClass.Select);
        }

        private void tpRealizarIngresos_Click(object sender, EventArgs e)
        {
            txtIdUsuario.Text = string.IsNullOrEmpty(GlobalClass.idUsuario.ToString()) ? string.Empty : GlobalClass.idUsuario.ToString();
        }
    }
}
