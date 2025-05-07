using System;

namespace Практика2_Задание20
{
    class Program
    {
        static void Main()
        {
            // Вводим катеты a и b
            Console.Write("Введите катет a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите катет b: ");
            double b = double.Parse(Console.ReadLine());

            // Вычисляем гипотенузу по теореме Пифагора c² = a² + b²
            double c = Math.Sqrt(a * a + b * b);

            // Выводим результат
            Console.WriteLine($"Гипотенуза c = {c}");
        }
    }
}
