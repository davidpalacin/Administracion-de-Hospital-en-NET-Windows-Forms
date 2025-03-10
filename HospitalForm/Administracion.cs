using HospitalForm;
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
    public partial class Administracion: Form
    {
        static Gestion gestion = new Gestion();
        public Administracion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnVerPacientes_Click(object sender, EventArgs e)
        {
            List<Paciente> pacientes = gestion.Pacientes;

            FormVerPacientes verPacientes = new FormVerPacientes(gestion.Pacientes);
            verPacientes.Show();

        }

        private void btnVerDoctores_Click(object sender, EventArgs e)
        {
            List<Medico> medicos= gestion.Medicos;

            FormVerMedicos verMedicos = new FormVerMedicos(gestion.Medicos);
            verMedicos.Show();
        }

        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            // Abrir form para crear nuevo paciente
            FormCrearPaciente crearPaciente = new FormCrearPaciente(gestion.Medicos);

            // Crear el paciente cuando hayamos terminado de rellenar los datos
            if (crearPaciente.ShowDialog() == DialogResult.OK)
            {
                // Solo se agrega si el usuario ha confirmado la creación
                gestion.Pacientes.Add(crearPaciente.NuevoPaciente);
                MessageBox.Show("Paciente creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCrearMedico_Click(object sender, EventArgs e)
        {
            // Abrir form para crear nuevo medico
            FormCrearMedico crearMedico = new FormCrearMedico();

            // Crear el medico cuando hayamos terminado de rellenar los datos
            if (crearMedico.ShowDialog() == DialogResult.OK)
            {
                // Solo se agrega si el usuario ha confirmado la creación
                gestion.Medicos.Add(crearMedico.NuevoMedico);
                MessageBox.Show("Paciente creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
