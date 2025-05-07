using System;

namespace Практика2_Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 3.2f;
            decimal b = 2.6m;
            double c = 4.5;
            // явное преобразование decimal→double и float→double
            c = a + (double)b + c;
            Console.WriteLine($"Сумма: {c}");

        }
    }
}
