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
            // Выводим числа кратные 5
            for (byte i = 1; i <= 100; i++)//проверка выполнения данного условия, если оно выполняется, то 
            {
                if (i % 5 != 0) continue;//проверим выполнение условия (i % 5 != 0) и завершим цикл
                Console.Write("\t{0}", i);//вывод на консоль значения \ti
            }

            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
        }
    }
}