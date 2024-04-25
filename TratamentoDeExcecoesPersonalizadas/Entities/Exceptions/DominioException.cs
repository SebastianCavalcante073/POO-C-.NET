namespace TratamentoDeExcecoesPersonalizadas.Entities.Exceptions
{
    internal class DominioException : ApplicationException // Classe DominioException herda os atributos e comportamentos de ApplicationException
    {
        public DominioException(string message) : base(message) // Construtor 
        {
        }
    }
}
