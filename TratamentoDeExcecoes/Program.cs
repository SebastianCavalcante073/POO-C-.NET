internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int div = n1 / n2;

            Console.WriteLine(div);
        }
        
        catch (FormatException e) 
        {
            Console.WriteLine("Valor inserido não é um número");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Não é possivel dividir por 0 ");
        }
        catch (OverflowException e)
        {
            Console.WriteLine("Valor inserido maior que o suportado pelo tipo " + e.Message);
        }
    }
}