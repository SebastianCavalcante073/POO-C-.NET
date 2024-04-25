using TratamentoDeExcecoesPersonalizadas.Entities;
using TratamentoDeExcecoesPersonalizadas.Entities.Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("Número do quarto: ");
            int quarto = int.Parse(Console.ReadLine());

            Console.Write("Data de chegada: (dia/mês/ano): ");
            DateTime chegada = DateTime.Parse(Console.ReadLine());
            Console.Write("Data de saída: (dia/mês/ano): ");
            DateTime saida = DateTime.Parse(Console.ReadLine());

            Reserva reserva = new Reserva(quarto, chegada, saida); // Instância uma reserva com os dados fornecidos em parâmetros

            Console.WriteLine(reserva);

            Console.WriteLine("Entre com a data para atualizar a reserva: ");
            Console.Write("Chegada (dia/mês/ano): ");
            chegada = DateTime.Parse(Console.ReadLine());
            Console.Write("Saída (dia/mês/ano): ");
            saida = DateTime.Parse(Console.ReadLine());

            reserva.AtualizarDatas(chegada, saida); // Atualiza as datas da reserva já instânciada.

            Console.WriteLine(reserva);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Dados fornecidos não são compativeis com os solicitado! " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Outras Exceções" + e.Message);
        }
    }
}