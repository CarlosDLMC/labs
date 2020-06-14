using System;

namespace _25
{
    class Program
    {
        static void CreateLine(string c)
        {
            Console.WriteLine("введите количество элементов");
            int numberOfElements = int.Parse(Console.ReadLine());
            string[] array = new string[numberOfElements];
            string result = "";
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine($"{i} элемент ");
                array[i] = Console.ReadLine();
                result += array[i];
                if(i != numberOfElements - 1)
                {
                    result += c;
                }
            }
            Console.WriteLine(result);
            
            


        }
        static void Main(string[] args)
        {
            Console.WriteLine("введите симбол, которым хотите рвзделить элементы");
            string coma = Console.ReadLine();
            CreateLine(coma);
        }
    }
}
