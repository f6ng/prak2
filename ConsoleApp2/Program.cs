using System;

namespace Практика2_Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            double b = 2.6;
            double sum = a + b;  // int неявно приводится к double
            Console.WriteLine($"Сумма: {sum}");

        }
    }
}
