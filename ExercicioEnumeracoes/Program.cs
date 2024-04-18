using Exercicio1.Entities;
using Exercicio1.Entities.Enums;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Entre com o nome do departamento: "); 
        string deptName = Console.ReadLine();   // Reference variable // Variável de referência

        Console.WriteLine("Entre com o dados do trabalhador: ");
        Console.Write("Name: ");
        string name = Console.ReadLine();   // Reference variable // Variável de referência

        Console.Write("Level (Junior/MidLevel/Senior): ");
        WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());    // Reference variable // Variável de referência

        Console.Write("Base Salary: ");
        double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Reference variable // Variável de referência

        // Creating the objects in the memory // Criando os objetos na memória
        Department department = new Department(deptName);
        Worker worker = new Worker(name, level, baseSalary, department);

        Console.Write("Quantos contratos para esse trabalhador ? ");
        int n = int.Parse(Console.ReadLine());

        // additing new contracts in the memory // Adicionando novos contratos na memória
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Entre com os dados do contrato #{i}");
            Console.Write("Data (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor por hora: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Duração em hours: ");
            int hours = int.Parse(Console.ReadLine());

            HourContract contract = new HourContract(date, valuePerHour, hours);
            worker.AddContract(contract);
        }

        Console.Write("Entre com o mes e ano para calcular o ganho! (MM/YYYY) : ");
        
        string monthAndYear = Console.ReadLine();
        int month = int.Parse(monthAndYear.Substring(0, 2));
        int year = int.Parse(monthAndYear.Substring(3));

        Console.WriteLine("Name: " + worker.Name);
        Console.WriteLine("Departament: " + worker.department.Name);
        Console.WriteLine("Ganho no mes: " + monthAndYear + ": " + worker.Income(year, month));
    }
}