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

            printVehicleDetails(myCar);

            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Black";
            myTruck.TowingCapacity = 1200;

            printVehicleDetails(myTruck);
            Console.ReadLine();
        }

        private static void printVehicleDetails(Vehicle _vehicle) 
        {
            Console.WriteLine("Here are the vehicle's details: {0}",
                _vehicle.FormatMe());
        }
    }

    abstract class Vehicle 
    {
        public string Make { get; set; }
        public string  Model { get; set; }
        public int Year { get; set; }
        public string  Color { get; set; }

        //There is no defined body in an abstract method
        public abstract string FormatMe();
    }

    


    class Car : Vehicle
    {
        //public string Make { get; set; }
        //public string Model { get; set; }
        //public int Year { get; set; }
        //public string Color { get; set; }


        //"virtual" grants permission to be overriden.
        //"abstract" forces to override
        //"sealed" is the opposite of an abstract class, it means that overriding/inheritance is not permitted.

        //public virtual string FormatMe()
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Year,
                this.Color);
        }
    }

    sealed class Truck : Vehicle 
    {
        public int TowingCapacity { get; set; }


        //overriding a method from the superclass
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} Towing units",
                this.Make,
                this.Model,
                this.TowingCapacity);
        }
    }


}
