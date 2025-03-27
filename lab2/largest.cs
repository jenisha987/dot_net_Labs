using System;
using System.Runtime.InteropServices;

namespace lab2
{
    public class largestNum
    {
        public void largestNumber()
        {
            Console.WriteLine("Find largest among three numbers");
            
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"The largest number among {num1}, {num2} and {num3} is {num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"The largest number among {num1}, {num2} and {num3} is {num2}");
            }
            else
            {
                Console.WriteLine($"The largest number among {num1}, {num2} and {num3} is {num3}");

            }
        }
    }
}