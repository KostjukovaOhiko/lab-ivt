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
            //В данном цикле выведутся числа от 1 до 5 вместо 100
            for (int i = 1; i < 100; i++)//проверка выполнения данного условия, если выполняется, то
                if (i <= 5)//если i меньше или равно 5, то
                    Console.WriteLine(i);//вывод на консоль значения i
                else break;//если условие не выполняется, то выходим из цикла

            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
        }
    }
}