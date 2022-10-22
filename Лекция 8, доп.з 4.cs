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
            //1 способ вычисления суммы двух чисел
            short num1, num2;//ввод значений целого типа short
            num1 = 10;//присваивание переменной num1 значение 10
            num2 = 15;//присваивание переменной num2 значение 15

            Console.WriteLine("{0} + {1} = {2}", num1, num2, Sum(num1, num2));//вывод на консоль значения суммы значений num1,num2
            
            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы

        }
        //2 способ вычисления суммы двух чисел
        static int Sum(int x, int y)//вычисление суммы двух чисел типа int 
        {
            return x + y;//возврат значения суммы
        }
    }
}