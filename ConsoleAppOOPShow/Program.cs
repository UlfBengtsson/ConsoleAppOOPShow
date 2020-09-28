using System;
using System.Collections.Generic;

namespace ConsoleAppOOPShow
{
    // defualt accsses is Private
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            Console.WriteLine("Amount of cars: " + Car.Counter);

            //Car myCar = new Car(2000, "BMW", "525i");

            //myCar.color = "Blue";

            //myCar.RegPlate = "abc123";

            cars.Add(new Car(2000, "BMW", "525i", "Blue","abc123"));

            Console.WriteLine("Amount of cars: " + Car.Counter);
            //Console.WriteLine(myCar.CarInfomation());

            //Car odin = new Car(2012, "Volvo", "XC90");

            //odin.color = "Gray";
            //odin.RegPlate = "QWe098";

            cars.Add(new Car(2012, "Volvo", "XC90", "Gray", "QWe098"));

            Console.WriteLine("Amount of cars: " + Car.Counter);
            //Console.WriteLine(odin.CarInfomation());

            //Car erik = new Car(2008, "Opel", "Astra", "Yellow", "zxc456");

            //Console.WriteLine(erik.CarInfomation());

            cars.Add(new Car(2008, "Opel", "Astra", "Yellow", "zxc456"));

            Console.WriteLine("Amount of cars: " + Car.Counter);

            foreach (Car aCar in cars)
            {
                Console.WriteLine(aCar.CarInfomation());
            }
        }
    }
}
