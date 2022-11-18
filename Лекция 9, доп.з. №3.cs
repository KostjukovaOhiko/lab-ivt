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
            string myStr;
            Console.WriteLine("Введите строку: ");//пользователь должен ввести строку

            myStr = Console.ReadLine();//ожидание нажатия клавиши Enter 

            if (myStr.Length < 5)//проверка выполнения данного условия 1,если оно выполняется, то
                 //вывод на консоль \nВ данной строке меньше 5 символов  
                Console.WriteLine("\nВ данной строке меньше 5 символов");
            else if ((myStr.Length >= 5) && (myStr.Length <= 12))//если условие 1 не выполняется, но выполняется данное условие 2, то
                //вывод на консоль \nВ данной строке {0} символов
                Console.WriteLine("\nВ данной строке {0} символов", myStr.Length);
            else Console.WriteLine("\nВ данной строке больше 12 символов");//если ни одно условие не выполняется, то вывод на консоль \nВ данной строке больше 12 символов

            Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
        }
    }
}