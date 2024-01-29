﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Tier
    {
        public double Pressure { get; set; }
        public int Age { get; set; }

        public Tier(double tirePressure, int tireAge)
        {
            Pressure = tirePressure;
            Age = tireAge;
        }
    }
}