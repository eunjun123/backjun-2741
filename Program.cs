using System;
using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int temp = int.Parse(Console.ReadLine());
            for (int i = 1; i <= temp; i++)
            {
                stringBuilder.Append(i + "\n");
            }
            Console.WriteLine(stringBuilder);
        }
    }