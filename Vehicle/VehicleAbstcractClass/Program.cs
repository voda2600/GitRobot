using System;

namespace VehicleAbstcractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicleCar = new Car(218, 220);
            Vehicle vehicleBoard = new Ship(2, 10,"Bugulma","Kazan");
            Vehicle vehiclePlane = new Plane(220, 550, "Bugulma", "Moscow");
            vehicleCar.SpeedUp();
            Console.WriteLine(vehicleCar.Way()+"\n"+vehicleCar);
            vehiclePlane.SpeedDown();
            Console.WriteLine(vehiclePlane.Way() + "\n" + vehiclePlane);



        }
    }
}
