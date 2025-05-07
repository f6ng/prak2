using System;

namespace Практика2_Задание19
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите a (не 0): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Введите e: ");
            double e = double.Parse(Console.ReadLine());

            // Преобразуем уравнение a·x² - b·x + c = e в стандартный вид: a·x² - b·x + (c - e) = 0
            double C = c - e;

            // Дискриминант D = b² - 4·a·(c - e)
            double D = Math.Pow(b, 2) - 4 * a * C;

            if (D < 0)
            {
                Console.WriteLine("Корней нет (D < 0).");
            }
            else
            {
                // По формуле x = [b ± √D] / (2·a)
                double sqrtD = Math.Sqrt(D);
                double x1 = (b + sqrtD) / (2 * a);
                double x2 = (b - sqrtD) / (2 * a);
                Console.WriteLine($"x₁ = {x1}");
                Console.WriteLine($"x₂ = {x2}");
            }
        }
    }
}
