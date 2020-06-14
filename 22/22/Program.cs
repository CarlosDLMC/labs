using System;

namespace _22
{
    class Program
    {
        static void ShowLongest(string[][] n)
        {
            int longs = 0;
            string longest = "";
            foreach (string[] line in n)
            {
               
                for (int i = 0; i < line.Length; i++)
                {
                    if(line[i].Length > longs)
                    {
                        longs = line[i].Length;
                        longest = line[i];

                    }
                }                
            }
            Console.WriteLine("элемент с наибольшим количеством символов = \"" + longest + "\"");
        }

        static void Main(string[] args)
        {
            string[][] numbers = new string[3][];
            numbers[0] = new string[3];
            numbers[1] = new string[2];
            numbers[2] = new string[4];
            numbers[0][0] = "один";
            numbers[0][1] = "два";
            numbers[0][2] = "три";
            numbers[1][0] = "четыре";
            numbers[1][1] = "пять";
            numbers[2][0] = "шесть";
            numbers[2][1] = "семь";
            numbers[2][2] = "восемь";
            numbers[2][3] = "девять";
            ShowLongest(numbers);

        }
    }
}
