﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tier[] Tier { get; set; }

        public Car(string model, Engine engine, Cargo cargo, Tier[] tiers)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tier = tiers;
        }
    }
}