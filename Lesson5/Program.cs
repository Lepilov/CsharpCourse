using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во колес : ");
            uint countWheels;
            if (!Utils.TryEnterNumberFromConsole(out countWheels))
            {
                HandleIncorrectEntar();
                return;
            }

            Console.Write("Введите кол-во дверей : ");
            uint countDoors;
            if (!Utils.TryEnterNumberFromConsole(out countDoors))
            {
                HandleIncorrectEntar();
                return;
            }

            Car car = new Car((int) countWheels, (int) countDoors, "Запорожец");

            foreach (Detail detail in car.Details)
            {
                IRotatable rotatableDetail = detail as IRotatable;
                if (rotatableDetail != null)
                {
                    rotatableDetail.Move();
                }
            }

            Console.Write("Введите номер двери : ");
            uint doorNumber;
            if (Utils.TryEnterNumberFromConsole(out doorNumber))
            {
                HandleIncorrectEntar();
                return;
            }
            foreach (Detail detail in car.Details)
            {
                Door door = detail as Door;
                if (door != null && door.Number == doorNumber - 1)
                {
                    door.Open();
                    break;
                }
            }

            Console.Read();
        }

        private static void HandleIncorrectEntar()
        {
            Console.WriteLine("Неккоректный ввод");
            Console.Read();
        }
    }
}
