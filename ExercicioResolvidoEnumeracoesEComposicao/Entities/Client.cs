using System.Text;

namespace ExercicioResolvidoEnumeracoesEComposicao.Entities
{
    internal class Client
    {
        // Propriedades // Properties
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        // Construtores // Construtors
        public Client()
        {
        }
        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        // Métodos // Methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cliente: " + Name + " " + BirthDate.ToString("(dd/MM/yyyy)") + " - " + Email);
            return sb.ToString();
        }
    }
}
