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
            // Обычный цикл for выводящий числа от 1 до 5
            Console.WriteLine("Обычный цикл for:");//вывод на консоль "Обычный цикл for:"
            for (int i = 1; i <= 5; i++)//проверка выполнения данного условия
                Console.Write("\t{0}", i);//вывод на консоль значения \ti

            // Реализуем то же самое с помощью оператора goto
            Console.WriteLine("\n\nА теперь используем goto:");//вывод на консоль
            int j = 1;//присваиваем переменной j значение 1
        link1:
            Console.Write("\t{0}", j);//вывод на консоль значения \ti
            j++;//найдем инкремент j
            if (j <= 5) goto link1;//проверка выполнения данного условия


            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
        }
    }
}