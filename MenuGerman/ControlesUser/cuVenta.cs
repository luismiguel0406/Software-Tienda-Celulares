using CapaDeDatos;
using CapaDeDatos.Interfaces;
using CapaDeDatos.Models;
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
    public partial class cuVenta : UserControl
    {
        Venta ventaModel = new Venta();
        public cuVenta()
        {
            InitializeComponent();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmModalArticulos modalArticulos = new frmModalArticulos(this);
            modalArticulos.ShowDialog();
        }

        private Totales CalculoTotales(DataGridView dgv)
        {
            float subTotal = 0;
            float itbis = 0;
            float descuento = 0;


            foreach (DataGridViewRow row in dgv.Rows)
            {
                subTotal += Convert.ToSingle(row.Cells["SUBTOTAL"].Value);

            }
            float total = (subTotal + itbis) - descuento;
            return new Totales { subtotal = subTotal, total = total, itbis = itbis, descuento = descuento };

        }
        public void RecibirListaArticulos(IEnumerable<IDetalleVentaDetails> detalle)
        {
            dgvVenta.DataSource = detalle;
        }
        private void dgvVenta_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           var totales = CalculoTotales(dgvVenta);
            lblSubTotal.Text = GlobalClass.money(totales.subtotal);
            lblItbis.Text = GlobalClass.money( totales.itbis);
            lblDescuentos.Text = GlobalClass.money(totales.descuento);
            lblTotal.Text =  GlobalClass.money(totales.total);
        }

        private void dgvVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            var totales = CalculoTotales(dgvVenta);
            lblSubTotal.Text = GlobalClass.money(totales.subtotal);
            lblItbis.Text = GlobalClass.money(totales.itbis);
            lblDescuentos.Text = GlobalClass.money(totales.descuento);
            lblTotal.Text = GlobalClass.money(totales.total);

        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            if (dgvVenta.Rows.Count > 0)
            {
                dgvVenta.Rows.Remove(dgvVenta.CurrentRow);
               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvVenta))
            {
                DialogResult dialogo = MessageBox.Show("Esta seguro que desea cancelar esta venta?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    GlobalClass.limpiar(dgvVenta);
                    GlobalClass.limpiar(this);
                }
                else
                {
                    return;
                }
            }
           
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
           
           
            ventaModel.fecha = DateTime.Now;
            ventaModel.comentario = rtComentario.Text;
            ventaModel.idUsuario = GlobalClass.idUsuario;

            ventaModel.subtotal = Convert.ToSingle(lblSubTotal.Text);
            ventaModel.descuento = Convert.ToSingle(lblDescuentos.Text);
            ventaModel.itbis = Convert.ToSingle(lblItbis.Text);
            ventaModel.total = Convert.ToSingle(lblTotal.Text);
            //pendiente detalle

        }
    }
}
