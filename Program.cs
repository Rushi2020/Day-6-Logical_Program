// Reverse number
using System;

namespace everse_Number
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Enter value of num");
            int num = Convert.ToInt32(Console.ReadLine());
            int  reminder  , reverse = 0;

            while(num>0){
                reminder = num % 10;
                reverse = (reverse * 10) + reminder;
                num = num / 10;
            }
            Console.WriteLine(reverse);
           // Console.ReadLine();
        }
    }

    
    
}

