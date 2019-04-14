using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndAGasStation
{
    public partial class Car
    {
        public void StartCar()
        {
            if(HaveKeys == true)
            {
                Console.WriteLine("The car starts the engine");
                StartLights();
            }
            else
            {
                Console.WriteLine("You need a key to start the car");
            }
        }
        public void StartLights()
        {
                Console.WriteLine("Light turn on");
        }
        public static string GetCarStats(Car car)
        {
            return $"Stats for car: \nBrand \t{car.Brand}, \nModel\t{car.Model}, \nFuel\t{car.Fuel} litars";
        }
    }
}
