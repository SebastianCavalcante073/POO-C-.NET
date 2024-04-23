using System.Globalization;

namespace ExercicioPropostoHerancaPolimorfismo
{
    internal class ImportedProduct : Product
    {
        // Propriedades
        public double CustomsFee { get; set; }

        //Construtores
        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        // Métodos
        public override string PriceTag() // Método sobrescrito da classe Product
        {
            return Name 
                + " $ " 
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) 
                + " (Custom fee: $ " 
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) 
                + ")";
        } // Imprime os dados do produto 

        public double TotalPrice()
        {
            return Price + CustomsFee;
        } // Soma o valor do produto com o valor de custod e importação
    }
}