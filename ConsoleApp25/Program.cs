using System;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int[] numbers = new int[30];

            int minRandomValue = 1;
            int maxRandomValue = 50;
            int lastIndex = numbers.Length - 1;

            Console.WriteLine("Начальный массив");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandomValue, maxRandomValue);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Перечень локальных максимумов");

            if (numbers[0] > numbers[1])
            {
                Console.Write(numbers[0] + " ");
            }

            for (int i = 1; i < lastIndex; i++)
            {
                if (numbers[(i - 1)] < numbers[i] && numbers[i] > numbers[(i + 1)])
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            if (numbers[lastIndex] > numbers[lastIndex - 1])
                {
                    Console.Write(numbers[lastIndex] + " ");
                }
            
            Console.ReadKey();
        }
    }
}
