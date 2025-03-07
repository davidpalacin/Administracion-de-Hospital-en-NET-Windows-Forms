using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalForm
{
    public enum Especialidad
    {
        Pediatra,
        Traumatologo,
        Cardiologo,
        Oftalmologo,
        Odontologo,
        Psiquiatra,
        Dermatologo,
        Ginecologo,
        Urologo,
        Endocrinologo,
        Otorrinolaringologo
    }
    public class Medico : Persona
    {
        public Especialidad Especialidad { get; set; }
        public List<Paciente> PacientesAsignados { get; set; } = new List<Paciente>();

        public Medico(string nombre, string identificacion, Especialidad especialidad)
        {
            Nombre = nombre;
            DNI = identificacion;
            Especialidad = especialidad;
        }

        public override string ToString()
        {
            return $"Dr. {Nombre} ({Especialidad}) - DNI: {DNI}";
        }
    }
}
