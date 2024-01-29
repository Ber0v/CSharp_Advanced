﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace _06.SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = ParseArray();
                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double fuelConsumptionPerKilometer = double.Parse(tokens[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars.Add(car);
            }

            while (true)
            {
                string[] tokens = ParseArray();
                string command = tokens[0];

                if (command=="End")
                {
                    break;
                }

                string carModel = tokens[1];
                double distance = double.Parse(tokens[2]);

                cars.Where(c => c.Model == carModel).ToList().ForEach(c=>c.Drive(distance));
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }

        public static string[] ParseArray()
        => Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
    }
}