using ExercicioPropostoHerancaPolimorfismo;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /* ENUNCIADO: 
            Fazer um programa para ler os dados de N produtos (N fornecido pelo usuário). Ao final, mostrar a etiqueta de preço de cada produto na mesma ordem em que foram digitados.
            Todo produto possui nome e preço. Produtos importados possuem uma taxa de alfândega, e produtos usados possuem data de fabricação.
            Estes dados específicos devem ser acrescentados na etiqueta de preço conforme exemplo (próxima página). 
            Para produtos importados, a taxa e alfândega deve ser acrescentada ao preço final do produto
        */

        Console.Write("Entre com o número de produtos: ");
        int numbersQuantity = int.Parse(Console.ReadLine());

        List<Product> products = new List<Product>();

        for (int i = 1; i <= numbersQuantity; i++)
        {
            Console.WriteLine($"Produto #{i}");
            Console.Write("Produto comum, usado ou importado (c,u,i) ? ");
            char resp = char.Parse(Console.ReadLine().ToLower());

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (resp == 'c')
            {
                products.Add(new Product(name, price));
            } else if (resp == 'u')
            {
                Console.Write("Qual a data de fabricação ? ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                products.Add(new UsedProduct(name, price, date));

            } else if (resp == 'i')
            {
                Console.Write("Qual o preço de importação: ");
                double importedPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                products.Add(new ImportedProduct(name, price, importedPrice));
            }
        }

        Console.WriteLine("\nPRICE TAGS:");

        foreach(Product product in products)
        {
            Console.WriteLine(product.PriceTag());
        }
    }
}