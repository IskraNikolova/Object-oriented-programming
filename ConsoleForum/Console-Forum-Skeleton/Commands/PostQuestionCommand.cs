using ConsoleForum.Entities.Posts;

namespace ConsoleForum.Commands
{
    using System.Linq;
    using ConsoleForum.Contracts;

    public class PostQuestionCommand : AbstractCommand
    {
        public PostQuestionCommand(IForum forum) 
            : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.IsLogged)
            {
                this.Forum.Output.AppendLine("Operation not permitted. You have to login first");
                return;
            }

            string title = this.Data[1];
            string body = this.Data[2];

            var user = this.Forum.CurrentUser;
            var id = this.Forum.Questions.Count + 1;
            this.Forum.Questions.Add(new Question(id, body, user, title));
            this.Forum.Output.AppendLine($"Question with Id: {id} successfully posted");
        }
    }
}
