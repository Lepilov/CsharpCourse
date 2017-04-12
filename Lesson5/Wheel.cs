using System;

namespace Lesson5
{
    public class Wheel : Detail, IRotatable
    {   
        public override int Weight { get; set; }
        public override string Name { get; set; }
        public int Number { get; private set; }

        private Car ownerCar;

        public Wheel(int number, Car ownerCar)
        {
            this.Number = number;
            this.ownerCar = ownerCar;
        }

        public void Move()
        {
            string carModel = ownerCar != null ? ownerCar.Model : string.Empty;//string.Empty  - пустая строка " ";
            Console.WriteLine($"Колесо № {Number} машины {carModel} вращается");
        }
    }
}