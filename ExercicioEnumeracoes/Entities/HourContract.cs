namespace Exercicio1.Entities
{
    internal class HourContract
    {
        // Properties
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }
        
        // Construtors
        public HourContract() {}

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        // Methods
        public double TotalValue()
        {
            return ValuePerHour * Hours;
        } // calculates the value of ValuePerHour * Hours and returns the multiplied value // Calcula o valor de ValuerPerHour * Hours e retorna o valor resultado
    }
}
