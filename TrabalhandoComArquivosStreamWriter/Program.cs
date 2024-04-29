internal class Program
{
    private static void Main(string[] args)
    {
        string sourcePath = @"c:\temp\file1.txt"; // Arquivo de origem
        string targetPath = @"c:\temp\file2.txt"; // Arquivo de destino

        try
        {
            string[] lines = File.ReadAllLines(sourcePath); // Cria uma lista para armazenar cada linha do arquivo de destino

            using (StreamWriter sw = File.AppendText(targetPath)) // Instância um objeto StreamWriter tendo como parâmetro o arquivo destino
            {
                foreach (string line in lines) // Percorre a lista
                {
                    sw.WriteLine(line.ToUpper()); // Escreve cada linha contida do arquivo origem para o arquivo destino formatado em letra Maiuscula
                }
            }
        }
        catch (IOException e) // Lança uma exceção IOException caso ocorra algum erro no bloco try.
        {
            Console.WriteLine("Ocorreu um erro! " + e.Message);
        }
    }
}