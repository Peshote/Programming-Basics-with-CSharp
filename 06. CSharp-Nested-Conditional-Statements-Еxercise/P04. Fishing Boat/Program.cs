﻿using System;

namespace P04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budged = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());
            double price = 0.0;
            
            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
            }
            if (fishermanCount <= 6)
            {
                price = price -= price * 0.10;
            }
            else if (fishermanCount >= 7 && fishermanCount <= 11)
            {
                price = price -= price * 0.15;
            }
            else
            {
                price = price -= price * 0.25;
            }
            if (fishermanCount % 2 == 0 && season != "Autumn")
            {
                price = price -= price * 0.05;
            }
            if (budged >= price)
            {
                Console.WriteLine($"Yes! You have {budged - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budged:f2} leva.");
            }
        }
    }
}
