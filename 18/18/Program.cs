using System;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string line = Console.ReadLine();
            string result = "";
            string semiresult = "";
            for(int i = 1; i < line.Length; i += 2)
            {
                result += line[i];
            }
            for (int j = 0; j < line.Length; j += 2)
            {
                semiresult += line[j];
            }
            for(int k = semiresult.Length - 1; k >= 0; k--)
            {
                result += semiresult[k];
            }
            Console.WriteLine(result);

        }
    }
}
