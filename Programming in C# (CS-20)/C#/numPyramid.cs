using System;
class NumberPattern
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Int32.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}