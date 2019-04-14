using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndAGasStation
{
    public static class GasStation
    {
        public static void Refill(Car car)
        {
            if (car.HaveKeys)
            {
                car.Fuel += 20;
                Console.WriteLine($"You filled 20 liters of fuel, now you have {car.Fuel} liters");
            }
        }
        public static void PupmUpTires(Car car)
        {
            if (car.HaveKeys)
            {
                if (car.IsDrivable == true)
                {
                    Console.WriteLine("The car is in good state");
                }
                else
                {
                    car.IsDrivable = true;
                    Console.WriteLine("The car now is in good state");
                }
            }
           
        }
    }
}
