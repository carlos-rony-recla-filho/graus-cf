using System;

namespace graus_cf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Double celsius, fahr;

            Console.WriteLine("bem vindo ao convrsor de graus C° em F°!");

            Console.WriteLine("\nDigite o valor em graus Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahr = celsius * 1.8 + 32;

            Console.WriteLine($"{celsius}° equivale a {fahr}°F");

        }
    }
}
