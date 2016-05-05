using System;
using System.Runtime.Serialization;

namespace ConsoleForum.Commands.Exceptions
{
    public class CommandException : Exception, ISerializable
    {
        public CommandException(string message) 
            : base(message)
        { 
        }
    }
}
