using System;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int[] data = new int[30];

            int minRandomValue = 1;
            int maxRandomValue = 50;
            int lastIndex = data.Length - 1;

            Console.WriteLine("Начальный массив");
            Console.WriteLine();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(minRandomValue, maxRandomValue);
                Console.Write(data[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Перечень локальных максимумов");

            if (data[0] > data[1])
            {
                Console.Write(data[0] + " ");
            }

            for (int i = 1; i < lastIndex - 1; i++)
            {
                if (data[(i - 1)] < data[i] && data[i] > data[(i + 1)])
                {
                    Console.Write(data[i] + " ");
                }
            }

            if (data[lastIndex] > data[lastIndex - 1])
                {
                    Console.Write(data[lastIndex] + " ");
                }
            
            Console.ReadKey();
        }
    }
}
