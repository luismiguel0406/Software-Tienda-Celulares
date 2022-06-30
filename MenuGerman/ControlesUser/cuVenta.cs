using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuGerman.ControlesUser
{
    public partial class cuVenta : UserControl
    {
        public cuVenta()
        {
            InitializeComponent();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmModalArticulos modalArticulos = new frmModalArticulos();
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

        private void dgvVenta_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           var totales = CalculoTotales(dgvVenta);
            lblSubTotal.Text =totales.subtotal.ToString();
            lblItbis.Text = totales.itbis.ToString();
            lblDescuentos.Text = totales.descuento.ToString();
            lblTotal.Text = totales.total.ToString();
        }

        private void dgvVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            var totales = CalculoTotales(dgvVenta);
            lblSubTotal.Text = totales.subtotal.ToString();
            lblItbis.Text = totales.itbis.ToString();
            lblDescuentos.Text = totales.descuento.ToString();
            lblTotal.Text = totales.total.ToString();

        }
    }
}
