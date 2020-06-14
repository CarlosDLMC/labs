using System;

namespace _24
{
    class Program
    {
        static void CreateArray(string c)
        {
            string line = "один, два, три, четыре, пять, шесть, семь, восемь, девять";
            string[] words = line.Split(c);
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
        }
        static void Main(string[] args)
        {
            CreateArray(",");
        }
    }
}
