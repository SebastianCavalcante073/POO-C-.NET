using ClassesMetodosAbstratos2._2.Entities;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Entre com o números pagadores: ");
        int n = int.Parse(Console.ReadLine());

        List<Pessoa> pessoas = new List<Pessoa>(); // Instância uma lista vazia do tipo pessoa

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Pagador #{i}: ");
            Console.Write("Pessoa Fisíca ou Jurídica (f/j) ? ");
            char resp = char.Parse(Console.ReadLine().ToLower());

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Rendimento anual: ");
            double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (resp == 'f') // Verifica se a pessoa é PessoaFisica
            {
                Console.Write("Despesas médicas: ");
                double despesasMedicas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                pessoas.Add(new PessoaFisica(name, rendaAnual, despesasMedicas)); // Instância um objeto do tipo PessoaFisica e adiciona na lista pessoas. Upcasting
            }
            else if (resp == 'j') // Ferifica se é PessoaJuridica
            {
                Console.Write("Número de funcionarios: ");
                int nFuncionarios = int.Parse(Console.ReadLine());

                pessoas.Add(new PessoaJuridica(name, rendaAnual, nFuncionarios)); // Instância um objeto do tipo PessoaJuridica e adciona na lista pessoas. Upcasting
            }
        }

        Console.WriteLine("\nImpostos a pagar:");

        foreach (Pessoa p in pessoas) // Percorre a lista e imprime o valor do imposto a pagar.
        {
            Console.WriteLine(p.Nome
                + ": $ "
                + p.ImpostoRendaAnual().ToString("F2", CultureInfo.InvariantCulture)); // Aplicação polimorfica
        }

        Console.Write("Total a pagar em impostos: ");
        double totalImposto = 0.0;

        foreach (Pessoa p in pessoas) // Percorre a lista e soma todos os valores a pagar de todos os objetos da lista.
        { 
            totalImposto += p.ImpostoRendaAnual(); // Aplicação polimorfica
        }

        Console.WriteLine();
        Console.WriteLine(totalImposto.ToString("F2", CultureInfo.InvariantCulture));
    }
}