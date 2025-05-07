using System;

namespace Практика2_Задание25
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите четырёхзначное число: ");
            int n = int.Parse(Console.ReadLine());

            // Извлекаем отдельные цифры через деление и остаток от деления
            int d1 = n / 1000;         // первая цифра (тысячи)
            int d2 = (n / 100) % 10;   // вторая цифра (сотни)
            int d3 = (n / 10) % 10;    // третья цифра (десятки)
            int d4 = n % 10;           // четвёртая цифра (единицы)

            // Сумма и произведение цифр
            int sum = d1 + d2 + d3 + d4;
            int product = d1 * d2 * d3 * d4;

            // Вывод результатов
            Console.WriteLine($"Сумма цифр = {sum}");
            Console.WriteLine($"Произведение цифр = {product}");
        }
    }
}
