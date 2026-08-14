using System;

namespace PracticaFinalProgramacionBasica
{

    // Estas enumeraciones nos ayudan a limitar las opciones de sexo
    // para que el usuario no pueda escribir cualquier valor.
    public enum Sexo
    {
        Masculino,
        Femenino
    }

    // Aquí tenemos los diferentes estados que puede tener un paciente
    // dentro del centro de salud.
    public enum EstadoPaciente
    {
        Ingresado,
        EnObservacion,
        DeAlta,
        Hospitalizado
    }

    // Esta clase representa a cada paciente que vamos a guardar en el sistema.
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