using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string line = Console.ReadLine();
            string[] parts = line.Split(".");
            if(parts.Length > 2)
            {
                string result = "";
                for(int i = 1; i < parts.Length - 1; i++)
                {
                    result += parts[i];
                    if(i != parts.Length - 2)
                    {
                        result += ".";
                    }
                }
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine(line);
            }
            

            

            
        }
    }
}
