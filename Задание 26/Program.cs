using System;

namespace Практика2_Задание26
{
    class Program
    {
        static void Main()
        {
            int a, b, c;

            // a) z ≈ 3.66
            a = b = c = 2;
            double zA = a * b
                        + ((double)c++)
                          / (b - a * b * --c);
            Console.WriteLine($"a) z = {zA:F2}");  // округляем до 2 знаков

            // б) z = -1
            a = b = c = 2;
            double zB = (a * b + c++)
                        / (b - a * b * --c);
            Console.WriteLine($"б) z = {zB}");

            // в) z = 2
            a = b = c = 2;
            double zC = a * b
                        + (c++ / (b - a * b))
                          * --c;
            Console.WriteLine($"в) z = {zC}");

            // г) z = -2
            a = b = c = 2;
            double zD = a * b
                        + (c++ / b - a * b)
                          * --c;
            Console.WriteLine($"г) z = {zD}");

            // д) z = -4
            a = b = c = 2;
            double zE = a
                        * (b + c++)
                        / b
                        - a * b * --c;
            Console.WriteLine($"д) z = {zE}");
        }
    }
}
