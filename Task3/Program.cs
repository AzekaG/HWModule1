using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Пользователь вводит с клавиатуры четыре цифры.
Необходимо создать число, содержащее эти цифры. На-
пример, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
сформировать число 1578.*/

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a, b, c, d;
            Console.WriteLine("enter a first value : ");
            a =  Console.ReadLine();
            Console.WriteLine("enter a second value : ");
            b = Console.ReadLine(); 
            Console.WriteLine("enter a fird value : ");
            c = Console.ReadLine();
            Console.WriteLine("enter a fouth value : ");
            d = Console.ReadLine();
            int value = int.Parse(a + b + c + d);
            Console.WriteLine(value);
        }
    }
}
