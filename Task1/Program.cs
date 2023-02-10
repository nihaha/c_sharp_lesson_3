using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        /**
         * Используя Visual Studio, создайте проект по шаблону Console Application. 
         * Напишите программу, в которой создайте переменную a. Значение переменной, а должен задавать 
         * пользователь. Если а < 10 то выведите 'Верно', иначе (a>10) выведите 'Неверно'.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Please, input a number");

            int a = Convert.ToInt32(Console.ReadLine());

            /*if (a > 5)
            {
                result = "Correct";
            }
            else
            {
                result = "Incorrect";
            }*/

            string result = a > 5
                ? "Correct"
                : "Incorrect";

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
