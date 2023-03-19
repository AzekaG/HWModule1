using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Пользователь вводит с клавиатуры два числа. Нужно
показать все четные числа в указанном диапазоне. Если
границы диапазона указаны неправильно требуется про-
извести нормализацию границ. Например, пользователь
ввел 20 и 11, требуется нормализация, после которой
начало диапазона станет равно 11, а конец 20.*/


namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first value : ");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second value : ");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Value 1 "+ value1);
            Console.WriteLine("Value 2 "+ value2);
            if (value2 < value1)
            {
                int temp = value2;
                value2 = value1;
                value1 = temp;
            };
            for(int i = value1; i <= value2; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i + " ");
            }


        }
    }
}
