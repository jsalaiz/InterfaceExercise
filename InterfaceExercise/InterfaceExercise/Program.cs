using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var streetRaceCar = new Car()
            {
                NumberOfWheels = 4,
                Make = "Nissan",
                Model = "GTR",
                Year = 2021,
                Logo = "Nissan with a circle around it",
                YearEstablished = 1933,
                TrunkSize = 20,
                HasNOS = true
            };
            var oldFarmersTruck = new Truck()
            {
                NumberOfWheels = 4,
                Make = "Ford",
                Model = "F150",
                Year = 2002,
                Logo = "Ford on an oval",
                YearEstablished = 1903,
                BedSize = 7,
                TowingCapacity = 1400
            };
            var offRoadSUV = new SUV()
            {
                NumberOfWheels = 4,
                Make = "Jeep",
                Model = "Wrangler",
                Year = 2018,
                Logo = "Jeep",
                YearEstablished = 1941,
                CargoHoldSize = 40,
                HasThirdRow = false
            };

            Console.WriteLine($"My car is a {streetRaceCar.Year} {streetRaceCar.Make} {streetRaceCar.Model}, it has {streetRaceCar.NumberOfWheels} wheels," +
                $" the company's logo looks like {streetRaceCar.Logo} and was established in {streetRaceCar.YearEstablished}." +
                $" My car has a {streetRaceCar.TrunkSize} foot trunk and it's {streetRaceCar.HasNOS} that it has NOS");
            Console.WriteLine("");

            Console.WriteLine($"My truck is a {oldFarmersTruck.Year} {oldFarmersTruck.Make} {oldFarmersTruck.Model}, it has {oldFarmersTruck.NumberOfWheels} wheels," +
                $" the company's logo looks like {oldFarmersTruck.Logo} and was established in {oldFarmersTruck.YearEstablished}." +
                $" My truck has a {oldFarmersTruck.BedSize} foot bed and it's towing capacity is {oldFarmersTruck.TowingCapacity} pounds");
            Console.WriteLine("");

            Console.WriteLine($"My suv is a {offRoadSUV.Year} {offRoadSUV.Make} {offRoadSUV.Model}, it has {offRoadSUV.NumberOfWheels} wheels," +
                $" the company's logo looks like {offRoadSUV.Logo} and was established in {offRoadSUV.YearEstablished}." +
                $" My suv has a {offRoadSUV.CargoHoldSize} foot cargohold and it's {offRoadSUV.HasThirdRow} that it has a 3rd row");
        }
    }
}