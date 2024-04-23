using ExercicioHerancaPolimorfismo;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Entre com o número de funcionarios: ");
        int n = int.Parse(Console.ReadLine());

        List<Employee> employees = new List<Employee>(); // Instância uma lista do tipo employee na memória 

        for (int i = 1; i <= n; i++) // Percorre a quantidade a quantidade de n funcionarios que serão adicionados na lista
        {
            // Escrita e leitura de dados
            Console.WriteLine($"Funcionario #{i}:");
            Console.Write("Funcionario Terceirizado (s/n) ? ");
            char op = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (op == 'S') // Verifica se o funcionario que está sendo adicional é ou não um funcionario terceirizado
            {
                Console.Write("Additional charge: ");
                double additionCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                employees.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionCharge)); // Instância um objeto convertido com upcasting é adiciona o funcionario terceirizado a lista

            } else if (op == 'N')
            {
                employees.Add(new Employee(name, hours, valuePerHour)); // Adicionao objeto funcionario na lista
            }
        }

        Console.WriteLine("\nPAYMENTS:");

        foreach (Employee employee1 in employees) // Percorre a lista employees instânciada e imprime os dados de forma polimorfica para cada tipo de especifico na lista 
        {
            Console.WriteLine(employee1.Name + " - $ " + employee1.Payment().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}