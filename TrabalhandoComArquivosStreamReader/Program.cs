internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"c:\temp\file1.txt"; // Variável path recebe o directorio do arquivo file1.txt na pasta temp

        StreamReader sr = null; // Define como null.

        try
        {
            sr = File.OpenText(path); // Instância o StreamReader e abre o arquivo.
            while (!sr.EndOfStream) // Faz a leitura de todas as linhas do arquivo.
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        } catch (IOException e) 
        {
            Console.WriteLine("Ocorreu um erro!");
            Console.WriteLine(e.Message);
        }
        finally // Vefica se o arquivo sr está aberto "!null" e então o fecha!
        {
            if (sr != null) sr.Close(); 
        }
    }
}