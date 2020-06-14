using System;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("напишите слово");
            string word = Console.ReadLine();
            string reverseword = "";
            for(int i = word.Length - 1; i >= 0; i--)
            {
                reverseword += word[i];
            }
            if(word == reverseword)
            {
                Console.WriteLine("данное слово является палиндромом");
            }
            else
            {
                Console.WriteLine("данное слово не является палиндромом");
            }

        }
    }
}
