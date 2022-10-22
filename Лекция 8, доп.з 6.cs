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
            byte var1 = 250;//ввод переменной целого типа byte
            byte var2 = 150;//ввод переменной целого типа byte
            try
            {
                byte sum = checked((byte)(var1 + var2));//компилятор генерирует проверку на предмет условий переполнения
                Console.WriteLine("Сумма: {0}", sum);//вывод суммы на консоль
            }
            catch (OverflowException ex)//в случае возникновения условия переполнения во время выполнения генерируется исключение
            {
                Console.WriteLine(ex.Message);//вывод на консоль значения значения исключения

                Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
            }

        }
    }
}