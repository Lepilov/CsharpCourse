using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2
{
    public class Employee : Person
    {
        public OperationTypes AllowedOperationTypes { get; private set; }

        public Employee(int number, string name, OperationTypes allowedOperationTypes) 
            : base(number, name)
        {
            AllowedOperationTypes = allowedOperationTypes;
        }

        public void List()
        {
            Console.WriteLine($"{this.Name}, {this.AllowedOperationTypes}");
        }
    }
}
