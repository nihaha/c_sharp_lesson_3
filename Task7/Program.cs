using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        /**
         * Используя Visual Studio, создайте проект по шаблону Console Application. 
         * Напишите программу - консольный калькулятор. Создайте две переменные с именами operand1 и operand2. 
         * Задайте переменным некоторые произвольные значения. Предложите пользователю ввести знак арифметической операции. 
         * Примите значение введенное пользователем и поместите 
         * его в строковую переменную sign. Для организации выбора алгоритма вычислительного процесса, 
         * используйте переключатель switch. Выведите на экран результат выполнения арифметической 
         * операции. В случае использования операции деления, организуйте проверку попытки деления на 
         * ноль. И если таковая имеется, то отмените выполнение арифметической операции и уведомите об 
         * ошибке пользователя.
        */
        static void Main(string[] args)
        {
            double operand_1 = 50;
            double operand_2 = 12;
            double result = 0;

            Console.WriteLine($"First number is {operand_1}");
            Console.WriteLine($"Second number is {operand_2}");
            Console.WriteLine("Input sign");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    result = operand_1 + operand_2;
                    break;
                case "-":
                    result = operand_1 - operand_2;
                    break;
                case "*":
                    result = operand_1 * operand_2;
                    break;
                case "/":
                    result = operand_1 / operand_2;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Current operation result is {Math.Round(result, 2)}");
            Console.ReadLine();
        }
    }
}
