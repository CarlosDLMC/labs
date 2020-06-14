using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("если хотите перевести двоичное число в десятичное, нажмите 1. Если наоборот, нажмите 2");
            string option = Console.ReadLine();
            if(option == "1")
            {
                Console.WriteLine("введите бинарное число");
                string num = Console.ReadLine();
                int number = Convert.ToInt32(num, 2);
                Console.WriteLine(number);
            }
            else if(option == "2")
            {
                Console.Write("введите десятичное число: ");
                int decimalNumber = int.Parse(Console.ReadLine());

                int remainder;
                string result = "";
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 2;
                    decimalNumber /= 2;
                    result = remainder.ToString() + result;
                }
                Console.WriteLine(result);
            }
        }
    }
}
