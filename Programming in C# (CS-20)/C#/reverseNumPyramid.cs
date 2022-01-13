using System;

class Program
{

    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        for (int i = n; i >= 0; i--)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j.ToString());
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}