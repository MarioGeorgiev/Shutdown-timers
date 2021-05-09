using ConsoleTimer.Core.Commands;
using ConsoleTimer.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTimer.Core
{
    class CommandInterpreter : ICommandInterpreter
    {
        private ICommand command;
        public string Read(string[] args)
        {
            string action = args[0].ToLower();
            string[] inputArgs = args.Skip(1).ToArray();
            switch (action)
            {
                case "shutdown":
                    command = new ShutdownCommand(inputArgs);
                    break;
                case "restart":
                    command = new RestartCommand(inputArgs);
                    break;
                case "abort":
                    command = new AbortCommand();
                    break;
                case "exit":
                    command = new ExitCommand(); 
                    break;
                default:
                    throw new NotImplementedException("This command is not implemented");
                    
            }
            var result = command.Execute();
            return result;
        }
    }
}
