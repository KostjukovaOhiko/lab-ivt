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
            long result;//ввод числа целого типа long
            const long km = 149800000; // расстояние в км.

            result = km * 1000 * 100;//нахождение значения расстояние от Земли до Солнца в сантиметрах
            Console.WriteLine(result);//вывод результата на консоль
            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
        }
    }
}