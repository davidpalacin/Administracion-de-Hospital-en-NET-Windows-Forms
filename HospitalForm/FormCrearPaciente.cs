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
    public partial class FormCrearPaciente : Form
    {
        List<Medico> ListMedicos { get; set; } = new List<Medico>();
        public Paciente NuevoPaciente { get; set; }

        public FormCrearPaciente(List<Medico> listMedicos)
        {
            InitializeComponent();
            ListMedicos = listMedicos;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCrearPaciente_Load(object sender, EventArgs e)
        {
            cmbTipoEnfermedad.SelectedText = "--Seleccione--";
            cmbEstaEnfermo.SelectedText = "--Seleccione--";
            cmbMedicoCabecera.SelectedText = "--Seleccione--";

            // Introducir en la lista los médicos de cabecera
            foreach (var medico in ListMedicos)
            {
                cmbMedicoCabecera.Items.Add(medico.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Guardo la lista de medicos

            // Obtener la especialidad seleccionada
            Especialidad especialidadSeleccionada = (Especialidad)Enum.Parse(typeof(Especialidad), cmbTipoEnfermedad.SelectedItem.ToString());

            // Crear el paciente
            NuevoPaciente = new Paciente(txtNombrePaciente.Text, txtDNIPaciente.Text, especialidadSeleccionada, ListMedicos[cmbMedicoCabecera.SelectedIndex]);

            // Cerrar el formulario con resultado OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}