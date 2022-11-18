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
            // Объявляем два массива
            int[] myArr = new int[5];//первый массив
            int[,] myTwoArr = new int[5, 6];//второй массив
            int sum = 0;//вводим переменную целого типа int

            Random ran = new Random();//генерируем случайные числа

            //Инициализируем массивы
            for (int i = 1; i <= 5; i++)//проверка выполнения данного условия
            {
                myArr[i - 1] = ran.Next(1, 20);//вычисляем новое значение первого массива
                for (int j = 1; j <= 6; j++)//проверка выплнения данного условия 
                    myTwoArr[i - 1, j - 1] = ran.Next(1, 30);//вычисляем новое значение второго массива
            }

            //Вычисляем квадрат каждого элемента одномерного массива
            foreach (int fVar in myArr)
                Console.WriteLine("{0} в квадрате равно {1}", fVar, fVar * fVar);//вывод на консоль результата

            Console.WriteLine();
            //Вычислим сумму элементов многомерного массива
            foreach (int fTwoVar in myTwoArr)
                sum += fTwoVar;//вычислим значение переменной sum

            Console.WriteLine("Сумма элементов многомерного массива: {0}", sum);//вывод на консоль значения суммы 

            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
        }
    }
}