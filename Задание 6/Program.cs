using System;

namespace Практика2_Задание6
{
    class Program
    {
        static void Main()
        {
            float a = 3.2f;
            decimal b = 2.6m;
            double c = 4.5;

            // Приводим все к типу double явно:
            c = (double)a    // преобразуем float → double
              + (double)b    // преобразуем decimal → double
              + c;           // прибавляем исходное c

            Console.WriteLine($"Сумма a + b + c = {c}");
        }
    }
}
