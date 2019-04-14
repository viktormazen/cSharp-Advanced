using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndAGasStation
{
    class Program
    {
        static void Main(string[] args)
        { 
            Car myCar = new Car("Bmw", "320", "Black", 60, true, false);

            Console.WriteLine(Car.GetCarStats(myCar));
            myCar.StartCar();
            myCar.Drive("Beograd");
            GasStation.Refill(myCar);
            GasStation.PupmUpTires(myCar);
           
            Console.ReadLine();
        }
    }
}
