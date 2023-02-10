using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        /**
         * Используя Visual Studio, создайте проект по шаблону Console Application.
         * Напишите программу, в которой пользователь вводит целое число. Программа в свою очередь
         * должна ответить, четным или нечетным является это число, делится ли оно на 3 и делится ли оно на 6.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isEven = false;
            bool canBeDevidedBy3 = false;
            bool canBeDevidedBy6 = false;

            if (num % 2 == 0)
            {
                isEven = true;
            }

            if (num % 3 == 0)
            {
                canBeDevidedBy3 = true;
            }

            if (num % 6 == 0)
            {
                canBeDevidedBy6 = true;
            }

            Console.WriteLine($"Your number is {(isEven ? "even" : "odd")}");
            Console.WriteLine($"Your number {(canBeDevidedBy3 ? "can" : "can not")} be devided by 3");
            Console.WriteLine($"Your number {(canBeDevidedBy6 ? "can" : "can not")} be devided by 6");
            Console.ReadLine();
        }
    }
}
