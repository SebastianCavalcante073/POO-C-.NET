using ExercicioStringBuilder.Entities;
internal class Program
{
    private static void Main(string[] args)
    {
        Post p = new Post(
            DateTime.Now,
            "Viajando para nova zelandia",
            "Eu estou visitando esse lindo país!",
            54); // instance an object with corresponding data // Instância um objeto com os dados correspondentes

        Comments c1 = new Comments("Que dahora!");  // Instance a comment // Instância um comentário
        Comments c2 = new Comments("Boas viagem!"); // Instance a comment // Instância um comentário

        p.AddComment(c1);   // Add the comment c1 in the list comments  // Adiciona o comentário do objeto c1 na lista comments
        p.AddComment(c2);   // Add the comment c2 in the list comments  // Adiciona o comentário do objeto c1 na lista comments

        Console.WriteLine(p + "\n");

        Post p2 = new Post(
            DateTime.Now,
            "Boa noite galera!",
            "Vejo vocês amanhã",
            20);    // instance an object with corresponding data // Instância um objeto com os dados correspondentes

        Comments c3 = new Comments("Boa noite!");   // Instance a comment // Instância um comentário
        Comments c4 = new Comments("Boaaaa");   // Instance a comment // Instância um comentário

        p2.AddComment(c3);  // Add the comment c3 in the list comments  // Adiciona o comentário do objeto c1 na lista comments
        p2.AddComment(c4);  // Add the comment c4 in the list comments  // Adiciona o comentário do objeto c1 na lista comments

        Console.WriteLine(p2);
    }
}