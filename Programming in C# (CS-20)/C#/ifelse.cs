using System;

class test
{
    public static void Main()
    {
        int i = 5;
        i = Int32.Parse(Console.ReadLine());
        if (i < 18)
        {
            Console.WriteLine("You are not able to Drive Car");
        }
        else if (i > 18)
        {
            Console.WriteLine("You are able to Drive Car {0}", i);
        }
        else
        {
            Console.WriteLine("I am In ELSE");
        }
    }

}