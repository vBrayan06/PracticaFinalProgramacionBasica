using System.Collections.Generic;

namespace PracticaFinalProgramacionBasica
{
    public class GestorPacientes
    {
        // Esta es la lista donde se van guardando todos los pacientes
        // mientras el programa esté abierto.
        private List<Paciente> pacientes = new List<Paciente>();

        // Este método registra un paciente, pero primero revisa
        // que no exista otra persona con la misma cédula.
        public bool RegistrarPaciente(Paciente paciente)
        {
            if (ExisteID(paciente.Cedula))
            {
                return false;
            }

            pacientes.Add(paciente);
            return true;
        }

        // Recorremos la lista para comprobar si ya existe la cédula recibida.
        public bool ExisteID(string id)
        {
            foreach (Paciente paciente in pacientes)
            {
                if (paciente.Cedula == id)
                {
                    return true;
                }
            }

            return false;
        }

        // Busca un paciente por su cédula y devuelve el objeto completo.
        // Si no encuentra ninguno, devuelve null.
        public Paciente BuscarPorID(string id)
        {
            foreach (Paciente paciente in pacientes)
            {
                if (paciente.Cedula == id)
                {
                    return paciente;
                }
            }

            return null;
        }

        // En la búsqueda por nombre usamos otra lista porque puede haber
        // más de un paciente que tenga el mismo nombre o uno parecido.
        public List<Paciente> BuscarPorNombre(string nombre)
        {
            List<Paciente> pacientesEncontrados = new List<Paciente>();

            foreach (Paciente paciente in pacientes)
            {
                if (paciente.Nombre_Completo.ToLower().Contains(nombre.ToLower()))
                {
                    pacientesEncontrados.Add(paciente);
                }
            }

            return pacientesEncontrados;
        }

        // Devuelve la lista completa para poder mostrarla en los DataGridView.
        public List<Paciente> ObtenerPacientes()
        {
            return pacientes;
        }

        // Primero buscamos al paciente original por su cédula.
        // Si existe, reemplazamos sus datos por los datos actualizados.
        public bool ActualizarPaciente(Paciente pacienteActualizado)
        {
            Paciente paciente = BuscarPorID(pacienteActualizado.Cedula);

            if (paciente == null)
            {
                return false;
            }

            paciente.Nombre_Completo = pacienteActualizado.Nombre_Completo;
            paciente.Edad = pacienteActualizado.Edad;
            paciente.Sexo = pacienteActualizado.Sexo;
            paciente.Diagnostico = pacienteActualizado.Diagnostico;
            paciente.Estado = pacienteActualizado.Estado;
            paciente.Fecha_De_Ingreso = pacienteActualizado.Fecha_De_Ingreso;

            return true;
        }

        // Para eliminar primero buscamos el paciente.
        // Si aparece en la lista, usamos Remove para quitarlo.
        public bool EliminarPaciente(string id)
        {
            Paciente paciente = BuscarPorID(id);

            if (paciente == null)
            {
                return false;
            }

            pacientes.Remove(paciente);
            return true;
        }

    }
}