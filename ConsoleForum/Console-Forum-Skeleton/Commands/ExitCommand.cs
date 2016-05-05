using ConsoleForum.Contracts;

namespace ConsoleForum.Commands
{
    public class ExitCommand : AbstractCommand
    {
        public ExitCommand(IForum forum) 
            : base(forum)
        {
        }

        public override void Execute()
        {
            this.Forum.HasStarted = false;
        }
    }
}
