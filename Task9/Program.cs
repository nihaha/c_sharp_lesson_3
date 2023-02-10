using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Program
    {
        /**
         * Используя Visual Studio, создайте проект по шаблону ConsoleApplication. 
         * Напишите программу русско-английский переводчик. Программа знает 10 слов о погоде. Требуется, 
         * чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова 
         * на английском языке. Если пользователь ввел слово, для которого отсутствует перевод, то следует 
         * вывести сообщение, что такого слова нет.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Input word to translate");
            string word = Console.ReadLine();
            string translation;

            switch (word)
            {
                case "холод":
                    translation = "cold";
                    break;
                case "жара":
                    translation = "heat";
                    break;
                case "даждь":
                    translation = "rain";
                    break;
                case "снег":
                    translation = "snow";
                    break;
                case "туман":
                    translation = "fog";
                    break;
                case "ливень":
                    translation = "showers";
                    break;
                case "ураган":
                    translation = "typhoon";
                    break;
                case "землетрясение":
                    translation = "earthquake";
                    break;
                case "облачно":
                    translation = "clouds";
                    break;
                default:
                    translation = "No such translation exists";
                    break;
            }

            Console.WriteLine(translation);
            Console.ReadLine();
        }
    }
}
