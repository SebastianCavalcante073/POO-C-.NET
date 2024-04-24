using ClassesMetotosAbstratos.Entities.Enums;
using System.Drawing;

namespace ClassesMetotosAbstratos.Entities
{
    internal class Rectangle : Shape // Classe Rectangle herda atributos e comportamentos da classe abstrata Shape
    {
        // Propriedades
        public double Width { get; set; }
        public double Heith { get; set; }

        // Construtores
        public Rectangle(double width, double heith, ColorShape colorShape) : base(colorShape)
        {
            Width = width;
            Heith = heith;
        }

        // Métodos
        public override double Area() // Sobreposição de método abstrato obrigatoria.
        {
            return Width * Heith;
        }
    }
}