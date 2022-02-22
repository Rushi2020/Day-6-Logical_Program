// Temprature Conversion
using System;

namespace Temp_Conversion
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select Temprature Conversion Method");
            Console.WriteLine("Choose 1:Celsius to Fahrenheit   2: Fahrenheit to Celsius ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Put Temp. Value To convert");
            int temp = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    double celsius_To_Fahrenheit = (temp * 9 / 5) + 32;
                    Console.WriteLine("Temperature in Fahrenheit: " + celsius_To_Fahrenheit);
                    break;
                case 2:
                    double fahrenheit_To_Celsius = (temp - 32) * 5 / 9;
                    Console.WriteLine("Temperature in Celsius: " + fahrenheit_To_Celsius);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }

    
    
}

