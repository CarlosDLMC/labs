using System;

namespace _4
{
    class Program
    {
        static void ReverseEveryLine()
        {
            Console.WriteLine($"введите количество строк");
            string num = Console.ReadLine();
            int number = int.Parse(num);
            string[] lines = new string[number];
            string[] reverselines = new string[number];
            string line;
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine($"{i} строка");
                line = Console.ReadLine();
                lines[i] = line;
            }
            int indexrev = 0;
            foreach(string j in lines)
            {
                int size = j.Length;
                char[] reversion = new char[size];
                int a = 0;

                foreach (char c in j)
                {
                    reversion[a] = c;
                    a++;
                }
                
                Array.Reverse(reversion);
                reverselines[indexrev] = new string(reversion);
                indexrev++;
            }
            Console.WriteLine("каждая строка на своём месте");
            foreach(string k in reverselines)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("строки в обратном порядке");
            for(int p = reverselines.Length - 1; p >= 0; p--)
            {
                Console.WriteLine(reverselines[p]);
            }
            
        }
        static void Main(string[] args)
        {
            ReverseEveryLine();
        }
    }
}
