using System.Linq;
using System.Text;

namespace ConsoleForum.Entities.Posts
{
    using System.Collections.Generic;
    using ConsoleForum.Contracts;

    public class Question : Post, IQuestion
    {
        public Question(int id, string body, IUser author, string title) 
            : base(id, body, author)
        {
            this.Title = title;
            this.Answers = new List<IAnswer>();
        }

        public string Title { get; set; }

        public IList<IAnswer> Answers { get; private set; }

        public override string ToString()
        {
            StringBuilder answers = new StringBuilder();
    
            if (this.Answers.Any())
            {
                answers.Append("\nAnswers:");
                var bestAnswer = GetBestAnswer();
                if (bestAnswer != null)
                {
                    answers.Append(bestAnswer);
                }

                var orderedRegularAnswer = GetRegularAnswers();

                foreach (var a in orderedRegularAnswer)
                {
                    answers.Append(a);
                }
            }
            else
            {
                answers.Append("\nNo answers");
            }

            StringBuilder question = new StringBuilder();
            question.AppendLine($"[ Question ID: {this.Id} ]");
            question.AppendLine($"Posted by: {this.Author.Username}");
            question.AppendLine($"Question Title: {this.Title}");
            question.AppendLine($"Question Body: {this.Body}");
            question.Append("====================");
            question.Append(answers);

            return question.ToString();
        }

        private List<IAnswer> GetRegularAnswers()
        {
            var ordered = this.Answers
                .Where(a => !(a is BestAnswer))
                .OrderBy(a => a.Id)
                .ToList();

            return ordered;
        }

        private IAnswer GetBestAnswer()
        {
            var bestAnswer = this.Answers.FirstOrDefault(a => a is BestAnswer);
            return bestAnswer;
        }
    }
}
