﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public double DefaultFuelConsumption { get; set; } = 1.25;

        public virtual double FuelConsumption { get; set; }

        public virtual void Drive(double kilometers)
        {
            if (FuelConsumption <= 0)
            {
                FuelConsumption = DefaultFuelConsumption;
            }


            Fuel -= kilometers * FuelConsumption;

        }

    }
}
