namespace Kermen.Core
{
    public class Command
    {
        public string TakeCommandName(string input)
        {
            string commandName = string.Empty;
            int indexOfOpenBracket = input.IndexOf("(");
            if (input.Contains("("))
            {
                commandName = input.Substring(0, indexOfOpenBracket);
            }
            else
            {
                commandName = input;
            }
           
            return commandName;
        }
    }
}
