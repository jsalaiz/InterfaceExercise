using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Logo { get; set; }
        public int YearEstablished { get; set; }
        public int CargoHoldSize { get; set; }
        public bool HasThirdRow { get; set; }
    }
}