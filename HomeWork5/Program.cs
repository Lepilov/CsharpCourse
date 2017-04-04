using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car(5, 5);

            car.ModelCar = "МодельМ";

            foreach (var temp in car.carParts)
            {
                (temp as IRotatable)?.Move();
                (temp as IDoor)?.Open();
            }
            

            Console.Read();
        }
    }
}
