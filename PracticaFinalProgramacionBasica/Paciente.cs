using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaFinalProgramacionBasica
{

    public enum Sexo
    {
        Masculino,
        Femenino
    }

    public enum EstadoPciente
    {
        Ingresado,
        EnObservacion,
        DeAlta,
        Hospitalizado
    }

    internal class Paciente
    {
        public string Cedula { get; set; }
        public string NombreCompleto { get; set; }
        public int Edad { get; set; }
        public Sexo Sexo { get; set; }
        public string Diagnostico { get; set; }
        public EstadoPciente Estado { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
