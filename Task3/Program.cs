using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Напишите программу, в которой создайте переменную min. Значение переменной должен задавать 
             * пользователь, интервал допустимых значений 0 до 59, необходимо организовать проверку на ввод 
             * допустимого интервала. Определите в какую четверть часа попадает значение переменной (в 
             * первую, вторую, третью или четвертую).
             */

            Console.WriteLine("Input number");
            int min = Convert.ToInt32(Console.ReadLine());
            string result;

            if (min < 0 || min > 59)
            {
                result = "Please, input a number between 0 and 59";
            }
            else
            {
                if (min >= 0 && min < 16)
                {
                    result = "I quarter";
                }
                else if (min >= 16 && min < 30)
                {
                    result = "II quarter";
                }
                else if (min >= 30 && min < 45)
                {
                    result = "III quarter";
                }
                else
                {
                    result = "IV quarter";
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
