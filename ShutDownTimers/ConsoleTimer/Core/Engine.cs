using ConsoleTimer.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTimer.Core
{
    class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;
        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }
        public void Run()
        {
            string[] args = Console.ReadLine().Split();

            try
            {
                var result = this.commandInterpreter.Read(args);
                Console.WriteLine(result);
            }
            catch (NotImplementedException m)
            {

                Console.WriteLine(m.Message);
            }
         
        }
    }
}
