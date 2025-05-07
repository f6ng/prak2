using System;

namespace Практика2_Задание7
{
    class Program
    {
        static void Main()
        {
            int a = 3;
            double b = 2.6;

            // При вычислении a неявно приводится к double,
            // и результат (double) записывается в переменную b
            b = a + b;

            Console.WriteLine($"Сумма a + b = {b}");
        }
    }
}
