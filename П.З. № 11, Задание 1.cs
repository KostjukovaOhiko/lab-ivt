using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        private static double Factorial(int n)//вычисление факториала
        {
            if (n <= 1) return 1;//проверка выполнения условия
            //если условие не выполняется, то:
            else return Factorial(n - 1) * n; 
        }
        static void Main(string[] args)
        {
            double summ = 0;//вводим и очищаем значение суммы
            int n = 1;//вводим начальное значение членов ряда
            double x = 0.1; //вводим значение переменной ряда
            double e = 0.00001;//зададим точность
            do 
            {
                x = (Math.Pow(-1, n) * Math.Pow(2 * x, 2 * n) / Factorial(2 * n));//вычислим n-ый член ряда
                summ += x;//найдем значение суммы членов ряда
                n++;//вычислим инкремент
            } 
            while (Math.Abs(x) > e);//проверка выполнения условия
            Console.WriteLine($"s = " +summ.ToString());//вывод на консоль значения суммы
            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
        }            
    }
}
