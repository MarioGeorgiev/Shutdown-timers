using ConsoleTimer.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace ConsoleTimer.Core.Commands
{
    class AbortCommand : ICommand
    {
        public string Execute()
        {
            Process.Start("shutdown", $"/a");
            return "Command aborted!";
        }
    }
}
