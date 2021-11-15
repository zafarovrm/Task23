using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {
        static void Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Thread.Sleep(1000);
            Console.WriteLine($"Факториал равен {result}");
        }       
        static async void FactorialAsync(int n)
        {
            Console.WriteLine("Начало метода FactorialAsync");
            await Task.Run(() => Factorial(n));
            Console.WriteLine("Конец метода FactorialAsync");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int n = Int32.Parse(Console.ReadLine());
            FactorialAsync(n);           

            Console.ReadKey();
        }
    }
}      