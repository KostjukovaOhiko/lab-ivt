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
            //Пример возведения числа в несколько степеней
            byte l = 2, i = 0;//вводд переменных целого типа byte
            int result = 1;////вводд переменной целого типа int

            while (i < 10)//проверка выполнения данного условия
            {
                i++;//найдем инкремент i
                result *= l;//вычислим значение переменной result 
                Console.WriteLine("{0} в степени {1} равно {2}", l, i, result);//вывод на консоль результата
            }

            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
        }
    }
}