﻿// See https://aka.ms/new-console-template for more information
using System;

namespace Day_of_Week
{
    class Program
    {
        static int factor = 0;
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int perfectno = 0;

            for(int i = 1; i < number; i++)
            {
                int remainder = number % i;
                if (remainder == 0)
                {
                    factor = i;
                    perfectno = perfectno + factor;
                }
            }
            if (number == perfectno)
            {
                Console.WriteLine(" Perfect Number");
            }
            else
                Console.WriteLine(" Not Perfect Number");

        }
    }

    
    
}

