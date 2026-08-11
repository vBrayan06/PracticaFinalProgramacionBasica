using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaFinalProgramacionBasica
{
    public class GestorPacientes
    {
        private List<Paciente> pacientes = new List<Paciente>();

        public bool RegistrarPaciente(Paciente paciente)
        {
            if (ExisteID(paciente.Cedula))
            {
                return false;
            }

            pacientes.Add(paciente);
            return true;
        }

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

        public List<Paciente> ObtenerPacientes()
        {
            return pacientes;
        }

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
