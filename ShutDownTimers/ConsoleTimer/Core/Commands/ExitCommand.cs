using ConsoleTimer.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleTimer.Core.Commands
{
    class ExitCommand : ICommand
    {
        public string Execute()
        {
            Console.WriteLine("Bye!!!");
            Environment.Exit(0);
            return "Bye bye";
        }
    }
}
