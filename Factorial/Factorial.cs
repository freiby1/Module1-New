using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                long factorial = CalculateFactorial(number);
                Console.WriteLine($"Факториал числа {number} равен {factorial}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ошибка: Неверный формат числа.");
                Console.ReadLine();
            }
        }

        private static long CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            return n * CalculateFactorial(n - 1);
        }
    }
}
