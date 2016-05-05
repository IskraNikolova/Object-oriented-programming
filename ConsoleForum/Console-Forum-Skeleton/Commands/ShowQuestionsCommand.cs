using System.Linq;
using System.Text;
using ConsoleForum.Contracts;

namespace ConsoleForum.Commands
{
    public class ShowQuestionsCommand : AbstractCommand
    {
        public ShowQuestionsCommand(IForum forum) 
            : base(forum)
        {
        }

        public override void Execute()
        {
            var questions = this.Forum.Questions;
            this.Forum.CurrentQuestion = null;

            if (!questions.Any())
            {
                this.Forum.Output.AppendLine(Messages.NoQuestions);
                return;
            }

            var orderedQuestion = questions.OrderBy(q => q.Id);
            StringBuilder showQuestion = new StringBuilder();
            foreach (var question in orderedQuestion)
            {
                showQuestion.AppendLine(question.ToString());
            }

            this.Forum.Output.Append(showQuestion);
        }
    }
}
