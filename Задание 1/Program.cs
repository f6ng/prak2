using System;

namespace Практика2_Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next());     // от 0 до Int32.MaxValue
            Console.WriteLine(rnd.Next(5));    // от 0 до 4
            Console.WriteLine(rnd.Next(-5, 5)); // от -5 до +4

        }
    }
}