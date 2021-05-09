using ConsoleTimer.Core;
using ConsoleTimer.Core.Contracts;
using System;

namespace ConsoleTimer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            Engine engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
