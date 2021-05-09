using ConsoleTimer.Core.Contracts;
using ConsoleTimer.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace ConsoleTimer.Core.Commands
{
    class ShutdownCommand : ICommand
    {
        private string[] inputArgs;
        public ShutdownCommand(string[] inputArgs)
        {
            this.inputArgs = inputArgs;
        }

        public string Execute()
        {
            int minutes = int.Parse(inputArgs[0]);
            int seconds = minutes.ToSeconds();
            Process.Start("shutdown", $"/s /t {seconds}");
            return $"The PC will shutdown after {minutes}";
        }
    }
}
