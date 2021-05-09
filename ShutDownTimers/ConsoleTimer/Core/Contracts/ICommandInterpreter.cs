using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTimer.Core.Contracts
{
    interface ICommandInterpreter
    {
        string Read(string[] args);
    }
}
