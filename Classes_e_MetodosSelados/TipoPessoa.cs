namespace Classes_e_Metodos_Selados
{
    internal sealed class TipoPessoa // Classe selada!   Uma classe selada impede que a mesma seja uma superclasse de uma subclasse por meio de herânça
    {
        // Propriedades
        public string Nome { get; set; }

        // Construtores
        public TipoPessoa() { }

        public TipoPessoa(string nome)
        {
            Nome = nome;
        }
    }
}