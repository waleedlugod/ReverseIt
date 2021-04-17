using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseIt
{
    class Game
    {
        private int[] numbers = new int[9];

        public Game()
        {
            for (int i = 0; i < 9; i++)
            {
                numbers[i] = i + 1;
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (int number in numbers)
            {
                result += number;
            }
            return result;
        }

        public bool IsWin()
        {
            int prevNum = 0;

            foreach (int number in numbers)
            {
                if (number <= prevNum)
                {
                    return false;
                }
                prevNum = number;
            }
            return true;
        }

        public int[] Scramble()
        {
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                int offSet;
                int tmpValue;

                do
                {
                    offSet = random.Next();
                } while ((i + offSet) % 9 == 0);

                tmpValue = numbers[(i + offSet) % 9];
                numbers[(i + offSet) % 9] = numbers[i];
                numbers[i] = tmpValue;
            }
            return numbers;
        }

        public int[] ReverseNumbers(int breakpoint)
        {
            int indexNum1 = 0;
            int indexNum2 = breakpoint;
            while (indexNum2 - indexNum1 >= 1)
            {
                int tmpValue = numbers[indexNum2];
                numbers[indexNum2] = numbers[indexNum1];
                numbers[indexNum1] = tmpValue;

                indexNum1++;
                indexNum2--;
            }
            return numbers;
        }
    }
}
