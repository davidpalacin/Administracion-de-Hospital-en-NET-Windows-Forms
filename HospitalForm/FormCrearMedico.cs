using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalForm
{
    public partial class FormCrearMedico: Form
    {

        public Medico NuevoMedico { get; set; }

        public FormCrearMedico()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Validar los datos
            if (string.IsNullOrEmpty(txtNombreMedico.Text) || string.IsNullOrEmpty(txtDNIMedico.Text))
            {
                MessageBox.Show("Debe rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la especialidad seleccionada
            Especialidad especialidadSeleccionada = (Especialidad)Enum.Parse(typeof(Especialidad), cmbEspecialidad.SelectedItem.ToString());

            // Crear el médico
            NuevoMedico = new Medico(txtNombreMedico.Text, txtDNIMedico.Text, especialidadSeleccionada);

            // Cerrar el formulario con resultado OK
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
