using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*   Пользователь вводит шестизначное число. После чего
пользователь вводит номера разрядов для обмена цифр.
Например, если пользователь ввёл один и шесть — это
значит, что надо обменять местами первую и шестую
цифры.
Число 723895 должно превратиться в 523897.
Если пользователь ввел не шестизначное число тре-
буется вывести сообщение об ошибке.;*/



namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 6's digits value : ");
            int value = int.Parse(Console.ReadLine());
            int[] myArray = new int[6];
            if (value < 99999 || value > 999999) { Console.WriteLine("Incorrect value."); return; }

            Console.WriteLine("Enter a first digit");
            int parametr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second digit");
            int parametr2 = int.Parse(Console.ReadLine());
            for(int i = 0; i < 6; i ++) 
            {
                myArray[i] = value % 10;
                value /= 10;
               
            }
            int temp = myArray[parametr1-1];
            myArray[parametr1-1] = myArray[parametr2-1];
            myArray[parametr2 - 1] = temp;
            for (int i = 0; i < 6; i++)
            {
                value += myArray[i];
                value *= 10;

            }
            value /= 10;
            Console.WriteLine(value);







        }
    }
}
