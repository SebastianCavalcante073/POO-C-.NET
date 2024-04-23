namespace Classes_e_Metodos_Selados
{
    internal class PessoaFisica : Pessoa // Classe PessoaFisica extende classe Pessoa!
    {
        // Métodos Selados
        public sealed override void MostrarDados() // Método selado! Um método selado impede que o mesmo seja novamente sobrescrito em outras subclasses
        {
            base.MostrarDados();
        }
    }
}