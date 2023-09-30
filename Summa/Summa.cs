using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summa
{
    internal class Summa
    {
        static void Main(string[] args)
        {
                Console.Write("Введите первое целое число: ");
                if (int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.Write("Введите второе целое число: ");
                    if (int.TryParse(Console.ReadLine(), out int num2))
                    {
                        int sum = num1 + num2;
                        Console.WriteLine($"Сумма чисел {num1} и {num2} равна {sum}");
                        Console.ReadLine();
                }
                    else
                    {
                        Console.WriteLine("Ошибка: Неверный формат второго числа.");
                        Console.ReadLine();
                }
                }
                else
                {
                    Console.WriteLine("Ошибка: Неверный формат первого числа.");
                    Console.ReadLine();
            }
        }
    }
}
