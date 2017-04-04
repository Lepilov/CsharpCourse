using System;

namespace HomeWork5
{
    public class Body : Car
    {
        public void Move()
        {
            Console.WriteLine("Машина {0} едет", ModelCar);
        }

        public void Open()
        {
            Console.WriteLine("Увы, это не дверь");
        }
    }
}