using System;

class calc
{
    public static void Main(String[] args)
    {
        int num1, num2, res;
        num1 = int.Parse(args[0]);
        num2 = int.Parse(args[2]);

        if (args[1] == "+")
        {
            res = num1 + num2;
            Console.WriteLine("{0} {1} {2} = {3}", num1, args[1], num2, res);
        }
        else if (args[1] == "-")
        {
            res = num1 - num2;
            Console.WriteLine("{0} {1} {2} = {3}", num1, args[1], num2, res);
        }
        else if (args[1] == "*")
        {
            res = num1 * num2;
            Console.WriteLine("{0} {1} {2} = {3}", num1, args[1], num2, res);
        }
        else if (args[1] == "/")
        {
            res = num1 / num2;
            Console.WriteLine("{0} {1} {2} = {3}", num1, args[1], num2, res);
        }
        else
        {
            Console.WriteLine("Enter Proper Values.");
        }
    }
}