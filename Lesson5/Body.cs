using System;

namespace Lesson5
{
    public class Body : Detail, IRotatable
    {
        public override int Weight { get; set; }
        public override string Name { get; set; }

        private Car ownerCar;

        public Body(Car ownerCar)
        {
            this.ownerCar = ownerCar;
        }

        public void Move()
        {
            string ownerCarModel = ownerCar != null ? ownerCar.Model : String.Empty;
            Console.WriteLine($"Машина {ownerCarModel} едет");
        }
    }
}