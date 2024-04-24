using System.Globalization;

namespace ClassesMetodosAbstratos2._2.Entities
{
    internal class PessoaFisica : Pessoa // Class PessoaFisica herda atributos e comportamentos da classe abstrata Pessoa
    {
        // Propriedades
        public double DespesasMedicas { get; set; }

        // Construtores
        public PessoaFisica() { }
        public PessoaFisica(string nome, double rendaAnual, double despesasMedicas) : base(nome, rendaAnual)
        {
            DespesasMedicas = despesasMedicas;
        }

        // Métodos
        public override double ImpostoRendaAnual() // Sobreposição obrigatoria de método abstrato
        {
            if (RendaAnual < 20000.00)
            {
                return RendaAnual * 0.15 - DespesasMedicas * 0.5;
            }
            else
            {
                return RendaAnual * 0.25 - DespesasMedicas * 0.5;
            }
        } // Calcula e retorna o valor do imposto a ser pago de acorto com a regra de negocio.
    }
}