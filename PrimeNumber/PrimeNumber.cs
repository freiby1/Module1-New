using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (IsPrime(number))
                {
                    Console.WriteLine($"{number} является простым числом.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"{number} не является простым числом.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Неверный формат числа.");
                Console.ReadLine();
            }
        }
        private static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            if (num <= 3)
            {
                return true;
            }
            if (num % 2 == 0 || num % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
