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
            try
            {
                //Вычисляем факториал числа
                int i, result = 1, num = 1;//вводим переменные целого типа int

                Console.WriteLine("Введите число:");//пользователь должен ввести число
                i = int.Parse(Console.ReadLine());//создаем переменную i, в которую заносится число, введенное с консоли

                Console.Write("\n\nФакториал {0} = ", i);//ввывод на консоль значения факториала
                do
                {
                    result *= num;//вычислим значение переменной result
                    num++;//вычислим инкремент num
                } while (num <= i);//если выполняется num <= i, то 

                Console.Write(result);//вывод на консоль значения result
            }
            catch (FormatException ex)//исключение, возникающее при попытке проанализировать строку
            {
                Console.WriteLine("Вы ввели не число. {0}", ex.Message);//вывод на консоль значения значения исключения
            }
            finally
            {
                Console.ReadLine();//ожидание нажатия клавиши Enter перед завершением работы
            }
        }
    }
}