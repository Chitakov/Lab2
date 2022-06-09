using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number == 0)
            {
                Console.WriteLine("Число в двоичной системе счисления - 0");
                Console.ReadLine();
            }
            else if (number > 0)
            {
                string result = "";
                int temp = number;
                while (number > 0)
                {
                    temp = number % 2;
                    if (temp == 0) result += "0";
                    else result += "1";
                    number /= 2;
                }
                char[] charArray = result.ToCharArray();
                Array.Reverse(charArray);
                string result1 = new string(charArray);
                Console.WriteLine("Число в двоичной системе счисления - " + result1);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Число не является неотрицательным");
                Console.ReadLine();
            }
        }
    }
}
