using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string line = Console.ReadLine();
            string[] words = line.Split(" ");
            int quantity = 0;
            foreach(string word in words)
            {
                string[] letters = word.Split("a");
                if(letters.Length - 1 == 3)
                {
                    quantity++;
                }
            }
            Console.WriteLine($"есть {quantity}  слов(о/а), которые содержат 3 \"a\"");
        }
    }
}
