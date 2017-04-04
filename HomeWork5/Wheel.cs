using System;

namespace HomeWork5
{
    public class Wheel : Car, IRotatable
    {
        private int numberWheel;

        public Wheel(int numberWheel)
        {
            this.numberWheel = numberWheel;
        }

        public int NumberWheel { get {return numberWheel;} }

        public void Move()
        {
            Console.WriteLine("Колесо № {0} машины {1} вращается", NumberWheel, ModelCar);
        }
    }
}