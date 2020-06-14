using System;
using System.Collections.Generic;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string line = Console.ReadLine();
            string[] wordsarray = line.Split(" ");
            List<string> words = new List<string>();
            for(int i = 0; i < wordsarray.Length; i++)
            {
                words.Add(wordsarray[i]);
            }
            words.Sort();
            string result = "";
            for (int j = 0; j < wordsarray.Length; j++)
            {
                result += words[j] + " ";
            }
            Console.WriteLine(result);

        }
    }
}