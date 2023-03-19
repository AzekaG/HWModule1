using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Пользователь вводит с клавиатуры показания тем-
пературы. В зависимости от выбора пользователя про-
грамма переводит температуру из Фаренгейта в Цельсий
или наоборот.*/

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a type of  temperature : 1 - Celsij , 2 - Farengejt : ");
            int choice = int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Enter a temperature in Format 00.0");
            double temperature = double.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("All ok ");
                Console.WriteLine($"The temperature in Celsij : {temperature}");
                Console.WriteLine($"The temperature in Farengejt : {temperature*(9/5)+32}");
            }
            else
            {
                Console.WriteLine($"The temperature in Celsij : {(temperature-32)*5/9}");
                Console.WriteLine($"The temperature in Farengejt : {temperature }");
            }
           

        }
    }
}
