namespace SobreposicaoPalavrasVirtualOverrideBase
{
    internal class Pessoa
    {
        // Propriedades
        public string Nome { get; set; }
        public string  Sobrenome { get; set; }  

        // Construtores
        public Pessoa() { } 
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // Métodos
        public virtual void ExibirPessoa() // Virtual
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Sobrenome: {Sobrenome}");
        }
    }
}