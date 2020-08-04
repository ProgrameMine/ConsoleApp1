using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name { get; set; }

        public string Application { get; set; }

        public string Age { get; set; }

        public Person(string name, string application)
        {
            Name = name;
            Application = application;
        }
    }
}
