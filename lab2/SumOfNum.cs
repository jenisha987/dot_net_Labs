using System;

namespace lab2
{
    public class SumOfNum
    {
        public void SumofNaturalNum()
        {
            Console.WriteLine("Sum of n natural number");

            Console.WriteLine("Enter the value of nth number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= num; i++) 
            {
                sum += i;
            }
            
            Console.WriteLine($"The sum of {num}th natural number is {sum}");
        }
    }
}