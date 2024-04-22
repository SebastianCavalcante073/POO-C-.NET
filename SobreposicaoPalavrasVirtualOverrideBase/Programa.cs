using SobreposicaoPalavrasVirtualOverrideBase;
internal class Programa
{
    private static void Main(string[] args)
    {
        PessoaFisica pf = new PessoaFisica("Joao", "Carlos", "436.587.587.89"); // Instãncia da classe PessoaFisica 

        pf.ExibirPessoa();
    }
}