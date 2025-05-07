using System;

namespace Практика2_Задание21
{
    class Program
    {
        static void Main()
        {
            // Вводим внешний радиус R и внутренний радиус r
            Console.Write("Введите внешний радиус R: ");
            double R = double.Parse(Console.ReadLine());
            Console.Write("Введите внутренний радиус r: ");
            double r = double.Parse(Console.ReadLine());

            // Вычисляем площадь кольца S = π (R² – r²)
            double S = Math.PI * (R * R - r * r);

            // Выводим результат
            Console.WriteLine($"Площадь кольца S = {S}");
        }
    }
}
