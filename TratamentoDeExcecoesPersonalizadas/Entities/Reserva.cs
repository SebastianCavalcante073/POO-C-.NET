using TratamentoDeExcecoesPersonalizadas.Entities.Exceptions;

namespace TratamentoDeExcecoesPersonalizadas.Entities
{
    internal class Reserva
    {
        // Propriedades 
        public int NumeroQuarto { get; set; }
        public DateTime Chegada { get; set; }
        public DateTime Saida { get; set; }

        // Construtores
        public Reserva() { }

        public Reserva(int numeroQuarto, DateTime chegada, DateTime saida)
        {
            if (chegada > saida)
            {
                throw new DominioException("Não é possivel incluir uma data de saida menor que a de chegada!");
            } // Lança uma exceção caso a data de chegada seja maior que a de saída!

            NumeroQuarto = numeroQuarto;
            Chegada = chegada;
            Saida = saida;
        }

        // Métodos
        public int DuracaoEstadia()
        {
            TimeSpan totalDias = Saida.Subtract(Chegada);
            return (int)totalDias.Days;
        } // Calcula a duração em dias subtraindo os valores da saída menos a chegada.

        public void AtualizarDatas(DateTime chegada, DateTime saida)
        {
            DateTime now = DateTime.Now; // Captura e armazena a data atual do sistema.

            if (chegada < now || saida < now)
            {
                throw new DominioException("Não é possivel atualizar a data para uma data antes de hoje!");
            } // Lança uma exceção caso a data de chegada ou de saida sejam menores que a data atual do sistema!
            if (saida < chegada)
            {
                throw new DominioException("Não é possivel atualizar a data pois a data de saida e menor que a de chegada!");
            } // Lança um exceção caso a data de saída seja menor que a de chegada!

            Chegada = chegada;
            Saida = saida;
        } // Atualiza as datas das reservas já instânciadas 

        public override string ToString() // Imprime os dados na tela de acordo com a regra solicitada.
        {
            return "Reseva: "
                + "Quarto "
                + NumeroQuarto
                + ", "
                + "Chegada: "
                + Chegada.ToString("dd/MM/yyyy")
                + ", "
                + "Saída: "
                + Saida.ToString("dd/MM/yyyy")
                + ", "
                + DuracaoEstadia()
                + " Noites";
        }
    }
}