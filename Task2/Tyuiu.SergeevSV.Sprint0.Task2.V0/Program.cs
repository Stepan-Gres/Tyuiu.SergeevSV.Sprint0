using System;
using Tyuiu.SergeevSV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SergeevSV.Sprint0.Task2.V0
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Вызываем метод из библиотеки классов
            Console.WriteLine(DataService.GetMessage("Степан"));
            Console.ReadKey();
        }
    }
}
