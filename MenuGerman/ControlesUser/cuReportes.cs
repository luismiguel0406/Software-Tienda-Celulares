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
    public partial class cuReportes : UserControl
    {   Venta ventaModel = new Venta();
        public cuReportes()
        {
            InitializeComponent();
        }

        private void datosVenta()
        {
            ventaModel.idVenta = string.IsNullOrWhiteSpace(txtIdVenta.Text) ? 0 : Convert.ToInt32(txtIdVenta.Text);
            ventaModel.fechaDesde = chkFechas.Checked ? Convert.ToDateTime(cdtpFechaDesde.Value.ToString("yyyy-MM-dd")) : DateTime.MinValue;
            ventaModel.fechaHasta = chkFechas.Checked ? Convert.ToDateTime(cdtpFechaHasta.Value.ToString("yyyy-MM-dd")) : DateTime.Now;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            datosVenta();
            dgvVerVenta.DataSource = VentaDTO.MantenimientoVenta(ventaModel, GlobalClass.Select);
            if (dgvVerVenta.Rows.Count == 0)
            {
                MessageBox.Show("Sin datos para Mostrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvVerVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GlobalClass.validaDgv(dgvVerVenta))
            {
                ventaModel.idVenta = Convert.ToInt32(dgvVerVenta.CurrentRow.Cells["ID"].Value);
                ventaModel.total = Convert.ToInt32(dgvVerVenta.CurrentRow.Cells["TOTAL"].Value);
                DataTable dt = VentaDTO.MantenimientoVenta(ventaModel, GlobalClass.detalle);
                frmVisorDetalleVenta frmDetalle = new frmVisorDetalleVenta(dt, ventaModel);
                frmDetalle.ShowDialog();
            }
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
