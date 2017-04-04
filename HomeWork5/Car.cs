using System.Collections;

namespace HomeWork5
{
    public class Car : Detail
    {
        private static string modelCar;

        public Car[] carParts = new Car[3];

        public Car()
        {
        }

        public Car(int numberWheel, int numberDoor)
        {

            Wheel wheel = new Wheel(numberWheel);
            Door door = new Door(numberDoor);
            Body body = new Body();

            carParts[0] = wheel;
            carParts[1] = door;
            carParts[2] = body;
        }

        public string ModelCar
        {
            get { return modelCar; }
            set { modelCar = value; }
        }

        public override int WeightDetail { get; set; }

        public override string NameDetail { get; set; }

    }
}