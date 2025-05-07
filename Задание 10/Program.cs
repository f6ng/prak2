using System;

namespace Практика2_Задание10
{
    class Program
    {
        static void Main()
        {
            // Получаем значение числа e
            double e = Math.E;

            // Округляем до десятых
            double rounded = Math.Round(e, 1);

            // Выводим результат
            Console.WriteLine($"Число e до десятых = {rounded}");
        }
    }
}
