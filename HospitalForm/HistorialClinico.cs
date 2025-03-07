using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalForm
{
    class HistorialClinico
    {
        // Citas, diagnósticos y tratamientos recibidos
        // Médico puede agregar notas y recetas médicas
        public Paciente Paciente { get; set; }
        public List<Cita> Citas { get; set; }
        public List<string> Tratamientos { get; set; }
        public List<string> Notas { get; set; }
        public List<string> Recetas { get; set; }



    }
}
