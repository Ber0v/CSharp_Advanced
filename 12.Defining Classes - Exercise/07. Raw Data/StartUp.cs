﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries);
                Engine engine = new Engine(int.Parse(tokens[1]), int.Parse(tokens[2]));
                Cargo cargo = new Cargo(int.Parse(tokens[3]),tokens[4]);
                Tier[] tiers = new Tier[] 
                {
                new Tier(double.Parse(tokens[5]),int.Parse(tokens[6])),
                new Tier(double.Parse(tokens[7]),int.Parse(tokens[8])),
                new Tier(double.Parse(tokens[9]),int.Parse(tokens[10])),
                new Tier(double.Parse(tokens[11]),int.Parse(tokens[12]))
                };
                cars.Add(new Car(tokens[0], engine, cargo, tiers));
            }

            string type = Console.ReadLine();
            List<Car> filtered = new List<Car>();

            if (type=="fragile")
            {
                filtered = cars.Where(c=>c.Cargo.Type=="fragile" && c.Tier.Any(t=>t.Pressure<1)).ToList();
            }
            else if (type=="flamable")
            {
                filtered = cars.Where(c=>c.Cargo.Type=="flamable" && c.Engine.Power>250).ToList();
            }

            foreach (Car car in filtered)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}