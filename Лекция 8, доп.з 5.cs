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
            int i1 = 455, i2 = 84500;//ввод значений целого типа int
            decimal dec = 7.98845m;//ввод значения финансового типа

            Console.WriteLine((short)i1);//приводим два числа типа int к типу short
            Console.WriteLine((short)i2);//приводим два числа типа int к типу short

            Console.WriteLine((int)dec);//приводим число типа decimal к типу int

            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы

        }
    }
}