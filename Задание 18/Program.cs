using System;

namespace Практика2_Задание18
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите коэффициент a (не должен быть равен 0): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = double.Parse(Console.ReadLine());

            // Решаем ax + b = 0 → x = -b / a
            double x = -b / a;
            Console.WriteLine($"Решение уравнения: x = {x}");
        }
    }
}
