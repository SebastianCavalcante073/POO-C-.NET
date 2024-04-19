using System.Text;

namespace ExercicioResolvidoEnumeracoesEComposicao.Entities
{
    internal class Product
    {
        //Propriedades // Properties
        public string Name { get; set; }
        public double Price { get; set; }

        // Construtores // Construtors
        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + ", ");
            return sb.ToString();
        } // Saída de dados formatada, Output formated
    }
}