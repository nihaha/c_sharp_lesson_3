using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        /**
         * Используя Visual Studio, создайте проект по шаблону Console Application. 
         * Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в 
         * числовой промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100]. Если да, то укажите, 
         * в какой именно промежуток. Если пользователь указывает число не входящее ни в один из имеющихся числовых 
         * промежутков, то выводится соответствующее сообщение.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number from 0 to 100");
            int number = Convert.ToInt32(Console.ReadLine());
            string result = "Your number lies outside needed boundaries";

            if (number > 0 && number < 15)
            {
                result = "Your number lies between 0 and 15";
            }
            else if (number >= 15 && number < 35)
            {
                result = "Your number lies between 14 and 35";
            }
            if (number >= 35 && number < 50)
            {
                result = "Your number lies between 35 and 50";
            }
            if (number >= 50 && number < 100)
            {
                result = "Your number lies between 50 and 100";
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
