using System;

namespace Практика2_Задание8
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите целое число a: ");
            int a = int.Parse(Console.ReadLine());
            int square = a * a;
            Console.WriteLine($"Квадрат числа {a} = {square}");
        }
    }
}
