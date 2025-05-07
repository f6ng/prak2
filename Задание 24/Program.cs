using System;

namespace Практика2_Задание24
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число a: ");
            double a = double.Parse(Console.ReadLine());

            // 1 операция: a² = a * a
            double a2 = a * a;

            // 2 операции: a⁴ = a2 * a2
            double a4 = a2 * a2;

            // 3 операции: a⁶ = a4 * a2
            double a6 = a4 * a2;

            // 4 операции: a⁷ = a6 * a
            double a7 = a6 * a;

            // 3 операции: a⁸ = a4 * a4
            double a8 = a4 * a4;

            // 4 операции: a⁹ = a8 * a
            double a9 = a8 * a;

            // 4 операции: a¹⁰ = a2 * a8
            double a10 = a2 * a8;

            // Вывод результатов
            Console.WriteLine($"a²  (1 операция) = {a2}");
            Console.WriteLine($"a⁴  (2 операции) = {a4}");
            Console.WriteLine($"a⁶  (3 операции) = {a6}");
            Console.WriteLine($"a⁷  (4 операции) = {a7}");
            Console.WriteLine($"a⁸  (3 операции) = {a8}");
            Console.WriteLine($"a⁹  (4 операции) = {a9}");
            Console.WriteLine($"a¹⁰ (4 операции) = {a10}");
        }
    }
}
