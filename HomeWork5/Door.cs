using System;

namespace HomeWork5
{
    public class Door : Car, IDoor
    {
        private int numberDoor;
        private bool isOpenDoor = true;

        public int NumberDoor
        {
            get { return numberDoor; }
        }

        public Door(int numberDoor) : base()
        {
            this.numberDoor = numberDoor;
        }

        public void Open()
        {
            Console.Write("Дверь № {0} машины {1} ", NumberDoor, ModelCar);
            Console.Write(isOpenDoor ? "открыта" : "закрыта");
            Console.WriteLine();
            isOpenDoor = !isOpenDoor;
        }
    }
}