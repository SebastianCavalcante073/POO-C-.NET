using ExercicioResolvidoEnumeracoesEComposicao.Entities;
using ExercicioResolvidoEnumeracoesEComposicao.Entities.Enum;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entre com os dados do cliente: ");
        Console.Write("Nome: ");
        string name = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Data de nascimento: (DD/MM/YYYY): ");
        DateTime dateBirth = DateTime.Parse(Console.ReadLine());

        Client client = new Client(name, email, dateBirth); // Instância um novo objeto cliente na memória com os dados por parâmetro
        
        Console.WriteLine("Entre com os dados do pedido: ");
        Console.Write("Status do pedido: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()); // Converte os dados de string para o tipo enum 

        Order order = new Order(DateTime.Now, status, client);  // Instância um novo objeto Order na memória com os dados por parâmetro

        Console.Write("Quantos items quer adicionar no pedido ? ");

        int qtd = int.Parse(Console.ReadLine());

        for (int i = 1; i <= qtd; i++)
        {
            Console.WriteLine($"Entre com os dados do #{i} pedido: ");
            Console.Write("Nome do produto: ");
            string productName = Console.ReadLine();
            Console.Write("Preço do produto: ");
            double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Product product = new Product(productName, productPrice);   // Instância um novo objeto Produtct na memória com os dados por parâmetro

            Console.Write("Quantidade: ");
            int quantity = int.Parse(Console.ReadLine());

            OrderItem item = new OrderItem(quantity, productPrice, product); // Instância um novo objeto item na memória com os dados por parâmetro

            order.AddItem(item);
        }

        Console.WriteLine(order);

    }
}