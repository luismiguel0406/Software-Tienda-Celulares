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

namespace MenuGerman
{
    public partial class frmModalArticulos : Form       
    {
         Articulo articulo = new Articulo();
         private frmIngreso frmIngreso;

        public frmModalArticulos(frmIngreso frmIngreso)
        {
            this.frmIngreso = frmIngreso;
            InitializeComponent();
        }

        private void frmModalArticulos_Load(object sender, EventArgs e)
        {
            dgvModalArticulo.DataSource = ArticuloDTO.MantenimientoArticulo(articulo, GlobalClass.Select);
            dgvModalArticulo.Columns["ESTADO"].Visible = false;
            dgvModalArticulo.Columns["DESCRIPCION"].Visible = false;

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                List<IDetalleIngresoDetails> detalle = new List<IDetalleIngresoDetails>();
                foreach (DataGridViewRow row in dgvModalArticulo.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Seleccionar"].Value))
                    {
                        detalle.Add(new DetalleIngreso
                        {
                            idArticulo = Convert.ToInt32(row.Cells["IDARTICULO"].Value),
                            cantidad = Convert.ToInt32(row.Cells["CANTIDAD"].Value),
                            precio = Convert.ToSingle(row.Cells["PRECIO_VENTA"].Value)
                        });
                    }

                }

                frmIngreso.RecibirListaArticulos(detalle);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ha ocurrido un error,{ex}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
            
        }
    }
}
