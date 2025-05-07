using System;

namespace Практика2_Задание15
{
    class Program
    {
        static void Main()
        {
            // Объявляем переменные
            float z;
            int a = 1, b = 2, c = 3;
            const int m = 3;

            // Вычисляем z
            z = (a + b + c) / m;

            // Выводим результат
            Console.WriteLine($"Результат z = {z}");
        }
    }
}
