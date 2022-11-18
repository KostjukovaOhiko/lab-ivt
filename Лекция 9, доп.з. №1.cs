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
            short d = 10, f = 12;//ввод переменных целого типа short
            bool var1 = true, var2 = false;////ввод переменных логического типа

            if (d < f)//проверка выполнения оператора "меньше"
                Console.WriteLine("d < f");//вывод результата на консоль
            if (d <= f)//проверка выполнения оператора "меньше или равно"
                Console.WriteLine("d <= f");//вывод результата на консоль
            if (d != f)//проверка выполнения оператора "не равно"
                Console.WriteLine("d != f");//вывод результата на консоль

            //следующее условие не выполнится
            if (d > f)//проверка выполнения оператора "больше"
                Console.WriteLine("d > f");//вывод результата на консоль

            //сравниванием переменные var1 и var2
            if (var1 & var2)//проверка выполнения логического оператора "И"
                Console.WriteLine("Данный текст не выведется");//вывод результата на консоль
            if (!(var1 & var2))//проверка выполнения логического оператора "НЕ И"
                Console.WriteLine("!(var1 & var2) = true");//вывод результата на консоль
            if (var1 | var2)//проверка выполнения логического оператора ИЛИ
                Console.WriteLine("var1 | var2 = true");//вывод результата на консоль
            if (var1 ^ var2)//проверка выполнения логического оператора "исключающее ИЛИ"
                Console.WriteLine("var1 ^ var2 = true");//вывод результата на консоль

            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
        }

    }
}