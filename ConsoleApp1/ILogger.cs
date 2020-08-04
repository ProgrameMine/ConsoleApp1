using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface ILogger
    {
        void Log(string message);

        public void Log(Exception ex) => Log(ExceptionHeader + ex.Message);

        static string ExceptionHeader = "Exception:";
    }
}
