using System;

namespace OOPCLASS
{
    public class Palindrome
    {
        public void checkPalindrome()
        {
            Console.Write("Enter the string to check the palindrome");
            string input = Console.ReadLine();
            string toCheck = input;
            char[] characterArray = toCheck.ToCharArray();
            Array.Reverse(characterArray);
            string reversedString = new string(characterArray);

            if (toCheck == reversedString)
            {
                Console.WriteLine("Input is Palindorme");
            }
            else
            {
                Console.WriteLine("Input is not a Palindrome");
            }
        }
    }
}