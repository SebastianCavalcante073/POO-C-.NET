namespace SobreposicaoPalavrasVirtualOverrideBase
{
    internal class PessoaFisica : Pessoa
    {
        // Propriedades 
        public  string Cpf { get; set; }
        // Construtores 
        public PessoaFisica() { }

        public PessoaFisica(string nome, string sobrenome, string cpf) : base (nome, sobrenome) 
        {
            Cpf = cpf;
        } // Construror Pessoa fisica padrão + implementação do construtor Pessoa usando o base para referênciar o construtor da classe Pessoa

        public override void ExibirPessoa() // Sobreposição de método 
        {
            base.ExibirPessoa();
            Console.WriteLine(Cpf);
        }
    }
}