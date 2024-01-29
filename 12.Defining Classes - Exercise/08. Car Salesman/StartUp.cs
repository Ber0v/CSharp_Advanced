﻿using System;
using System.Collections.Generic;

namespace _08.CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = ParseArray();
                engines.Add(CreateEngine(tokens));
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] tokens = ParseArray();
                cars.Add(CreateCar(tokens, engines));
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public static Car CreateCar(string[] tokens, List<Engine> engines)
        {
            string carModel = tokens[0];
            string engineModel = tokens[1];
            Engine engine = engines.Find(e => e.Model == engineModel);
            Car car = new Car(carModel, engine);

            if (tokens.Length > 2)
            {
                bool isDigit = int.TryParse(tokens[2], out int weight);
                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = tokens[2];
                }

                if (tokens.Length > 3)
                {
                    car.Color = tokens[3];
                }
            }
            return car;
        }

        public static Engine CreateEngine(string[] tokens)
        {
            string model = tokens[0];
            int power = int.Parse(tokens[1]);
            Engine engine = new Engine(model, power);
            if (tokens.Length > 2)
            {
                bool isDigit = int.TryParse(tokens[2], out int displacement);
                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = tokens[2];
                }

                if (tokens.Length > 3)
                {
                    engine.Efficiency = tokens[3];
                }
            }

            return engine;
        }

        public static string[] ParseArray()
        => Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
    }
}