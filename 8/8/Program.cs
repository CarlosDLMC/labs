using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите первую строку");
            string a1 = Console.ReadLine();
            Console.WriteLine("введите сторую строку");
            string a2 = Console.ReadLine();
            string[] cut = a1.Split(a2);
            string result = "";
            for(int i =0; i < cut.Length; i++)
            {
                result += cut[i];
            }
            Console.WriteLine(result);


        }
    }
}
