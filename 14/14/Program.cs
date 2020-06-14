using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string line = Console.ReadLine();
            string[] words = line.Split(" ");
            string result = "";
            for(int i = 0; i < words.Length; i++)
            {
                result += words[i].Substring(1, words[i].Length - 2) + " ";
            }
            Console.WriteLine(result);
        }
    }
}
