using ClassesMetotosAbstratos.Entities.Enums;

namespace ClassesMetotosAbstratos.Entities
{
    internal class Circle : Shape // Classe Circle herda atributos e comportamentos da classe abstrata Shape
    {
        // Propriedades
        public double Radius { get; set; }

        // Construtores
        public Circle(double radius, ColorShape colorShape) : base(colorShape)
        {
            Radius = radius;
        }

        // Métodos
        public override double Area() // Sobreposição de método abstrato obrigatoria.
        {
            return Math.PI * Radius * Radius;
        }
    }
}