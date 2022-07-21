using CapaDeDatos;
using CapaDeDatos.Interfaces;
using CapaDeDatos.Models;
using CapaNegocio.DTO;
using MenuGerman.ControlesUser;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Utilidades;
using System.Runtime.InteropServices;
using System.Text;

namespace MenuGerman
{
    public partial class frmModalArticulos : Form       
    {
        Articulo articulo = new Articulo();
        private cuIngreso _cuIngreso;
        private cuVenta _cuVenta;
        StringBuilder stringBuilder = new StringBuilder();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
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
        private bool cantidadesValidas(StringBuilder stringBuilder, string articulo,int cantidad, int stock)
        {         
            if (cantidad > stock)
            {
                stringBuilder.AppendLine($"El articulo {articulo} solo tiene una cantidad disponible de: {stock}");
                
            }
            if (stringBuilder.Length > 0)
            {
                MessageBox.Show(stringBuilder.ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stringBuilder.Clear();
                return false;
            }
            else
            {
                return true;
            }

        }
        private void frmModalArticulos_Load(object sender, EventArgs e)
        {
            var dt = ArticuloDTO.MantenimientoArticulo(articulo, GlobalClass.Select);
            try
            {
                if (dt!= null)            
                dgvModalArticulo.DataSource = dt;
                //USUARIO NO NECESITA VER ESTAS CELDAS
                dgvModalArticulo.Columns["ESTADO"].Visible = false;
                dgvModalArticulo.Columns["DESCRIPCION"].Visible = false;
                dgvModalArticulo.Columns["IDCATEGORIA"].Visible = false;
                dgvModalArticulo.Columns["CODIGO"].Visible = false;


                //USUARIO NO PUEDE EDITAR ESTAS CELDAS, LAS DEMAS SI
                dgvModalArticulo.Columns["CATEGORIA"].ReadOnly = true;
                dgvModalArticulo.Columns["CODIGO"].ReadOnly = true;
                dgvModalArticulo.Columns["NOMBRE"].ReadOnly = true;
                dgvModalArticulo.Columns["STOCK"].ReadOnly = true;
                dgvModalArticulo.Columns["PRECIO_VENTA"].ReadOnly = true;

            }
            catch (Exception)
            {
               return;
            }
 
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            string articulo = "";
            int stock = 0;
            try
            {
                if (_cuIngreso != null)
                {
                    List<IDetalleIngresoDetails> detalle = new List<IDetalleIngresoDetails>();
                    foreach (DataGridViewRow row in dgvModalArticulo.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Seleccionar"].Value))
                        {
                            cantidad = Convert.ToInt32(row.Cells["CANTIDAD"].Value);
                            articulo = Convert.ToString(row.Cells["NOMBRE"].Value);
                            stock = Convert.ToInt32(row.Cells["STOCK"].Value);

                            if (cantidadesValidas(stringBuilder, articulo, cantidad, stock))
                            {
                                detalle.Add(new DetalleIngreso
                                {
                                    idArticulo = Convert.ToInt32(row.Cells["ID"].Value),
                                    descripcion = Convert.ToString(row.Cells["NOMBRE"].Value),
                                    cantidad = Convert.ToInt32(row.Cells["CANTIDAD"].Value),
                                    precio = Convert.ToSingle(row.Cells["PRECIO_VENTA"].Value),
                                    subTotal = Convert.ToInt32(row.Cells["CANTIDAD"].Value) * Convert.ToSingle(row.Cells["PRECIO_VENTA"].Value)

                                });
                            }  else
                            {
                                return;
                            }                         
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
                            cantidad = Convert.ToInt32(row.Cells["CANTIDAD"].Value);
                            articulo = Convert.ToString(row.Cells["NOMBRE"].Value);
                            stock = Convert.ToInt32(row.Cells["STOCK"].Value);

                            if (cantidadesValidas(stringBuilder, articulo, cantidad, stock))
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
                            else
                            {
                                return;
                            }
                           
                        }
                        
                    }
                    _cuVenta.RecibirListaArticulos(detalle);
                }
               
                Close();
            }
            catch (Exception )
            {

                MessageBox.Show("Ha ocurrido un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void upperPanelCategoria_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void dgvModalArticulo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          /*  if (dgvModalArticulo.Columns["SEL"].Equals(true))
            {
                dgvModalArticulo.CurrentRow.Cells["CANTIDAD"].Selected = true;
            }
          */
        }

       
    }
}
