using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string line = Console.ReadLine();
            string[] words = line.Split(" ");
            string definitive = "";
            foreach(string word in words)
            {
                definitive += char.ToUpper(word[0]) + word.Substring(1) + " ";
            }
            Console.WriteLine(definitive);
        }
    }
}