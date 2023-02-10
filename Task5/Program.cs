using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        /**
         * Используя Visual Studio, создайте проект по шаблону Console Application.
         * Напишите программу, которая решает квадратное уравнение. Пользователь должен ввести
         * коэффициенты а, b и с квадратного уравнения ах2 + bх + с = 0. После чего программа должна
         * вывести на экран все корни этого уравнения или сообщение о том, что их нет. Рассмотреть случаи
         * когда дискриминант (D) квадратного уравнения > 0, когда D<0 и когда D = 0.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input second number");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input third number");
            double c = Convert.ToDouble(Console.ReadLine());

            double D;
            double x1, x2;
            string result = "Your equasion has no roots";

            D = Math.Pow(b, 2) - 4 * a * c;

            if (D == 0)
            {
                x1 = x2 = -b / (2 * a);
                result = $"Your equasion's roots are {x1} and {x2}";
            }
            else if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                result = $"Your equasion's roots are {Math.Round(x1, 2)} and {Math.Round(x2, 2)}";
            }

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
