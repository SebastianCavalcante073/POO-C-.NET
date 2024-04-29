internal class Program
{
    private static void Main(string[] args)
    {
        /*
            using block
            https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement
            Sintaxe simplificada que garante que os objetos IDisposable serão fechados.
            Objetos IDisposable NÃO são gerenciados pelo CLR. Eles precisam ser 
            manualmente fechados.
            Exemplos: Font, FileStream, StreamReader, StreamWrite
        */

        string path = @"c:\temp\file1.txt"; // Varíavel path armazena o directorio do arquivo file1.txt

        try
        {
            using (StreamReader sr = File.OpenText(path)) // Instância um objeto do tipo StreamReader tendo como parâmetro o directorio de path.
            {
                 while (!sr.EndOfStream) // Percorre todas as linhas do arquivo file1.txt
                {
                    string line = sr.ReadLine(); // Recebe o valor de linha por linha do arquivo file1.txt 
                    Console.WriteLine(line);
                }
            }
        } catch (IOException e)
        {
            Console.WriteLine("Ocorreu um erro!\n" + e.Message);
        }
    }
}