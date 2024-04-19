using System.Globalization;
using System.Text;

namespace ExercicioResolvidoEnumeracoesEComposicao.Entities
{
    internal class OrderItem
    {
        // Propriedads // Properties
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product product { get; set; }

        // Construtores // Construtors
        public OrderItem() { }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            this.product = product;
        }
        // Métodos  // Methods
        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(product.ToString());
            sb.Append("$" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", ");
            sb.Append("Quantidade: " + Quantity + ", ");
            sb.AppendLine("SubTotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        } // Saída de dados formatados // Output formated
    }
}
