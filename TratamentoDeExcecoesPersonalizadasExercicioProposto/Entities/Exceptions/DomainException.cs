namespace TratamentoDeExcecoesPersonalizadasExercicio.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { } // Construtor herda o atributo da classe ApplicationException
    }
}