using System;

namespace Практика2_Задание9
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double c))
            {
                double rounded = Math.Round(c, 2);
                Console.WriteLine($"Округлённое до сотых: {rounded}");
            }
            else
            {
                Console.WriteLine("Ошибка: введено не корректное число.");
            }
        }
    }
}
