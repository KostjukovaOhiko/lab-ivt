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
            // *** Расчет стоимости капиталовложения с ***
            // *** фиксированной нормой прибыли***
            decimal money, percent;
            int i;
            const byte years = 15;//ввод неизменяемого значения целого типа

            money = 1000.0m;//ввод значения money
            percent = 0.045m;//ввод значения percent

            for (i = 1; i <= years; i++)//проверка условия (i = 1; i <= years; i++)
            {
                //если условие выполняется, то выполняется следующее:
                money *= 1 + percent;
            }

            Console.WriteLine("Общий доход за {0} лет: {1} $$", years, money);//вывод на консоль значения общего дохода
            
            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы

        }
    }
}