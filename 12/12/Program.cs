using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string line = Console.ReadLine();
            string[] words = line.Split(" ");
            string definitive = "";
            for(int i = 0; i < words.Length; i++)
            {
                definitive += words[i];
                if(i != words.Length - 1)
                {
                    definitive += ".";
                }
            }
            Console.WriteLine(definitive);

        }
    }
}
