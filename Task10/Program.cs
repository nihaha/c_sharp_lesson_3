using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Program
    {
        /**
         * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. Напишите программу 
         * расчета начисления премий сотрудникам. Премии рассчитываются согласно выслуге лет. Если 
         * выслуга до 5 лет, премия составляет 10% от заработной платы. Если выслуга от 5 лет (включительно) 
         * до 10 лет, премия составляет 15% от заработной платы. Если выслуга от 10 лет (включительно) до 15 
         * лет, премия составляет 25% от заработной платы. Если выслуга от 15 лет (включительно) до 20 лет, 
         * премия составляет 35% от заработной платы. Если выслуга от 20 лет (включительно) до 25 лет, 
         * премия составляет 45% от заработной платы. Если выслуга от 25 лет (включительно) и более, премия 
         * составляет 50% от заработной платы. Результаты расчета, выведите на экран.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Input your salary");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input years of service");
            int years = Convert.ToInt32(Console.ReadLine());

            int bonus = 0;

            if (years > 0 && years < 5)
            {
                bonus = 10;
            }
            else if (years >= 5 && years < 10)
            {
                bonus = 15;
            }
            else if (years >= 10 && years < 15)
            {
                bonus = 25;
            }
            else if (years >= 15 && years < 20)
            {
                bonus = 35;
            }
            else if (years >= 20 && years < 25)
            {
                bonus = 45;
            }
            else if (years >= 25)
            {
                bonus = 50;
            }

            double result = salary + salary * bonus / 100;

            Console.WriteLine($"Your additional bonus is {bonus}%. Current salary is {result}");
            Console.ReadLine();
        }
    }
}
