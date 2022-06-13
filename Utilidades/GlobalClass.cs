using System;
using System.Windows.Forms;

namespace Utilidades
{
    public static  class GlobalClass
    {
        public static int idUsuario { get; set; }
        public static string Usuario { get; set; }
        public static string rol { get; set; }
        public static int idRol { get; set; }

        public static int Select { get { return 1; } }
        public static int Insert { get { return 2; } }
        public static int Delete { get { return 3; } }
        public static int Update { get { return 4; } }    
        public static int Login { get { return 5; } }
        public static int detalleIngreso { get { return 6; } }


        public static void limpiar(UserControl cu)
        {
            foreach (Control c in cu.Controls)
            {
                if (c is TextBox || c is RichTextBox)
                {
                    c.Text = string.Empty;
                }                
            }

        }
        public static void limpiar(Form frm)
        {
            foreach (Control c in frm.Controls)
            {
                if (c is TextBox || c is RichTextBox)
                {
                    c.Text = string.Empty;
                }
            }

        }
        public static void limpiar(TabControl tab)
        {
            foreach (Control c in tab.Controls)
            {
                foreach (Control t in c.Controls)
                {
                    if (t is TextBox || t is RichTextBox)
                    {
                        t.Text = string.Empty;
                    }
                }
                
            }

        }
        public static void limpiar(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
        }

       
        public static string numeroComprobante(string serie, string tipo)
        {

            Random random = new Random();
            int numero = random.Next(01,999);
            string zero = new string('0', 8 - numero.ToString().Length);

            return $"{serie}{tipo}{zero}{numero}";

        }
        public static bool administrador(int idRol, string adm)
        {
            if (idRol == 1 && adm == "ADMINISTRADOR") return true;
            return false;

        }
        public static bool validaDgv(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No ha seleccionado una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
