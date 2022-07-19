using CapaDeDatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

namespace MenuGerman
{
    public partial class frmVisorReporteIngresocs : Form
    {
        private DataTable _dt;
        private Ingreso _ingreso;


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public frmVisorReporteIngresocs(DataTable dt, Ingreso ingresoModel)
        {
            _dt = dt;
            _ingreso = ingresoModel;
            InitializeComponent();
            
        }

        private void frmVisorReporteIngresocs_Load(object sender, EventArgs e)
        {
            dgvDetalle.DataSource = _dt;
            lblComprobante.Text = string.IsNullOrWhiteSpace(_ingreso.numeroComprobante) ? "N/A" : _ingreso.numeroComprobante;
            lblImpuesto.Text = GlobalClass.money((float)_ingreso.impuesto);
            lblTotal.Text =  GlobalClass.money((float)_ingreso.total);
        }

        private void upperPanelDetalleIngreso_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.Crimson;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
