internal class Program
{
    private static void Main(string[] args)
    {
        /*Path
            • Namespace System.IO
            • Realiza operações com strings que contém informações de arquivos
            ou pastas. 
            • https://msdn.microsoft.com/en-us/library/system.io.path(v=vs.110).aspx
        */

        string path = @"C:\Temp\MyFolder";

        Console.WriteLine("Some Operations with Path Class: \n");

        Console.WriteLine("AltDirectorySeparatorChar: " + Path.AltDirectorySeparatorChar);
        Console.WriteLine("PathSeparator: " + Path.PathSeparator);
        Console.WriteLine("VolumeSeparatorChar: " + Path.VolumeSeparatorChar);
        Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
        Console.WriteLine("InvalidPathChars: " + Path.InvalidPathChars);
        Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
        Console.WriteLine("Combine: " + Path.Combine(path));
        Console.WriteLine("GetFileName: " + Path.GetFileName(path));
        Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("HasExtension: " + Path.HasExtension(path));
        Console.WriteLine(Path.GetFileName(path));
    }
}