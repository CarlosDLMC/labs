using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string line = Console.ReadLine();
            string[] words = line.Split(" ");
            string definitive = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                definitive += words[i] + " ";
                
            }
            Console.WriteLine(definitive);

        }
    }
}
