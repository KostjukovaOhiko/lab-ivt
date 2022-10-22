
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    ///  Класс Program
    ///  основной класс программы
    ///  выводящий текст "Hello, World!"
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод Main() является
        /// входной точкой работы программы
        /// </summary>
        /// <param name="args">Аргумент метода Main()</param>
        static void Main(string[] args)
        {
            // Форматируем шапку программы
            Console.BackgroundColor = ConsoleColor.Green;//окрашивает фон в зеленый цвет
            Console.ForegroundColor = ConsoleColor.Black;//окрашивает передний план черным цветом
            Console.WriteLine("********************");//выводит на консоль "********************"
            Console.WriteLine("**** Мой проект ****");//выводит на консоль "**** Мой проект ****"
            Console.WriteLine("********************");//выводит на консоль "********************"
            // Основная программа
            Console.BackgroundColor = ConsoleColor.Black;//окрашивает фон черным цветом
            Console.ForegroundColor = ConsoleColor.Green;//окрашивает передний план зеленым цветом
            Console.WriteLine();
            Console.WriteLine("Hello, World!");//выводит на консоль"Hello, World!"

            // Ожидание нажатия клавиши Enter перед завершением работы
            Console.ReadLine();
        }
    }
}

