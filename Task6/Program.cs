using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Напишите программу, которая определяет, является ли год високосным. Пользователь вводит год. 
             * Программа должна вывести на экран ответ, является ли год високосным. Подсказка. Обычно 
             * каждый год, который делится на 4, — это високосный год, кроме лет столетий (делящихся на 100). 
             * Но среди последних год, делящийся на 400, также считается високосным.
            */
            Console.WriteLine("Input year");
            int year = Convert.ToInt32(Console.ReadLine());
            string result = "This is not a leap year";

            if ((year % 4 == 0 && year % 100 != 0) || (year % 100 == 0 && year % 400 == 0))
            {
                result = "This year is a leap year";
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
