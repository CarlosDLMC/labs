using System;
using System.Collections.Generic;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> letters = new List<string> { "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            Console.WriteLine("введите строку");
            string line = Console.ReadLine();
            Console.WriteLine("введите число к");
            int k = int.Parse(Console.ReadLine());
            string result = "";
            for(int i = 0; i < line.Length; i++)
            {
                int index = letters.IndexOf(line[i].ToString());
                if (index + k < letters.IndexOf("я"))
                {
                    result += letters[index + k];
                }
                else
                {
                    result += letters[index + k - letters.IndexOf("я")];
                }

            }
            Console.WriteLine(result);

        }
    }
}