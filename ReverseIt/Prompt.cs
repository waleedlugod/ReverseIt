using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseIt
{
    static class Prompt
    {
        public static int GetNumber(int min = int.MinValue, int max = int.MaxValue)
        {
            int result;
            bool isValid = false;
            do
            {
                Console.WriteLine("Enter how many numbers to reverse between " + min + " and " + max + " :");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out result);
                isValid = (result >= min && result <= max);
            } while (!isValid);
            return result;
        }
    }
}
