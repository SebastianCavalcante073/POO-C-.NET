namespace ExercicioHerancaPolimorfismo
{
    internal class OutSourcedEmployee : Employee // Classe OutSourcedEmployee herda atributos e comportamentos da classe Employee
    {
        // Propriedades
        public double AdditionalCharge { get; set; }

        // Construtores
        public OutSourcedEmployee()
        {
        }

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        // Métodos
        public sealed override double Payment()
        {
            double percentage = (AdditionalCharge * 110 / 100);
            return base.Payment() + percentage;
        } // Sobrecarga de método da classe Employee "Método selado"
    }
}
