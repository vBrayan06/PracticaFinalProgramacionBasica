namespace PracticaFinalProgramacionBasica
{
    internal class PacienteNoEncontradoException : Exception
    {
        public PacienteNoEncontradoException(string mensaje) : base(mensaje)
        {
        }
    }
}