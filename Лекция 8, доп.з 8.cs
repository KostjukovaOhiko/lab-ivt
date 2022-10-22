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
            short d = 1;//ввод значения целого типа short

            for (byte i = 0; i < 10; i++)//проверка выполнения условия (byte i = 0; i < 10; i++)
                Console.Write(i + d++ + "\t");//вывод на консоль инкремента в постфиксной форме

            Console.WriteLine();//вывод результата на консоль

            d = 1;//присваивание переменной d значение 1

            for (byte i = 0; i < 10; i++)//проверка выполнения условия(byte i = 0; i < 10; i++)
                Console.Write(i + ++d + "\t");//вывод на консоль инкремента в префиксной форме

            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
        }

    }
}


