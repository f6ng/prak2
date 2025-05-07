using System;

namespace Практика2_Задание17
{
    class Program
    {
        static void Main()
        {
            // Считываем массу и объём тела
            Console.Write("Введите массу тела (m) в килограммах: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введите объём тела (V) в кубических метрах: ");
            double V = double.Parse(Console.ReadLine());

            // По формуле m = p * V => p = m / V
            double density = m / V;
            Console.WriteLine($"Плотность материала p = {density} кг/м³");
        }
    }
}
