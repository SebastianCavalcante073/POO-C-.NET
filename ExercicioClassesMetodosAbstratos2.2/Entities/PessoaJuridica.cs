namespace ClassesMetodosAbstratos2._2.Entities
{
    internal class PessoaJuridica : Pessoa // Classe PessoaJuridica herda atributos e comportamentos da classe abstrata Pessoa
    {
        // Propriedades
        public int QuantidadeFuncionarios { get; set; }

        // Construtores
        public PessoaJuridica() { }

        public PessoaJuridica(string nome, double rendaAnual, int quantidadeFuncionarios) : base(nome, rendaAnual)
        {
            QuantidadeFuncionarios = quantidadeFuncionarios;
        }

        // Métodos
        public override double ImpostoRendaAnual() // Sobreposição obrigatoria de método abstrato.
        {
            if (QuantidadeFuncionarios <= 10)
            {
                return RendaAnual * 0.16;
            }
            else
            {
                return RendaAnual * 0.14;
            }
        }// Calcula e retorna o valor do imposto a ser pago de acordo com a regra de negocio.
    }
}