using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    internal class IfAndElse
    {
        //**First Program**
        public static void Equalnum()
        {
            Console.WriteLine("Checking Two Numbers Is Equal or Not Equal");
            Console.WriteLine("Enter num1:-");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2:-");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Both Numbers are Equal");
            }
            else
            {
                Console.WriteLine("Both Numbers are not Equals");
            }
        }

        //**Second program**
        public static void EvenOdd()
        {
            Console.WriteLine("2nd program start");
            Console.WriteLine("Enter The Number:-");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("Enter Number Is Even");
            }
            else
            {
                Console.WriteLine("Number Is Odd");
            }
        }
        //**Third**
        public void Voting()
        {
            Console.WriteLine("3rd program start");
            Console.WriteLine("Enter The Age:-");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("You Eligible For Voting");
            }
            else
            {
                Console.WriteLine("You are Not Eligible");
            }
        }
    }
}
