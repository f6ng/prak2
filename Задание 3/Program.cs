using System;

namespace Практика2_Задание3
{
    class Program
    {
        static void Main()
        {
            // Создаём генератор случайных чисел
            Random rnd = new Random();

            // Выводим случайное число от 0 до Int32.MaxValue
            Console.WriteLine(rnd.Next());

            // Выводим случайное число от 0 до 4
            Console.WriteLine(rnd.Next(5));

            // Выводим случайное число от -5 до 4
            Console.WriteLine(rnd.Next(-5, 5));
        }
    }
}
