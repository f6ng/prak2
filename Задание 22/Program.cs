using System;

namespace Практика2_Задание22
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

            // Вычисляем гипотенузу c
            double c = Math.Sqrt(a * a + b * b);

            // Периметр P = a + b + c
            double P = a + b + c;

            // Выводим результат
            Console.WriteLine($"Периметр прямоугольного треугольника P = {P}");
        }
    }
}
