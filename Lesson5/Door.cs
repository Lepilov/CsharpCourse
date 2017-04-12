using System;

namespace Lesson5
{
    public class Door : Detail, IDoor
    {
        public override int Weight { get; set; }
        public override string Name { get; set; }
        public int Number { get; private set; }

        private bool isOpen = true;
        private Car ownerCar;

        public Door(int number, Car ownerCar)
        {
            this.Number = number;
            this.ownerCar = ownerCar;
        }

        public void Open()
        {
            string ownerCarModel = ownerCar != null ? ownerCar.Model ?? String.Empty : String.Empty;

            string openedDoorMessage = isOpen ? "открыта" : "закрыта";

            Console.WriteLine($"Дверь № {Number} машина {ownerCarModel} {openedDoorMessage}");
            
            isOpen = !isOpen;
        }
    }
}