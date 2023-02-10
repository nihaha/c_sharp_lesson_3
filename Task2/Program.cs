using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        /**
         * Используя Visual Studio, создайте проект по шаблону Console Application.
         * Напишите программу, которая будет рассчитывать процент скидки в зависимости от количества
         * купленного товара. Если куплено больше 3 единиц товара, тогда скидка должна быть 10 процентов
         * от общей суммы, если же количество больше 3 и меньше 7, то 20процентов от общей суммы, иначе,
         * если больше 7 то 25 процентов от общей суммы. Цену товара и купленное количество товара
         * пользователь должен задавать вводом с консоли.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Please, input product price, $");
            double price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please, input product amount");
            int amount = Convert.ToInt32(Console.ReadLine());

            double discount;
            double totalCost;

            if (amount <= 3)
            {
                discount = 0.1;
            }
            else if (amount > 3 && amount < 7)
            {
                discount = 0.2;
            }
            else
            {
                discount = 0.25;
            }

            totalCost = amount * (price - (price * discount));

            Console.WriteLine($"Your discount is {discount * 100}%");
            Console.WriteLine($"Total cost of {amount} products is ${totalCost}");            
            Console.ReadLine();
        }
    }
}
