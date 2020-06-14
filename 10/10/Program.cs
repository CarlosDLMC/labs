using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string line = Console.ReadLine();
            string[] words = line.Split(" ");
            char[] firsts = new char[words.Length];
            char[] lasts = new char[words.Length];
            int quantity;
            for(int i = 0; i < words.Length; i++)
            {
                firsts[i] = words[i][0];
                lasts[i] = words[i][words[i].Length - 1];
            }
            for(int j = 0; j < words.Length; j++)
            {
                quantity = -1;
                for (int k = 0; k < words.Length; k++)
                {
                    
                    if(firsts[j] == firsts[k] & lasts[j] == lasts[k])
                    {
                        quantity += 1;
                    }
                    
                }
                Console.WriteLine($"есть {quantity} слов(о/а), которые начинаются и заканчиваются с такой же буквой что у сдова в индексе {j}");
            }
        }
    }
}
