using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Пользователь вводит с клавиатуры два числа. Первое
число — это значение, второе число процент, который
необходимо посчитать. Например, мы ввели с клавиатуры
90 и 10. Требуется вывести на экран 10 процентов от 90.
Результат: 9.*/


namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first value :  ");
            double value = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value-percent");
            double percent = double.Parse(Console.ReadLine());
            Console.WriteLine((value / 100 * percent));
        }
    }
}
