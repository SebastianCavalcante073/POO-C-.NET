using System.Text;

namespace ExercicioStringBuilder.Entities
{
    internal class Post
    {
        /* Properties */
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comments> comments { get; set; } = new List<Comments>();

        /* Construtors */
        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        /* Methods */
        public void AddComment(Comments comment)
        {
            comments.Add(comment);
        }   // add new comment in the list comments // Adiciona novo comentário na lista comments
        public void RemoveComment(Comments comment)
        {
            comments.Remove(comment);
        }   // Remove a comment in the list comments  // Remove um comentário da lista comments
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments");
            foreach (Comments comment in comments)
            {
                sb.AppendLine(comment.Text);
            }
            return sb.ToString();
        }   // Format the output data // Formata a saída de dados
    }
}