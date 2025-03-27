using System;

namespace lab2
{
    public class Factorial
    {
        public void findFactorial()
        {
            Console.WriteLine("Find the factorial of a given numbber.");

            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int fact = 1;

            if (num == 0 || num == 1)
            {
                Console.WriteLine($"The factorial of {num} is 1");
            }
            else
            {
                for (int i = 1; i <= num; i++) 
                {
                    fact = fact*i;
                }
                Console.WriteLine($"The factorial of {num} is {fact}");
            }
        }
    }
}