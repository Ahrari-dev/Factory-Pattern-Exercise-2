﻿using System;
namespace FactoryPatternVehicles
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Let's get going!");
        }
    }
}

