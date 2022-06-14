using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades
{
    public static class Validaciones
    {

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

        public static void soloNumeros(KeyPressEventArgs e)
        {    //CODIGOS ASCII
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255 ))
            {
                MessageBox.Show("Solo puede digitar numeros", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        public static void soloLetras(KeyPressEventArgs e)
        {   //CODIGOS ASCII
            if((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar>= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puede digitar letras", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
       public static void camposNoVacios(UserControl us)
        {

            foreach (Control ctrl in us.Controls)
            {
                if(ctrl is TextBox || ctrl is RichTextBox)
                {
                    //codes here
                }
            }
        }
    }
}
