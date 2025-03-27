using System;

namespace lab2
{
    public class oddEven
    {
        public void findOddEven()
        {
            Console.WriteLine("Check whether a given number is odd or even");

            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"The given number {num} is even.");
            }
            else
            {
                Console.WriteLine($"The given number {num} is odd.");
            }
        }
    }
}