using System.Globalization;
using System.Text;

namespace ExercicioPropostoHerancaPolimorfismo
{
    internal class UsedProduct : Product
    {
        // Propriedades
        public DateTime ManufactureDate { get; set; }

        // Construtores
        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        } 

        // Métodos
        public override string PriceTag()
        {
            return Name 
                + " (used) $ " 
                + Price.ToString("F2", CultureInfo.InvariantCulture) 
                + " (Manufacture date: " 
                + ManufactureDate.ToString("dd/MM/yyyy)");
        } // Imprime os dados do produto 
    }
}