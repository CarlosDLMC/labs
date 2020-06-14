using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку b");
            string b = Console.ReadLine();
            Console.WriteLine("введите число n");
            int n = int.Parse(Console.ReadLine()); 
            if(b.Length > n)
            {
                string rest = b.Substring(b.Length - n, n);
                Console.WriteLine(rest);
            }
            else if(n > b.Length)
            {
                string rest = "";
                for(int i = 0; i < (n - b.Length); i++)
                {
                    rest += ".";
                }
                Console.WriteLine(rest + b);
            }

        }
    }
}
