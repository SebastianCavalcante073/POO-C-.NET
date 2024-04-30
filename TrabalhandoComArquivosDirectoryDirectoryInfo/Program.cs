internal class Program
{
    private static void Main(string[] args)
    {
        /*Directory, DirectoryInfo
            • Namespace System.IO
            • Operações com pastas (create, enumerate, get files, etc.).
            • Directory
            • static members (simple, but performs security check for each operation)
            • https://msdn.microsoft.com/en-us/library/system.io.directory(v=vs.110).aspx
            • DirectoryInfo
            • instance members

            Demo
                • Vamos listar as pastas a partir de uma pasta informada
                • Vamos listar os arquivos a partir de uma pasta informada
                • Vamos criar uma pasta
        */


        string path = @"C:\Temp";

        try
        {
            var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // Cria uma lista enumerada dos diretorios das pastas presentes no path
            Console.WriteLine("Folders");
            foreach (var item in folders) // Percorre a lista
            {
                Console.WriteLine(item);
            }

            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // Cria uma lista enumerada dos arquivos no directorio path
            Console.WriteLine("Files");
            foreach (var item in files)  // Percorre a lista
            {
                Console.WriteLine(item);
            }

            Directory.CreateDirectory(@"C:\Temp\NewFolder"); // Cria uma pasta NewFolder no directorio especificado

        }
        catch (IOException e)
        {
            Console.WriteLine("Ocorreu um erro! " + e.Message);
        }
    }
}