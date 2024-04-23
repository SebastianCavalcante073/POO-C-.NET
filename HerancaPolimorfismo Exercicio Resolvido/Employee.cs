namespace ExercicioHerancaPolimorfismo
{
    internal class Employee
    {
        // Propriedades 
        public string Name { get; set; }
        public  int  Hours { get; set; }
        public double ValuePerHour { get; set; }

        // Construtores
        public Employee()
        {
        }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        // Métodos
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }  // Retorna o valor total de Horas * o valor por hora
    }
}