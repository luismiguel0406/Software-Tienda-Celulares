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
    
    public partial class frmPersona : Form
    {
        Persona personaModel = new Persona();
        bool editar = false;
        public frmPersona()
        {
            InitializeComponent();
        }

        private void DatosFormulario()
        {
            personaModel.idPersona = string.IsNullOrEmpty(txtIdPersona.Text) ? 0 : Convert.ToInt32(txtIdPersona.Text);
            personaModel.tipoPersona = string.IsNullOrEmpty(cbTipoPersona.Text) ? string.Empty : cbTipoPersona.Text;
            personaModel.nombre = string.IsNullOrEmpty(txtNombre.Text) ? string.Empty : txtNombre.Text;
            personaModel.tipoDocumento = string.IsNullOrEmpty(cbTipoDocumento.Text) ? string.Empty : cbTipoDocumento.Text;
            personaModel.numeroDocumento = string.IsNullOrEmpty(txtNumeroDocumento.Text) ? string.Empty : txtNumeroDocumento.Text;
            personaModel.direccion = string.IsNullOrEmpty(txtDireccion.Text) ? string.Empty : txtDireccion.Text;
            personaModel.telefono = string.IsNullOrEmpty(txtTelefono.Text) ? string.Empty : txtTelefono.Text;
            personaModel.email = string.IsNullOrEmpty(txtEmail.Text) ? string.Empty : txtEmail.Text;
            personaModel.estado = string.IsNullOrEmpty(cbEstado.Text) ? 1 : Convert.ToInt32(cbEstado.Text);

        }
        private void DatosdataGridView()
        {
            txtIdPersona.Text = dgvPersona.CurrentRow.Cells["IDPERSONA"].Value.ToString();
            cbTipoPersona.Text = dgvPersona.CurrentRow.Cells["TIPO_PERSONA"].Value.ToString();
            txtNombre.Text = dgvPersona.CurrentRow.Cells["NOMBRE"].Value.ToString();
            cbTipoDocumento.Text = dgvPersona.CurrentRow.Cells["TIPO_DOCUMENTO"].Value.ToString();
            txtNumeroDocumento.Text = dgvPersona.CurrentRow.Cells["NUM_DOCUMENTO"].Value.ToString();
            txtDireccion.Text = dgvPersona.CurrentRow.Cells["DIRECCION"].Value.ToString();
            txtTelefono.Text = dgvPersona.CurrentRow.Cells["TELEFONO"].Value.ToString();
            txtEmail.Text = dgvPersona.CurrentRow.Cells["EMAIL"].Value.ToString();
            cbEstado.Text = dgvPersona.CurrentRow.Cells["ESTADO"].Value.ToString();

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DatosFormulario();
            dgvPersona.DataSource = PersonaDTO.MantenimientoPersona(personaModel,GlobalClass.Select);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvPersona))
            {
                DatosdataGridView();
                txtIdPersona.Enabled = false;
                editar = true;
            }
       
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (editar)
                {
                    DatosFormulario();
                    dgvPersona.DataSource = PersonaDTO.MantenimientoPersona(personaModel, GlobalClass.Update);
                    txtIdPersona.Enabled = true;
                }
                else
                {                   
                    DatosFormulario();
                    dgvPersona.DataSource = PersonaDTO.MantenimientoPersona(personaModel, GlobalClass.Insert);                 
                }
                MessageBox.Show("Operacion exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GlobalClass.limpiar(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error,{ex}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                editar = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (GlobalClass.validaDgv(dgvPersona))
            {
                DialogResult dialogo = MessageBox.Show("Esta seguro que desea eliminar?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    personaModel.idPersona = Convert.ToInt32(dgvPersona.CurrentRow.Cells["IDPERSONA"].Value);
                    dgvPersona.DataSource = PersonaDTO.MantenimientoPersona(personaModel, GlobalClass.Delete);
                }
                else
                {
                    return;
                }
            }
                
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GlobalClass.limpiar(this);
            GlobalClass.limpiar(dgvPersona);
            editar = false;
            txtIdPersona.Enabled = true;
        }
    }
}
