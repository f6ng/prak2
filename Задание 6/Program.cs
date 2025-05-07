using System;

namespace Практика2_Задание6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double x = double.Parse(Console.ReadLine());
            double rounded = Math.Round(x, 2);
            Console.WriteLine($"Округление до сотых: {rounded}");

        }
    }
}
