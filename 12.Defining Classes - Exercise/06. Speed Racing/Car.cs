﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double Consumption { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model,double fuel, double consumption)
        {
            Model = model;
            FuelAmount = fuel;
            Consumption = consumption;
            TravelledDistance = 0;
        }

        public void Drive(double distance) {
            double fuelNeeded = distance * Consumption;
            if (FuelAmount >= fuelNeeded)
            {
                FuelAmount -= fuelNeeded;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}