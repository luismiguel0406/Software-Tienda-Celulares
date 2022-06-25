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
    public partial class cuIngreso : UserControl
    {
        public cuIngreso()
        {
            InitializeComponent();
        }

        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {
            frmModalArticulos frmModalArticulos = new frmModalArticulos(this);
            frmModalArticulos.ShowDialog();
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
            lblTotal.Text = total.ToString();

        }
    }
}
