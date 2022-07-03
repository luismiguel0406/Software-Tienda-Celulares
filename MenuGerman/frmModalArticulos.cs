using CapaDeDatos;
using CapaDeDatos.Interfaces;
using CapaDeDatos.Models;
using CapaNegocio.DTO;
using MenuGerman.ControlesUser;
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
        private cuIngreso _cuIngreso;
        private cuVenta _cuVenta;

        public frmModalArticulos(cuIngreso cuIngreso)
        {
            _cuIngreso = cuIngreso;
            InitializeComponent();
        }
        public frmModalArticulos()
        {
            InitializeComponent();
        }
        public frmModalArticulos(cuVenta venta)
        {
            _cuVenta = venta;      
            InitializeComponent();
        }

        private void frmModalArticulos_Load(object sender, EventArgs e)
        {
            var dt = ArticuloDTO.MantenimientoArticulo(articulo, GlobalClass.Select);
            try
            {
                dgvModalArticulo.DataSource = dt;
                //USUARIO NO NECESITA VER ESTAS CELDAS
                dgvModalArticulo.Columns["ESTADO"].Visible = false;
                dgvModalArticulo.Columns["DESCRIPCION"].Visible = false;
                dgvModalArticulo.Columns["IDCATEGORIA"].Visible = false;
                dgvModalArticulo.Columns["PRECIO_VENTA"].Visible = false;
                
               

                //USUARIO NO PUEDE EDITAR ESTAS CELDAS, LAS DEMAS SI
                dgvModalArticulo.Columns["CATEGORIA"].ReadOnly = true;
                dgvModalArticulo.Columns["CODIGO"].ReadOnly = true;
                dgvModalArticulo.Columns["NOMBRE"].ReadOnly = true;
                dgvModalArticulo.Columns["STOCK"].ReadOnly = true;

            }
            catch (Exception)
            {
               return;
            }
 
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_cuIngreso != null)
                {
                    List<IDetalleIngresoDetails> detalle = new List<IDetalleIngresoDetails>();
                    foreach (DataGridViewRow row in dgvModalArticulo.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Seleccionar"].Value))
                        {
                            detalle.Add(new DetalleIngreso
                            {
                                idArticulo = Convert.ToInt32(row.Cells["ID"].Value),
                                //  nombre = Convert.ToString(row.Cells["NOMBRE"].Value),
                                cantidad = Convert.ToInt32(row.Cells["CANTIDAD"].Value),
                                precio = Convert.ToSingle(row.Cells["PRECIO_VENTA"].Value),
                                subTotal = Convert.ToInt32(row.Cells["CANTIDAD"].Value) * Convert.ToSingle(row.Cells["PRECIO_VENTA"].Value)

                            });
                        }

                    }
                    _cuIngreso.RecibirListaArticulos(detalle);
                }
                if (_cuVenta != null)
                {
                    
                    List<IDetalleVentaDetails> detalle = new List<IDetalleVentaDetails>();
                    foreach (DataGridViewRow row in dgvModalArticulo.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Seleccionar"].Value))
                        {
                            detalle.Add(new DetalleVenta
                            {
                                idArticulo = Convert.ToInt32(row.Cells["ID"].Value),
                                descripcion = Convert.ToString(row.Cells["NOMBRE"].Value),
                                cantidad = Convert.ToInt32(row.Cells["CANTIDAD"].Value),
                                precio = Convert.ToSingle(row.Cells["PRECIO_VENTA"].Value),
                                subTotal = Convert.ToInt32(row.Cells["CANTIDAD"].Value) * Convert.ToSingle(row.Cells["PRECIO_VENTA"].Value)

                            });
                        }
                        
                    }
                    _cuVenta.RecibirListaArticulos(detalle);
                }
               
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ha ocurrido un error,{ex}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Crimson;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Transparent;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //busqueda por lo que se escriba
            GlobalClass.buscarEnVivoDatagrid(txtBuscar, dgvModalArticulo);
         
        }

        private void frmModalArticulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _cuVenta = null;
            _cuIngreso = null;
        }
    }
}
