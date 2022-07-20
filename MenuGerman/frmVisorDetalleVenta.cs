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
    public partial class frmVisorDetalleVenta : Form
    {
        private DataTable _dt;
        private Venta _ventaModel;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public frmVisorDetalleVenta(DataTable dt, Venta ventaModel)
        {
            _dt = dt;
            _ventaModel = ventaModel;
            InitializeComponent();
        }

        private void frmVisorDetalleVenta_Load(object sender, EventArgs e)
        {
            dgvDetalle.DataSource = _dt;
            lblTotal.Text = GlobalClass.money((float)_ventaModel.total);
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
