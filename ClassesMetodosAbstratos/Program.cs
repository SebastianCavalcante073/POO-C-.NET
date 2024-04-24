using ClassesMetotosAbstratos.Entities;
using ClassesMetotosAbstratos.Entities.Enums;
using System.Globalization;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter  the number of shapes: ");
        int n = int.Parse(Console.ReadLine());

        List<Shape> shapes = new List<Shape>(); // Instância uma lista do tipo Shape


        for (int i = 1; i <= n; i++) // Percorre a lista e adiciona um objeto de acorto com o seu tipo
        {
            Console.Write($"Shape #{i} data: ");
            Console.Write("Rectangle or Circle (r/c) ? ");
            char resp = char.Parse(Console.ReadLine().ToLower());

            Console.Write("Color (Black/Blue/Red): ");
            ColorShape colorShape = Enum.Parse<ColorShape>(Console.ReadLine()); // Converte o Console.ReadLine() de string para o tipo enum

            if (resp == 'r') // Verifica se será a figuta é um Retangulo
            {
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Heith: ");
                double heith = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                shapes.Add(new ClassesMetotosAbstratos.Entities.Rectangle(width, heith, colorShape)); // Instância um objeto do tipo Rectanglo e adiciona na lista
            }
            else if (resp == 'c') // Verifica se será a figuta é um Circulo
            {
                Console.Write("Radius: ");
                double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                shapes.Add(new Circle(radius, colorShape)); // Instância um objeto do tipo Circle e adiciona na lista
            }
        }

        Console.WriteLine();
        Console.WriteLine("SHAPES AREAS:");
        foreach (Shape shape in shapes) // Percorre toda a lista imprimindo os dados referênte a cada tipo de figura.
        {
            Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}