namespace PracticaFinalProgramacionBasica
{
    // Esta excepción la hicimos específicamente para cuando se intenta
    // buscar un paciente que no existe en la lista.
    internal class PacienteNoEncontradoException : Exception
    {
        // Recibe el mensaje que queremos mostrar cuando ocurra este error.
        public PacienteNoEncontradoException(string mensaje) : base(mensaje)
        {
        }
    }
}