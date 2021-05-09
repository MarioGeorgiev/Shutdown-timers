using ConsoleTimer.Core.Contracts;
using ConsoleTimer.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleTimer.Core.Commands
{
    class RestartCommand : ICommand
    {
        private string[] inputArgs;
        public RestartCommand(string[] inputArgs)
        {
            this.inputArgs = inputArgs;
        }

        public string Execute()
        {
            int minutes = int.Parse(inputArgs[0]);
            int seconds = minutes.ToSeconds();
            Process.Start("shutdown", $"/r /t {seconds}");
            return $"The PC will restart after {minutes}";
        }
    }
}
