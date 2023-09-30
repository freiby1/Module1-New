using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAVG
{
    internal class ArrayAVG
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[15];
            Random random = new Random();

            // Заполнение массива случайными числами
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-100, 100); // Генерируем случайные числа от -100 до 99
            }

            Console.WriteLine("Сгенерированный массив чисел:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            double positiveSum = 0;
            int positiveCount = 0;

            // Вычисление суммы и количества положительных чисел
            foreach (int num in numbers)
            {
                if (num > 0)
                {
                    positiveSum += num;
                    positiveCount++;
                }
            }

            if (positiveCount > 0)
            {
                double average = positiveSum / positiveCount;
                Console.WriteLine($"Среднее значение положительных чисел в массиве: {average}");
            }
            else
            {
                Console.WriteLine("В массиве нет положительных чисел.");
            }
            Console.ReadLine();
        }
    }
}
