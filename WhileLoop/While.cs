using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class While
    {
        public static void FlipCoin()
        {
            int headsCount = 0;
            int tailsCount = 0;
            Random random = new Random();

            while (headsCount < 20 && tailsCount < 20)
            {
                int flip = random.Next(0, 2);
                if (flip == 0)
                {
                    Console.WriteLine("Heads");
                    headsCount++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    tailsCount++;
                }
            }

            if (headsCount == 20)
            {
                Console.WriteLine("Heads wins!");
            }
            else
            {
                Console.WriteLine("Tails wins!");
            }
        }

        /// <summary>
        /// 2nd program of while loop
        /// </summary>
        public static void ReverseThestring()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            int length = word.Length;
            string reversedWord = "";

            while (length > 0)
            {
                reversedWord += word[length - 1];
                length--;
            }

            Console.WriteLine("Reversed word: " + reversedWord);
            Console.ReadLine();
        }

        /// <summary>
        /// 3rd program of while loop
        /// </summary>
        public static void NaturalNum()
        {
            int num = 1;
            int sum = 0;
            int count = 0;

            while (count < 5)
            {
                sum += num;
                num++;
                count++;
            }

            Console.WriteLine("Sum of first 5 natural numbers: " + sum);
        }
    }
}
