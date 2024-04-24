namespace ClassesMetodosAbstratos2._2.Entities
{
    internal abstract class Pessoa // Classe abstrata 
    {
        // Propriedades
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        // Construtores
        public Pessoa() { }

        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        // Métodos
        public abstract double ImpostoRendaAnual(); // Método abstrato
    }
}