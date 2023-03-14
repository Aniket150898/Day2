using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    internal class ElseIf
    {
        /// <summary>
        /// else if first program
        /// </summary>

        public static void LargestNum()
        {
            Console.WriteLine("Enter the first number:- ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:- ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number:- ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Find the largest number
            int largest;
            if (num1 >= num2 && num1 >= num3)
            {
                largest = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                largest = num2;
            }
            else
            {
                largest = num3;
            }

            // Output the largest number
            Console.WriteLine("The largest number is: " + largest);
        }

        /// <summary>
        /// else if first program
        /// </summary>
        public static void AdmissionEligibility()
        {
            Console.WriteLine("Enter the marks obtained in Physics:-");
            int marks1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks obtained in Chemistry:-");
            int marks2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks obtained in Mathematics:-");
            int marks3 = Convert.ToInt32(Console.ReadLine());
            if (marks1 >= 55 && marks2 >= 50 && marks3 >= 65)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if (marks1 + marks2 + marks3 >= 180 || marks1 + marks2 + marks3 >= 140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is eligible **Not eligible** for admission.");
            }
        }
    }
}
