using System;

namespace _23
{
    class Program
    {
        static void ShowInLine(string[][] n, string c)
        {
            string line = "";
            for (int i = 0; i < n.Length; i++)
            {

                for (int j = 0; j < n[i].Length; j++)
                {
                    line += n[i][j];
                    if(n[i][j] != n[n.Length - 1][n[n.Length -1].Length - 1])
                    {
                        line += c;
                    }
                }
            }
            Console.WriteLine(line);
            
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
            ShowInLine(numbers, ",");

        }
    }
}