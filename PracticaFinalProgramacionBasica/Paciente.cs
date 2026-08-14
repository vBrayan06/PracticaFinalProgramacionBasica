using System;

namespace PracticaFinalProgramacionBasica
{

    public enum Sexo
    {
        Masculino,
        Femenino
    }

    public enum EstadoPaciente
    {
        Ingresado,
        EnObservacion,
        DeAlta,
        Hospitalizado
    }

    public class Paciente
    {
        public string Cedula { get; set; }
        public string Nombre_Completo { get; set; }
        public int Edad { get; set; }
        public Sexo Sexo { get; set; }
        public string Diagnostico { get; set; }
        public EstadoPaciente Estado { get; set; }
        public DateTime Fecha_De_Ingreso { get; set; }
    }
}
