using System;

namespace Практика2_Задание16
{
    class Program
    {
        static void Main()
        {
            // Считываем два целых числа
            Console.Write("Введите первое целое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе целое число: ");
            int b = int.Parse(Console.ReadLine());

            // а) Среднее арифметическое
            double arithmeticMean = (a + b) / 2.0;
            Console.WriteLine($"Среднее арифметическое = {arithmeticMean}");

            // б) Среднее геометрическое (корень 2-й степени из произведения)
            double geometricMean = Math.Pow(a * b, 1.0 / 2);
            Console.WriteLine($"Среднее геометрическое   = {geometricMean}");
        }
    }
}
