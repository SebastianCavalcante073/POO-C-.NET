using Exercicio1.Entities.Enums;

namespace Exercicio1.Entities
{
    internal class Worker
    {
        // Properties
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public  double BaseSalary { get; set; }
        public Department department { get; set; } // Associação para todo existe um 
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // associação todo parte "Lista de contratos"

        // Construtors
        public Worker() {}

        public Worker(string name, WorkLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            this.department = department;
        }
        
        //Methods
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        } // Add new contract for the worker  // Adiciona um novo contrato ao trabalhador

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        } // Remove a contract this worker // Remove um contrato do trabalhador

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        } // CHECKS the year and months present in the list of contracts and returns the total amount earned in the month // 
          // Verifica o ano e mes presentes na lista de contratos e retorna o valor total ganho de um mês especificado!
    }
}
