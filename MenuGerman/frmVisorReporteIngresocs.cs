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

namespace MenuGerman
{
    public partial class frmVisorReporteIngresocs : Form
    {
        private DataTable _dt;
        private Ingreso _ingreso;
        public frmVisorReporteIngresocs(DataTable dt, Ingreso ingresoModel)
        {
            _dt = dt;
            _ingreso = ingresoModel;
            InitializeComponent();
            
        }

        private void frmVisorReporteIngresocs_Load(object sender, EventArgs e)
        {
            dgvDetalleIngreso.DataSource = _dt;
            lblComprobante.Text = _ingreso.numeroComprobante;
            lblImpuesto.Text = _ingreso.impuesto.ToString();
            lblTotal.Text = _ingreso.total.ToString();
        }
    }
}
