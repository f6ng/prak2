using System;

namespace Практика2_Задание23
{
    class Program
    {
        static void Main()
        {
            // Вводим два числа
            Console.Write("Введите первое число: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double y = double.Parse(Console.ReadLine());

            // Берём модули чисел
            double absX = Math.Abs(x);
            double absY = Math.Abs(y);

            // Среднее арифметическое
            double arithmeticMean = (absX + absY) / 2.0;

            // Среднее геометрическое (корень второй степени из произведения)
            double geometricMean = Math.Sqrt(absX * absY);

            // Выводим результаты
            Console.WriteLine($"Среднее арифметическое модулей = {arithmeticMean}");
            Console.WriteLine($"Среднее геометрическое модулей  = {geometricMean}");
        }
    }
}
