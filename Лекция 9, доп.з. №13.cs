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
            int result = Sum(230);//ввод переменной целого типа int
            Console.WriteLine("Сумма четных чисел от 1 до 230 равна: " + result);//вывод на консоль суммы четных чисел от 1 до 230

            Console.ReadLine();//ожидание нажатия клавиши Enter
        }

        // Метод, возращающий сумму всех четных чисел от 1 до s
        static int Sum(int s)
        {
            int mySum = 0;//ввод переменной целого типа int
            for (int i = 1; i <= s; i++)//проверка выполнения данного условия, если условие выполняется, то
                if (i % 2 == 0)//проверим выполнение условия (i % 2 == 0)
                    mySum += i;//вычисляем значение переменной mySum
            return mySum;//если условие не выполняется, то переменная mySum не изменяется
        }
    }
}