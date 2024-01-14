using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWAssess2Car
{
    // The class of the Car Listings, it holds the array of the cars on the lot.
    
    internal class CarListings
    {
        Car[] carsOnLot = new Car[20];

        public CarListings(int existingCars)
        {
            carsOnLot = new Car[existingCars];
            carsOnLot[0] = new Car(1, "1ABC123", "Ford", "Falcon", 2008, 9999);
            carsOnLot[1] = new Car(2, "1AAA111", "Subaru", "Forester", 2012, 11999);
            carsOnLot[2] = new Car(3, "1DEF456", "Kia", "Sportage", 2016, 21999);
            carsOnLot[3] = new Car(4, "1BBB222", "Toyota", "Corolla", 2010, 7999);
            carsOnLot[4] = new Car(5, "1GHI789", "Ford", "Ranger", 2014, 27999);
            carsOnLot[5] = new Car(6, "1CCC333", "Nissan", "Patrol", 2003, 18999);
        }

        public List<Car> GetCars()
        {
            return carsOnLot.ToList();
        }
       
        
    }
}