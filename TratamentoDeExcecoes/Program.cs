internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o texto que ira exibir no bloco finally: ");
        string text = Console.ReadLine();

        try   // Bloco try tenta executar o código
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int div = n1 / n2;

            Console.WriteLine(div);
        }

        catch (FormatException e)  // Lança uma exceção informando que o valor inserido não é um número.
        {
            Console.WriteLine("Valor inserido não é um número");
        }
        catch (DivideByZeroException e) // Lança uma exceção informando que não pode ser feita a divisão por zero.
        {
            Console.WriteLine("Não é possivel dividir por 0 ");
        }
        catch (OverflowException e) // Lança uma exceção informando que foi excedido o valor máximo permitido pelo tipo de dados.
        {
            Console.WriteLine("Valor inserido maior que o suportado pelo tipo " + e.Message);
        }
        finally  // Executa o bloco finally quaisquer que seja o resultado do programa.
        {
            Console.WriteLine("Executando o bloco finally: " + text);
        }
    }
}