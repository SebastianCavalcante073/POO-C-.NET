using System.Globalization;

namespace ExercicioPropostoHerancaPolimorfismo
{
    internal class Product
    {
        // Propriedades 
        public string Name { get; set; }
        public double Price { get; set; }

        // Construtores 
        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // Métodos
        public virtual string PriceTag() // Método visivel para sobreposição
        {
            return Name 
                + " $ " 
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        } // Imprime os dados do produto
    }
}