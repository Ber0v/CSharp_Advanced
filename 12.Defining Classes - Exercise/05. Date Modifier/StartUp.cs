﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<DateTime> datas = new List<DateTime>();

            for (int i = 0; i < 2; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int year = int.Parse(tokens[0]);
                int month = int.Parse(tokens[1]);
                int day = int.Parse(tokens[2]);

                DateTime data = new DateTime(year, month, day);
                datas.Add(data);
            }

            DateModifier dateModifier = new DateModifier();

            long result = dateModifier.CalculateDifferenceBetweenTwoDatas(datas);

            Console.WriteLine(result);
        }
    }
}