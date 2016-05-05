using System.Text;
using ConsoleForum.Contracts;

namespace ConsoleForum.Entities.Posts
{
    public class Answer : Post, IAnswer
    {
        public Answer(int id, string body, IUser author) 
            : base(id, body, author)
        {
        }

        public override string ToString()
        {
            StringBuilder answer = new StringBuilder();
            answer.AppendLine($"\n[ Answer ID: {this.Id} ]");
            answer.AppendLine($"Posted by: {this.Author.Username}");
            answer.AppendLine($"Answer Body: {this.Body}");
            answer.Append("--------------------");

            return answer.ToString();
        }
    }
}
