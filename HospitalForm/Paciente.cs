using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalForm
{
    public class Paciente : Persona
    {
        public Especialidad TipoEnfermedad { get; set; }
        public bool Curado { get; set; } = false;
        public Medico MedicoCabecera { get; set; }

        public Paciente (string nombre, string identificacion, Especialidad tipoEnfermedad, Medico medicoCabecera)
        {
            Nombre = nombre;
            DNI = identificacion;
            TipoEnfermedad = tipoEnfermedad;
            MedicoCabecera = medicoCabecera;
        }

        public bool BajaEfectiva(Medico miMedico)
        {
            miMedico.PacientesAsignados.Remove(this);
            return true;
        }

        public void CambiarEstado(bool estado)
        {
            Curado = estado;
        }

        public override string ToString()
        {
            string estado = Curado ? "Curado" : "Enfermo";
            string medicoNombre = MedicoCabecera != null ? MedicoCabecera.Nombre : "No asignado";

            return $"Paciente {Nombre}. Profesional requerido: {TipoEnfermedad}. Médico asignado: {medicoNombre}. Estado actual de la enfermedad - {estado}";
        }

    }
}
