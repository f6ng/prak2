using System;

namespace Практика2_Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите a (минимум): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b (максимум): ");
            int b = int.Parse(Console.ReadLine());
            int value = rnd.Next(a, b);
            Console.WriteLine($"Случайное число от {a} до {b - 1}: {value}");

        }
    }
}
