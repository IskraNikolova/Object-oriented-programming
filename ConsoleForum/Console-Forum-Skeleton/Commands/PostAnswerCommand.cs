using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;

namespace ConsoleForum.Commands
{
    public class PostAnswerCommand : AbstractCommand
    {
        public PostAnswerCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            string answerBody = this.Data[1];
            var user = this.Forum.CurrentUser;
            var answerId = this.Forum.Answers.Count + 1;

            if (!this.Forum.IsLogged)
            {
                this.Forum.Output.AppendLine(Messages.NotLogged);
                return;
            }

            if (this.Forum.CurrentQuestion == null)
            {
                this.Forum.Output.AppendLine(Messages.NoQuestionOpened);
                return;              
            }
            var answerForAdding = new Answer(answerId, answerBody, user);
            this.Forum.CurrentQuestion.Answers.Add(answerForAdding);
            this.Forum.Answers.Add(answerForAdding);
            this.Forum.Output.AppendFormat(Messages.PostAnswerSuccess, answerId).AppendLine();
        }
    }
}
