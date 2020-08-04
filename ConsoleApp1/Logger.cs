using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Logger : ILogger
    {
        public void Log(string message) => Console.WriteLine(message);
    }
}
