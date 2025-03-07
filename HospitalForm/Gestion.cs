using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace HospitalForm
{
    class Gestion
    {
        public List<Medico> Medicos { get; set; } = new List<Medico>();
        public List<Paciente> Pacientes { get; set; } = new List<Paciente>();
        public List<Administrativo> Administrativos { get; set; } = new List<Administrativo>();
        public List<Cita> Citas { get; set; } = new List<Cita>();
        public Administrativo AdminActivo { get; set; }
        public static Especialidad especialidad;

        public Gestion()
        {
            // Médicos iniciales
            var pepe = new Medico("Pepe", "0000", Especialidad.Cardiologo);
            var andres = new Medico("Andres", "1111", Especialidad.Traumatologo);
            var manuel = new Medico("Manuel", "2222", Especialidad.Endocrinologo);
            var daniel = new Medico("Daniel", "3333", Especialidad.Otorrinolaringologo);

            // Pacientes iniciales
            var sara = new Paciente("Sara", "0000", Especialidad.Cardiologo, pepe);
            var ernesto = new Paciente("Ernesto", "1111", Especialidad.Traumatologo, andres);
            var vicente = new Paciente("Vicente", "2222", Especialidad.Endocrinologo, manuel);

            // Administrativos iniciales
            var david = new Administrativo("David", "1234", "0000", Permiso.Administrador);
            var juanito = new Administrativo("Juanito", "1234", "1111", Permiso.Basico);


            Administrativos.Add(david);
            Administrativos.Add(juanito);

            Medicos.Add(pepe);
            Medicos.Add(andres);
            Medicos.Add(manuel);
            Medicos.Add(daniel);

            Pacientes.Add(sara);
            Pacientes.Add(ernesto);
            Pacientes.Add(vicente);

            pepe.PacientesAsignados.Add(sara);
            andres.PacientesAsignados.Add(ernesto);
            manuel.PacientesAsignados.Add(vicente);
        }

        public void LeerMedicos()
        {
            foreach (Medico medico in Medicos)
            {
                Console.WriteLine("- " + medico.ToString());
            }

            Console.WriteLine("Deseas inspeccionar a alguno de los médicos? (s/n)");
            string sino = Console.ReadLine();

            if (sino == "s")
            {
                Console.WriteLine("DNI del médico que deseas inspeccionar: ");
                string dni = Console.ReadLine();

                Medico medicoSeleccionado = Medicos.Find(medico => medico.DNI == dni);

                if (medicoSeleccionado != null)
                {
                    // Ver los pacientes asignados a este médico
                    Console.WriteLine("Pacientes asignados al médico:");
                    LeerPacientes(medicoSeleccionado.PacientesAsignados);
                }
                else
                {
                    Console.WriteLine("Médico no encontrado");
                }
            }
            else
            {
                return;
            }
        }


        public void LeerPacientes(List<Paciente> pacientes)
        {
            foreach (Paciente paciente in pacientes)
            {
                Console.WriteLine("- " + paciente.ToString());
            }

            Console.WriteLine("Deseas cambiar el estado de alguno de los pacientes? (s/n)");
            string sino = Console.ReadLine();

            if (sino == "s")
                CambiarCurado(pacientes);
            else
                return;
        }

        public void ModificarDatos()
        {
            if(AdminActivo.Permiso != Permiso.Administrador)
            {
                Console.WriteLine("No tienes permiso para acceder a esta acción");
                return;
            }

            Console.WriteLine("EDITAR INFORMACIÓN DE: ");
            Console.WriteLine("1. Médicos");
            Console.WriteLine("2. Pacientes");
            Console.WriteLine("3. Administrativos");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    EditarMedico();
                    break;
                case "2":
                    EditarPaciente();
                    break;
                case "3":
                    EditarAdministrativo();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

        }

        public void EditarMedico()
        {
            foreach(var m in Medicos)
            {
                Console.WriteLine(m.ToString());
            }
            Console.WriteLine("DNI del médico que deseas editar: ");
            string dni = Console.ReadLine();

            Medico medico = Medicos.Find(m => m.DNI == dni);

            if (medico == null)
            {
                Console.WriteLine("Médico no encontrado");
                return;
            }

            Console.WriteLine("Nuevo nombre: ");
            string nombre = Console.ReadLine();
            medico.Nombre = nombre;

            Console.WriteLine("Médico editado correctamente");
        }

        public void EditarPaciente()
        {
            foreach (var p in Pacientes)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("DNI del paciente que deseas editar: ");
            string dni = Console.ReadLine();

            Paciente paciente = Pacientes.Find(p => p.DNI == dni);

            if (paciente == null)
            {
                Console.WriteLine("Paciente no encontrado");
                return;
            }

            Console.WriteLine("Nuevo nombre: ");
            string nombre = Console.ReadLine();
            paciente.Nombre = nombre;

            Console.WriteLine("Paciente editado correctamente");
        }

        public void EditarAdministrativo()
        {
            foreach (var a in Administrativos)
            {
                Console.WriteLine(a.ToString());
            }
            Console.WriteLine("DNI del administrativo que deseas editar: ");
            string dni = Console.ReadLine();

            var administrativo = Administrativos.Find(a => a.DNI == dni);

            if (administrativo == null)
            {
                Console.WriteLine("Administrativo no encontrado");
                return;
            }

            Console.WriteLine("Nuevo nombre: ");
            string nombre = Console.ReadLine();
            administrativo.Nombre = nombre;

            Console.WriteLine("Administrativo editado correctamente");
        }

        public void CambiarCurado(List<Paciente> pacientes)
        {
            Console.WriteLine("DNI del paciente que deseas cambiar estado: ");
            string dni = Console.ReadLine();

            Paciente pacienteSeleccionado = pacientes.Find(p => p.DNI == dni);
            string curado;

            if (pacienteSeleccionado.Curado)
                curado = "Curado";
            else
                curado = "Enfermo";

            Console.WriteLine($"{pacienteSeleccionado.Nombre} está {curado}. ¿Deseas cambiar su estado? (s/n)");
            string eleccion = Console.ReadLine();

            if (eleccion == "s")
            {
                pacienteSeleccionado.CambiarEstado(!pacienteSeleccionado.Curado);

            }
        }

        public void AltaPaciente()
        {
            // Comprobar permisos del administrativo
            if (AdminActivo.Permiso != Permiso.Administrador)
            {
                throw new InvalidOperationException("No estás capacitado para esta acción");
            }

            Console.WriteLine("Ingresa el nombre del paciente: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Identificación: ");
            string DNI = Console.ReadLine();

            Console.WriteLine("Selecciona el profesional requerido: ");
            Console.WriteLine("1. Traumatólogo");
            Console.WriteLine("2. Cardiólogo");
            Console.WriteLine("3. Oftalmólogo");

            Console.WriteLine("4. Odontólogo");
            Console.WriteLine("5. Psiquiatra");
            Console.WriteLine("6. Dermatólogo");
            Console.WriteLine("7. Ginecólogo");
            Console.WriteLine("8. Urólogo");
            Console.WriteLine("9. Endocrinólogo");
            Console.WriteLine("10. Otorrinolaringólogo");

            string eleccion = Console.ReadLine();


            switch (eleccion)
            {
                case "1":
                    especialidad = Especialidad.Traumatologo;
                    break;
                case "2":
                    especialidad = Especialidad.Cardiologo;
                    break;
                case "3":
                    especialidad = Especialidad.Oftalmologo;
                    break;
                case "4":
                    especialidad = Especialidad.Odontologo;
                    break;
                case "5":
                    especialidad = Especialidad.Psiquiatra;
                    break;
                case "6":
                    especialidad = Especialidad.Dermatologo;
                    break;
                case "7":
                    especialidad = Especialidad.Ginecologo;
                    break;
                case "8":
                    especialidad = Especialidad.Urologo;
                    break;
                case "9":
                    especialidad = Especialidad.Endocrinologo;
                    break;
                case "10":
                    especialidad = Especialidad.Otorrinolaringologo;
                    break;
                default:
                    Console.WriteLine("No existe esa especialidad");
                    break;

            }

            // Seleccionar el médico con esa especialidad
            Medico medico = Medicos.Find(m => m.Especialidad == especialidad);

            if (medico == null)
            {
                Console.WriteLine("No hay médicos disponibles para esa especialidad");
                return;
            }

            var nuevoPaciente = new Paciente(nombre, DNI, especialidad, medico);
            Pacientes.Add(nuevoPaciente);

            medico.PacientesAsignados.Add(nuevoPaciente);
            nuevoPaciente.MedicoCabecera = medico;
        }

        public void AltaMedico()
        {
            // Comprobar permisos del administrativo
            if (AdminActivo.Permiso != Permiso.Administrador)
            {
                throw new InvalidOperationException("No estás capacitado para esta acción");
            }

            Console.WriteLine("Ingresa el nombre del médico: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Identificación: ");
            string DNI = Console.ReadLine();

            Console.WriteLine($"Selecciona la especialidad de {nombre}: ");
            Console.WriteLine("1. Traumatólogo");
            Console.WriteLine("2. Cardiólogo");
            Console.WriteLine("3. Oftalmólogo");

            Console.WriteLine("4. Odontólogo");
            Console.WriteLine("5. Psiquiatra");
            Console.WriteLine("6. Dermatólogo");
            Console.WriteLine("7. Ginecólogo");
            Console.WriteLine("8. Urólogo");
            Console.WriteLine("9. Endocrinólogo");
            Console.WriteLine("10. Otorrinolaringólogo");

            string eleccion = Console.ReadLine();


            switch (eleccion)
            {
                case "1":
                    especialidad = Especialidad.Traumatologo;
                    break;
                case "2":
                    especialidad = Especialidad.Cardiologo;
                    break;
                case "3":
                    especialidad = Especialidad.Oftalmologo;
                    break;
                case "4":
                    especialidad = Especialidad.Odontologo;
                    break;
                case "5":
                    especialidad = Especialidad.Psiquiatra;
                    break;
                case "6":
                    especialidad = Especialidad.Dermatologo;
                    break;
                case "7":
                    especialidad = Especialidad.Ginecologo;
                    break;
                case "8":
                    especialidad = Especialidad.Urologo;
                    break;
                case "9":
                    especialidad = Especialidad.Endocrinologo;
                    break;
                case "10":
                    especialidad = Especialidad.Otorrinolaringologo;
                    break;
                default:
                    Console.WriteLine("No existe esa especialidad");
                    break;

            }

            Medicos.Add(new Medico(nombre, DNI, especialidad));
        }

        public void BajaPaciente()
        {
            if (AdminActivo.Permiso != Permiso.Administrador)
            {
                throw new InvalidOperationException("No estás capacitado para esta acción");
            }

            foreach (var paciente in Pacientes)
            {
                Console.WriteLine($"{paciente.Nombre} | Médico: {paciente.MedicoCabecera.Nombre} | DNI: {paciente.DNI}");
            }

            Console.WriteLine("Identificación del paciente que desea dar de baja: ");
            string DNI = Console.ReadLine();

            Paciente pacienteBaja = Pacientes.Find(p => p.DNI == DNI);

            // Quitar este paciente de la lista de pacientes del médico
            pacienteBaja.BajaEfectiva(pacienteBaja.MedicoCabecera);

            bool exito = Pacientes.Remove(pacienteBaja);

            if (exito)
                Console.WriteLine("Eliminado con éxito");
            else
                Console.WriteLine("Ha habido un error al eliminar");
        }

        public void BajaMedico()
        {
            // Se da de baja a un médico de la lista
            if (AdminActivo.Permiso != Permiso.Administrador)
            {
                throw new InvalidOperationException("No estás capacitado para esta acción");
            }

            Console.WriteLine("MEDICOS: ");
            foreach (Medico medico in Medicos)
            {
                Console.WriteLine("- " + medico.ToString());
            }

            Console.WriteLine("Identificación del médico que quieres dar de baja: ");
            string dni = Console.ReadLine();

            Medico medicoBaja = Medicos.Find(m => m.DNI == dni);

            // Quitar a los pacientes asignados a este médico
            foreach (Paciente paciente in medicoBaja.PacientesAsignados)
            {
                paciente.MedicoCabecera = null;
            }

            // Eliminar al médico
            bool exito = Medicos.Remove(medicoBaja);

            if (exito)
                Console.WriteLine("Se ha eliminado correctamente.");
            else
                Console.WriteLine("Se ha producido un error o no se ha encontrado al médico.");
        }

        public void ReasignarMedico()
        {
            // Reasignar un médico a un paciente
            if (AdminActivo.Permiso != Permiso.Administrador)
            {
                throw new InvalidOperationException("No estás capacitado para esta acción");
            }

            Console.WriteLine("Identificación del paciente: ");
            string dniPaciente = Console.ReadLine();

            Paciente paciente = Pacientes.Find(p => p.DNI == dniPaciente);

            if (paciente == null)
            {
                Console.WriteLine("Paciente no encontrado");
                return;
            }

            Console.WriteLine("Identificación del médico: ");
            string dniMedico = Console.ReadLine();

            Medico medico = Medicos.Find(m => m.DNI == dniMedico);

            if (medico == null)
            {
                Console.WriteLine("Médico no encontrado");
                return;
            }

            // Asignar al nuevo médico
            paciente.MedicoCabecera = medico;
            medico.PacientesAsignados.Add(paciente);
        }

        public void PacientesSinMedico()
        {
            // Litar los pacientes que no tienen médico
            foreach (Paciente paciente in Pacientes)
            {
                if (paciente.MedicoCabecera == null)
                    Console.WriteLine("- " + paciente.ToString());
            }

            Console.WriteLine("Deseas asignar médico a alguno de estos pacientes? (s/n)");
            string sino = Console.ReadLine();

            if (sino == "s")
                ReasignarMedico();
            else
                return;

        }

        public void InicioSesion()
        {
            Console.WriteLine("Introduce identificación: ");
            string dni = Console.ReadLine();

            Console.WriteLine("Introduce contraseña: ");
            string passwd = Console.ReadLine();

            // Manejar el inicio de sesion comprobando si hay coincidencias
            var user = Administrativos.Find(a => a.DNI == dni && a.Contrasenia == passwd);

            AdminActivo = user;

            if (AdminActivo == null)
                InicioSesion();
        }

        public void CambiarEstado()
        {
            Console.WriteLine("DNI del paciente que deseas cambiar estado: ");
            string dni = Console.ReadLine();

            Paciente pacienteSeleccionado = Pacientes.Find(p => p.DNI == dni);
            string curado;

            if (pacienteSeleccionado.Curado)
                curado = "Curado";
            else
                curado = "Enfermo";

            Console.WriteLine($"{pacienteSeleccionado.Nombre} está {curado}. ¿Deseas cambiar su estado? (s/n)");
            string eleccion = Console.ReadLine();

            if (eleccion == "s")
            {
                pacienteSeleccionado.Curado = !pacienteSeleccionado.Curado;
                Console.WriteLine($"El estado de {pacienteSeleccionado.Nombre} ha sido cambiado");
                LeerPacientes(Pacientes);
            }
        }

        public void VerCitas()
        {
            foreach (Cita cita in Citas)
            {
                Console.WriteLine("- " + cita.ToString());
            }
        }

        public void CrearCita()
        {
            Console.WriteLine("Selecciona con su DNI el médico que atenderá la cita: ");
            foreach (Medico medico in Medicos)
            {
                Console.WriteLine("- " + medico.ToString());
            }
            string dniMedico = Console.ReadLine();

            var medicoCita = Medicos.Find(m => m.DNI == dniMedico);

            if(medicoCita == null)
            {
                Console.WriteLine("Médico no encontrado");
                return;
            }

            Console.WriteLine("Selecciona con su DNI el paciente que asistirá a la cita: ");
            foreach(Paciente paciente in Pacientes)
            {
                Console.WriteLine("- " + paciente.ToString());
            }
            string dniPaciente = Console.ReadLine();
            var pacienteCita = Pacientes.Find(p => p.DNI == dniPaciente);

            if (pacienteCita == null)
            {
                Console.WriteLine("Paciente no encontrado");
                return;
            }

            Console.WriteLine("Fecha de la cita: ");

            Console.WriteLine("Dia: ");
            string dia = Console.ReadLine();

            Console.WriteLine("Mes: ");
            string mes = Console.ReadLine();

            Console.WriteLine("Año: ");
            string anio = Console.ReadLine();

            Console.WriteLine("Hora: "); // ej. 18:30
            string hora = Console.ReadLine();

            DateTime fecha = DateTime.Parse($"{anio}/{mes}/{dia} {hora}");

            Console.WriteLine("Referencia de la cita: ");
            string referencia = Console.ReadLine();

            Citas.Add(new Cita { MedicoCita = medicoCita, PacienteCita = pacienteCita, Fecha = fecha, Referencia = referencia });

            Console.WriteLine("Cita creada con éxito.");
        }

        public void CancelarCita()
        {
            VerCitas();
            Console.WriteLine("Introduce la referencia de la cita que deseas cancelar: ");
            string referencia = Console.ReadLine();

            Cita cita = Citas.Find(c => c.Referencia == referencia);

            if (cita == null)
            {
                Console.WriteLine("Cita no encontrada");
                return;
            }

            Citas.Remove(cita);
            Console.WriteLine("Cita cancelada con éxito");
        }

        public void EditarCita()
        {
            VerCitas();
            Console.WriteLine("Introduce la referencia de la cita que deseas editar: ");
            string referencia = Console.ReadLine();
            Cita cita = Citas.Find(c => c.Referencia == referencia);

            if (cita == null)
            {
                Console.WriteLine("Cita no encontrada");
                return;
            }

            Console.WriteLine("Nueva fecha: ");

            Console.WriteLine("Dia: ");
            string dia = Console.ReadLine();

            Console.WriteLine("Mes: ");
            string mes = Console.ReadLine();

            Console.WriteLine("Año: ");
            string anio = Console.ReadLine();

            Console.WriteLine("Hora: ");
            string hora = Console.ReadLine();


            cita.Fecha = DateTime.Parse($"{anio}/{mes}/{dia} {hora}");

            Console.WriteLine("Médico: ");
            foreach (Medico medico in Medicos)
            {
                Console.WriteLine("- " + medico.ToString());
            }

            string dniMedico = Console.ReadLine();
            var nuevoMedico = Medicos.Find(m => m.DNI == dniMedico);

            if (nuevoMedico == null)
            {
                Console.WriteLine("Médico no encontrado");
                return;
            }

            cita.MedicoCita = nuevoMedico;

            Console.WriteLine("Cita modificada con éxito.");
        }

    }
}
