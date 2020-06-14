using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество строк");
            int numbOfLines = int.Parse(Console.ReadLine());
            string[] operations = new string[numbOfLines];
            for(int k = 0; k < numbOfLines; k++)
            {
                Console.WriteLine($"{k} строка");
                operations[k] = Console.ReadLine();
            }
            for(int i = 0; i < operations.Length; i++)
            {
                int opened = 0;
                int closed = 0;
                for (int j = 0; j < operations[i].Length; j++)
                {
                    if(operations[i][j] == '(')
                    {
                        opened++;
                    }else if (operations[i][j] == ')')
                    {
                        closed++;
                    }
                }
                if(closed != opened)
                {
                    Console.WriteLine($"операция {operations[i]} в индексе {i} не сбалансирована");
                }

            }

        }
    }
}
