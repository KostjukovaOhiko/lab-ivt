using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите язык (C#, VB или C++)");//пользователь должен выбрать ЯП и ввести его на консоль
            string myLanguage = Console.ReadLine();//ожидание нажатия клавиши Enter 

            sw1(myLanguage);

            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
        }

        //Данный метод выводит выбор пользователя
        static void sw1(string s)
        {
            switch (s)//используем оператор switch
            {
                case "C#"://если пользователь ввел язык  , то
                    Console.WriteLine("Вы выбрали язык C#");//вывод на консоль данной фразы
                    break;//выход из цикла
                case "VB"://если пользователь ввел язык  , то
                    Console.WriteLine("Вы выбрали язык Visual Basic");//вывод на консоль данной фразы
                    break;//выход из цикла
                case "C++"://если пользователь ввел язык  , то
                    Console.WriteLine("Вы выбрали язык С++");//вывод на консоль данной фразы
                    break;//выход из цикла
                default://если пользователь ввел другой язык  , то
                    Console.WriteLine("Такой язык я не знаю");//вывод на консоль данной фразы
                    break;//выход из цикла
            }
        }
    }
}