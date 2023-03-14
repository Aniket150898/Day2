using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class For
    {
        /// <summary>
        /// 1st program using for loop
        /// </summary>
        public static void ForLoop()
        {
            Console.WriteLine("Enter the num:-");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("2^{0} = {1}", i, Math.Pow(2, i));
            }
        }
        /// <summary>
        /// 2nd program using for loop
        /// </summary>
        public static void Powerof2()
        {
            Console.Write("Enter a value for N: ");
            int n = int.Parse(Console.ReadLine());

            int sumOfSquares = 0;
            for (int i = 1; i <= n; i++)
            {
                sumOfSquares += i * i;
            }

            Console.WriteLine("The sum of squares of the first {0} numbers is: {1}", n, sumOfSquares);
        }

        /// <summary>
        /// 3rd program using for loop
        /// </summary>
        public static void factorial()
        {
            Console.Write("Enter a number to compute its factorial: ");
            int num = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("{0}! = {1}", num, factorial);
        }
    }
}
