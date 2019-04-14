﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsAndAGasStation
{
    public partial class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Fuel { get; set; }
        public bool HaveKeys { get; set; }
        public bool IsDrivable { get; set; }

        public Car(string brand, string model, string color, int fuel, bool haveKeys, bool isDrivable)
        {
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.Fuel = fuel;
            this.HaveKeys = haveKeys;
            this.IsDrivable = isDrivable;
        }
    }
}
