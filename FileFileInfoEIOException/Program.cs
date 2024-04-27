internal class Program
{
    private static void Main(string[] args)
    { 
        string sourcePath = @"c:\temp\file1.txt"; // Variável sourcePath armazena o caminho onde se encontra o arquivo file1.txt
         
        string targePath = @"c:\temp\file2.txt"; // Variável sourcePath armazena o caminho onde se encontra o arquivo file2.txt

        try
        {
            FileInfo fileInfo = new FileInfo(sourcePath); // Instância um objeto do tipo fileInfo
            //fileInfo.CopyTo(targePath); //Copia  o contéu do arquivo file1 e salva no arquivo file2

            string[] s = File.ReadAllLines(sourcePath); // Armazera em vetor o conteudo de sourcepath

            foreach(string s2 in s) // percorre o vetor
            {
                Console.WriteLine(s2); // Imprime na tela
            }
        }
        catch (IOException e) // Lança uma exceção caso ocorra algum erro!
        {
            Console.WriteLine("Ocorreu um erro! " + e.Message);
        }
    }
}