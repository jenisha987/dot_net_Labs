using System;

namespace lab2
{
    public class SumOfArray
    {
        public void sumOfArray()
        {
            Console.WriteLine("Create an integer array and print sum of array element.");

            Console.WriteLine("Enter the size of array");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Enter the numbers");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Element {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine($"Sum of array elements is: {sum}");
        }
    }
}