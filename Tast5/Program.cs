using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Пользователь вводит с клавиатуры дату. Приложе-
ние должно отобразить название сезона и дня недели.
Например, если введено 22.12.2021, приложение должно
отобразить Winter Wednesday.*/



namespace Tast5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date in format   dd.mm.year");
            DateTime date = DateTime.Parse(Console.ReadLine());
            if (date.Month == 1 || date.Month == 2 || date.Month == 12) Console.Write("Winter ");
            else if (date.Month >= 3 || date.Month <= 5) Console.Write("Spring ");
            else if (date.Month >= 6 || date.Month <= 8) Console.Write("Summer ");
            else Console.Write("Autumn ");
            Console.WriteLine(date.DayOfWeek);

        }
    }
}
