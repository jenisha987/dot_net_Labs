using System;
using System.Runtime.InteropServices;

namespace lab2
{
    public class swap_two_numbers
    {
        public void swapNumber()
        {
            Console.WriteLine("Swap two numbers");
            
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n Numbers before swapping: num1 = {num1} and num2 = {num2}");

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"\n Numbers after swapping: num1 = {num1} and num2 = {num2}");
        }
    }
}