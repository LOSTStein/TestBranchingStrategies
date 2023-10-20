using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Car
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public void Honk() 
        {
            Console.WriteLine("The car honks!");
        }

        public string GetFullInfo()
        {
            // string info = "Brand: " + Brand + " Model: " + Model + " Year: " + Year
            // ==
            // return $"{Brand} {Model} {Year}";

            string info = $"{Brand} {Model} {Year}";
            return info;
        }

        public float CalculateFuelConsumption(int kilometers, float cunsumptionRate)
        {
            float cunsumptionPerKm = cunsumptionRate / 100;
            return kilometers * cunsumptionPerKm;
        }
    }
}
