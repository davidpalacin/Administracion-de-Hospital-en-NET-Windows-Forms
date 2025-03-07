using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalForm
{
    class Hospital
    {
        public List<Paciente> pacientes = new List<Paciente>();
        public List<Doctor> doctores = new List<Doctor>();

        public Hospital()
        {
            pacientes.Add(new Paciente { Nombre = "Juan", Apellido = "Perez" });
            pacientes.Add(new Paciente { Nombre = "Maria", Apellido = "Gonzalez" });
            pacientes.Add(new Paciente { Nombre = "Pedro", Apellido = "Lopez" });
            doctores.Add(new Doctor { Nombre = "Dr. Juan", Apellido = "Gomez" });
            doctores.Add(new Doctor { Nombre = "Dr. Maria", Apellido = "Gutierrez" });
            doctores.Add(new Doctor { Nombre = "Dr. Pedro", Apellido = "Martinez" });
        }
    }
}
