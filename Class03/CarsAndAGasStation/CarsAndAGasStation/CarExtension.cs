using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndAGasStation
{
    public static class CarExtension
    {
        public static void Drive(this Car car, string place)
        {
            if (car.HaveKeys)
            {
                if (car.Fuel >= 40)
                {
                    car.Fuel -= 20;
                    Console.WriteLine($"Drive to {place}, you have {car.Fuel} liters fuel");
                }
                else
                {
                    Console.WriteLine("You don't have enough fuel! Go to the gas station");
                }
            }
            
            
        }
    }
}
