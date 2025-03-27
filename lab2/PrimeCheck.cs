using System;

namespace lab2
{
    public class PrimeCheck
    {
        public void primeCheck()
        {
            Console.WriteLine("Check whether the given number is prime or not.");

            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 2) 
            {
                Console.WriteLine($"{num} is not a prime number.");
                return;
            }

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{num} is not a prime number.");
                    return;
                }
            }
            Console.WriteLine($"{num} is a prime number.");
        }
    }
}