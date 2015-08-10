using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;

            printCarDetails(myCar);

            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Black";
            myTruck.TowingCapacity = 1200;

            printCarDetails(myTruck);
            Console.ReadLine();
        }

        private static void printCarDetails(Car _car) 
        {
            Console.WriteLine("Here are the car's details: {0}",
                _car.FormatMe());
        }
    }

    class Car 
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Year,
                this.Color);
        }
    }

    class Truck : Car 
    {
        public int TowingCapacity { get; set; }

    }
}
