using ConsoleForum.Contracts;

namespace ConsoleForum.Entities.Posts
{
    public class BestAnswer: Answer
    {
        public BestAnswer(int id, string body, IUser author) 
            : base(id, body, author)
        {
        }

        public override string ToString()
        {
            
            return "\n********************" + base.ToString() + "\n********************";
        }
    }
}
