using System;

namespace ReverseIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Game reverse = new Game();
            int[] numbers = reverse.Scramble();
            int movesTaken = 0;


            Console.WriteLine(reverse.ToString());

            do
            {
                int breakpoint = Prompt.GetNumber(1, 9);

                reverse.ReverseNumbers(breakpoint - 1);

                Console.WriteLine(reverse.ToString());
                movesTaken++;
            } while (!reverse.IsWin());

            Console.WriteLine("You won!!");
            Console.WriteLine("Moves taken: " + movesTaken);
            Console.ReadKey();
        }
    }
}
