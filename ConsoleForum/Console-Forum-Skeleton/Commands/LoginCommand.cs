using System.Linq;
using ConsoleForum.Commands.Exceptions;
using ConsoleForum.Contracts;
using ConsoleForum.Utility;

namespace ConsoleForum.Commands
{
    public class LoginCommand : AbstractCommand
    {
        public LoginCommand(IForum forum) 
            : base(forum)
        {
        }

        public override void Execute()
        {
            if (this.Forum.IsLogged)
            {
                throw new CommandException(Messages.AlreadyLoggedIn);
            }

            string username = this.Data[1];
            string password = PasswordUtility.Hash(this.Data[2]);

            var user = this.Forum.Users.FirstOrDefault(u => u.Username == username);

            if (user == null || user.Password != password)
            {
                throw new CommandException(Messages.InvalidLoginDetails);
            }

            this.Forum.CurrentUser = user;

            this.Forum.Output.AppendFormat(Messages.LoginSuccess, user.Username).AppendLine();
        }
    }
}
