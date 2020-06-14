using System;
using System.IO;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void LongestLine()
        {
            Console.WriteLine("введите количество строк");
            string numb = Console.ReadLine();
            int number = int.Parse(numb);
            string line;
            string[] lines = new string[number];
            int max = 0;
            int indexmax = 0;
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine($"{i} строка");
                line = Console.ReadLine();
                lines[i] = line;
                if(line.Length > max)
                {
                    max = line.Length;
                    indexmax = i;
                }
            }
            Console.WriteLine($"самая длинная строка: {lines[indexmax]} длиной {max} с индексом {indexmax}");

        }
        static void Main(string[] args)
        {
            LongestLine();
        }
    }
}
