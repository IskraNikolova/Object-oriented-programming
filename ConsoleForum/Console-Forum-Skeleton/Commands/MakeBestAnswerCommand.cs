using System.Linq;
using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;

namespace ConsoleForum.Commands
{
    public class MakeBestAnswerCommand : AbstractCommand
    {
        public MakeBestAnswerCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            int answerId = int.Parse(this.Data[1]);
            var currentQuestion = this.Forum.CurrentQuestion;

            if (!this.Forum.IsLogged)
            {
                this.Forum.Output.AppendLine(Messages.NotLogged);
                return;
            }

            if (currentQuestion == null)
            {
                this.Forum.Output.AppendLine(Messages.NoQuestionOpened);
                return;
            }

            var answer = this.Forum.CurrentQuestion.Answers.FirstOrDefault(q => q.Id == answerId);
            
            if (answer == null)
            {
                this.Forum.Output.AppendLine(Messages.NoAnswer);
                return;
            }

            if (this.Forum.CurrentUser != this.Forum.CurrentQuestion.Author &&
                !(this.Forum.CurrentUser is IAdministrator))
            {
                this.Forum.Output.AppendLine(Messages.NoPermission);
                return;
            }

            var bestAnswer = new BestAnswer(answerId, answer.Body, answer.Author);
            currentQuestion.Answers.Add(bestAnswer);
            this.Forum.Answers.Add(bestAnswer);

            currentQuestion.Answers.Remove(answer);
            this.Forum.Answers.Remove(answer);
            
            this.Forum.Output.AppendFormat(Messages.BestAnswerSuccess, answerId).AppendLine();
        }
    }
}
