namespace Classes_e_Metodos_Selados
{
    internal class Pessoa
    {
        // Propriedades
        public string Nome { get; set; }

        // Construtores
        public Pessoa() { }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        // Métodos 
        public virtual void MostrarDados()
        {
            Console.WriteLine($"Nome: {Nome}");
        }
    }
}