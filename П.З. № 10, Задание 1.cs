using System;
namespace For1
{
    class Program
    {
        static int fact(int n)
        {
            return n > 1 ? n * fact(--n) : 1;
        }
        static void Main(string[] args)
        {
            double x = 2;//ввод вещественной переменной x
            int n = 5;//ввод переменной n целого типа 
            double z = 0;//ввод вещественной переменной z

            for (int i = 0; i < n+1; i++)//проверка выполнения условия для переменной i
            {
                z += (2 * i + 1) * Math.Pow(x, 2 * i) / fact(i);//вычисление значения суммы ряда
            }
            Console.WriteLine("z = {0}", +z);//вывод на консоль суммы ряда
            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
        }
    }
}
