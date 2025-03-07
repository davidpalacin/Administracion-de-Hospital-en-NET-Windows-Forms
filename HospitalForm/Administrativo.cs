using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalForm
{
    public enum Permiso
    {
        Basico, // Solo leer
        Administrador // Leer, dar de alta y dar de baja
    }
    class Administrativo : Persona
    {
        public Permiso Permiso { get; set; }
        public string Contrasenia { get; set; }
        public Administrativo(string nombre, string contrasenia, string identificacion, Permiso rol)
        {
            Nombre = nombre;
            Contrasenia = contrasenia;
            DNI = identificacion;
            Permiso = rol;
        }

        public override string ToString()
        {
            string permisos;
            if (Permiso == Permiso.Basico)
                permisos = "Básicos";
            else
                permisos = "Superusuario";
            return $"Administrativo {Nombre} con DNI: {DNI} tiene permisos: {permisos}";
        }

    }
}
