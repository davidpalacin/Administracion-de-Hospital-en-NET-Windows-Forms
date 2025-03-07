using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalForm
{
    class Cita
    {
        public Medico MedicoCita { get; set; }
        public Paciente PacienteCita { get; set; }
        public DateTime Fecha { get; set; }
        public string Referencia { get; set; }

        public override string ToString()
        {
            return $"Paciente: {PacienteCita.Nombre} - Profesional: Dr. {MedicoCita.Nombre} - Fecha: {Fecha} - REF: {Referencia}";
        }
    }
}
