using System;

class find
{
    public static void Main()
    {
        int get;
        int position = 0;
        int temp = 0;
        int[] data = new int[10];
        Console.WriteLine("Enter Data Inside The Array");
        Console.WriteLine("________________________________");
        foreach (int i in data)
        {
            Console.Write("Data[i] = ", i);
            data[i] = Int32.Parse(Console.ReadLine());
        }
        Console.Write("Which Value Do You Search :  ");
        get = Int32.Parse(Console.ReadLine());
        foreach (int i in data)
        {
            if (data[i] == get)
            {
                temp = 1;
                break;
            }
            position = i;
        }
        if (temp == 1)
        {
            Console.WriteLine("{0} is found at position {1}", get, position + 1);
        }
        else
        {
            Console.WriteLine("{0} is not found in the array", get);
        }
    }
}