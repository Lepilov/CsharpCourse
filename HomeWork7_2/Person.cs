using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2
{
    public abstract class Person
    {
        public int Number { get; private set; }
        public string Name { get; private set; }

        public Person(int number, string name)
        {
            Number = number;
            Name = name;
        }
    }
}
