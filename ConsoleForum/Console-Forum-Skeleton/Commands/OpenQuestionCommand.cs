using System.Linq;
using ConsoleForum.Contracts;

namespace ConsoleForum.Commands
{
    public class OpenQuestionCommand : AbstractCommand
    {
        public OpenQuestionCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            int idQuestion = int.Parse(this.Data[1]);
           
            var question = this.Forum.Questions.FirstOrDefault(q => q.Id == idQuestion);

            this.Forum.CurrentQuestion = question;

            if (question == null)
            {
                this.Forum.Output.AppendLine(Messages.NoQuestion);
                return;
            }

            this.Forum.Output.AppendLine(question.ToString());
        }
    }
}
