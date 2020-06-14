using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число в формате с плавающей точкой");
            string number = Console.ReadLine();
            Console.WriteLine("сколько знаков после запятой вы хотите?");
            string exact = Console.ReadLine();
            int ex = int.Parse(exact);
            string[] separated = number.Split('.');
            string decimals = separated[1].Substring(0, ex);
            Console.WriteLine(separated[0] + '.' + decimals);
        }
    }
}
