using System;

namespace Практика2_Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Квадрат числа {a} равен {a * a}");

        }
    }
}
