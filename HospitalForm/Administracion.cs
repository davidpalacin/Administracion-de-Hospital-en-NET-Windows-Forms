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
        static Hospital hospital = new Hospital();
        public Administracion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnVerPacientes_Click(object sender, EventArgs e)
        {
            // Abrir ventana con la lista de pacientes
            List<Paciente> pacientes = hospital.pacientes;
            string listaPacientes = "";
            foreach (Paciente paciente in pacientes)
            {
                listaPacientes += paciente.Nombre + " " + paciente.Apellido + "\n";
            }
            MessageBox.Show(listaPacientes);


        }

        private void btnVerDoctores_Click(object sender, EventArgs e)
        {
            // Abrir ventana con la lista de pacientes
            List<Doctor> doctores= hospital.doctores;
            string listaDoctores = "";
            foreach (Doctor doctor in doctores)
            {
                listaDoctores += doctor.Nombre + " " + doctor.Apellido + "\n";
            }
            MessageBox.Show(listaDoctores);
        }
    }
}
