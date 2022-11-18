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
            int result;//ввод переменной целого типа int

            //Реализуем функцию модуля числа
            for (int i = 5; i >= -5; i--)//проверка выполнения данного условия 1, если выполняется, то
            {
                //вычисляем значение переменной result
                result = i >= 0 ? i : -i;
                Console.Write("{0}\t", result);//вывод на консоль значения result\t
            }

            Console.WriteLine("\n\n");//если условие 1 не выполняется, то вывод на консоль выражения в ковычках

            //Выбор четных чисел
            for (int i = 0; i < 10; i++)//проверка выполнения данного условия 2, если выполняется, то
            {
                //проверяем выполнение следующего условия:
                if (i % 2 == 0 ? true : false)//если условие выполняется, то
                    Console.Write("{0}\t", i);//вывод на консоль значения i\t
            }

            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
        }
    }
}