using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWAssess2Car
{
    internal class Car
    {
        // The properties for the car class.
        public int carBays { get; set; }    
        public string carRegistrationPlate { get; set; }
        public string carMakes { get; set; }
        public string carModels { get; set; }
        public int carManufacturedYear { get; set; }
        public int carPricing { get; set; }

        // The constructor of the car class.
        public Car(int carBay, string carRegistration, string carMake, string carModel, int carManuYear, int carPrice)
        {
            carBays = carBay;
            carRegistrationPlate = carRegistration;
            carMakes = carMake;
            carModels = carModel;   
            carManufacturedYear = carManuYear;
            carPricing = carPrice;

        }
    }
}
