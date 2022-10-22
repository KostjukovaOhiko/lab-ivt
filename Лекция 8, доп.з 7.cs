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
            int num1, num2;//ввод значений целого типа int
            float f1, f2;//ввод значений вещественного типа float

            num1 = 13 / 3;//нахождение результата деления
            num2 = 13 % 3;//нахождение остаток от этого деления

            f1 = 13.0f / 3.0f;//нахождение результата деления литералов типа float
            f2 = 13.0f % 3.0f;//нахождение остаток от этого деления литералов типа float

            Console.WriteLine("Результат и остаток от деления 13 на 3: {0} __ {1}", num1, num2);//вывод на консоль результата и остатка от деления
            Console.WriteLine("Результат деления 13.0 на 3.0: {0:#.###} {1}", f1, f2);//вывод на консоль результата деления

            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
        }
    }
}
