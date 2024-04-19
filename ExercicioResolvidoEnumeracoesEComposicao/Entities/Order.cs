using ExercicioResolvidoEnumeracoesEComposicao.Entities.Enum;
using System.Globalization;
using System.Text;

namespace ExercicioResolvidoEnumeracoesEComposicao.Entities
{
    internal class Order
    {
        // Propriedades // Properties
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public Client client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>(); // Lista de items // List of Items

        // Cosntrutores // Construtors
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            this.client = client;
        }

        // Métodos // Methods
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        } // Adiciona um item na lista // Add a item in the list

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        } // Remove um item da lista // Remove a item in the list

        public double Total()
        {
            double total = 0;
            foreach(OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        } // Calcula o valor total acumulado de cada item da lista // 

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nRESUMO DO PEDIDO: ");
            sb.AppendLine("Pedido Emitido: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine(client.ToString());
            sb.AppendLine("Items do pedido:");
            foreach(OrderItem item in Items)
            {
                sb.Append(item.ToString());
            }
            sb.AppendLine("Total: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        } // Saída de dados formatados  // Output formated
    }
}