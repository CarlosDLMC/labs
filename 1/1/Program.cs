using System;
using System.IO;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void DeleteLines(int n)
        {
            Console.WriteLine("введите количество строк");
            string numb = Console.ReadLine();
            int number = int.Parse(numb);
            List<string> lines = new List<string>();
            string line;
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine($"{i} строка");
                line = Console.ReadLine();
                lines.Add(line);

            }
            lines.RemoveAt(n);
            foreach(string i in lines)
            {
                Console.WriteLine(i);
            }



        }
        static void DeleteLineWithInterrogation()
        {
            Console.WriteLine("введите количество строк");
            string numb = Console.ReadLine();
            int number = int.Parse(numb);
            List<string> lines = new List<string>();
            string line;
            bool has_been_deleted = false;
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine($"{i} строка");

                line = Console.ReadLine();
               
                if (line[line.Length - 1] == '?' & !has_been_deleted)
                {
                    has_been_deleted = true;
                }
                else
                {
                    lines.Add(line);

                }

            }
            foreach (string i in lines)
            {
                Console.WriteLine(i);
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("скажите, пожалуйста, какую строку вы хотите удалить (0 - первая строка)");
            string n = Console.ReadLine();
            int N = int.Parse(n);
            DeleteLines(N);
            DeleteLineWithInterrogation();
        }
    }
}
