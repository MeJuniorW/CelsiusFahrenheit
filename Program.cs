using System;

namespace CelsiusFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the Celsius Fahrenheit Converter");
            GetInput();
        }
        private static void TryAgain()
        {
            Console.WriteLine("Do you want to try again (y/n)");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                GetInput();
            }
            else if (input == "n")
            {
                Environment.Exit(0);
            }
        }
        public static void GetInput()
        {
            Console.WriteLine("If you'd like to change TO celsius enter: C");
            Console.WriteLine("If you to change TO fahrenheit enter: F");
            Console.WriteLine("Press X for exit");
            string choice = Console.ReadLine().ToLower();
            ValidateChoice(choice);
        }
        private static void ValidateChoice(string input)
        {
            if ((input == "f") || (input == "c"))
            {
                Convert(input);
            }
            else if(input == "x")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid choice");
                GetInput();
            }
        }
        private static void Convert(string choice)
        {
            Console.Write("Enter the value to convert: ");
            bool correct = Double.TryParse(Console.ReadLine(), out double temp);
            if (!correct)
            {
                Console.WriteLine("Invalid value");
                Convert(choice);
            }
            switch(choice)
            {
                case "f":
                double newTemperatureCelsius = (temp * (9 / 5)) + 32;
                newTemperatureCelsius = Math.Round(newTemperatureCelsius, 2);
                Console.WriteLine(newTemperatureCelsius);
                TryAgain();
                break;
                case "c":
                double newTemperatureFahrenheit = (temp - 32) * (5.0/9.0);
                newTemperatureFahrenheit = Math.Round(newTemperatureFahrenheit, 2);
                Console.WriteLine(newTemperatureFahrenheit);
                TryAgain();
                break;
            }
        }
    }
}
