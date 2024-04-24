using ClassesMetotosAbstratos.Entities.Enums;

namespace ClassesMetotosAbstratos.Entities
{
    internal abstract class Shape // Classe abstrata
    {
        // Propriedades
        public ColorShape ColorShape { get; set; }

        // Construtores
        protected Shape(ColorShape colorShape)
        {
            this.ColorShape = colorShape;
        }

        //Métodos 
        public abstract double Area(); // Método abstrato
    }
}