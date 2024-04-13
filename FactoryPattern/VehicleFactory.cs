﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car();
                case "truck":
                    return new Truck();
                default:
                    return new Car();
            }
        }
    }
}
