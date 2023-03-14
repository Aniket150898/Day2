using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class SwitchCase
    {
        public static void WeekDays()
        {
            Console.WriteLine("Enter the number between 1 to 7:-");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuseday");
                    break;
                case 3:
                    Console.WriteLine("Wenseday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                default:
                    Console.WriteLine("Sunday");
                    break;
            }

        }
        public static void AirthmaticOpration()
        {
            Console.WriteLine("Enter 1st NUmber:-");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st NUmber:-");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the operation (+, -, *, /): ");
            char operation = Console.ReadLine()[0];

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }

            Console.WriteLine("Result: " + result);
        }

    }
}
