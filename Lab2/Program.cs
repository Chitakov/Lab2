using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите корень n-ой степени: ");
            double n = double.Parse(Console.ReadLine());

            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Введите точность: ");
            double eps = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Результат: " + SqrtN(n, number, eps));
            Console.WriteLine("Результат, возвращаемый методом Math.Pow: " + Math.Pow(number, 1 / n));
            Console.ReadKey();
        }
        static double SqrtN(double n, double number, double eps)
        {
            var x0 = number / n;
            var x1 = (1 / n) * ((n - 1) * x0 + number / Math.Pow(x0, n - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + number / Math.Pow(x0, n - 1));
            }
            return x1;
        }
    }
}
