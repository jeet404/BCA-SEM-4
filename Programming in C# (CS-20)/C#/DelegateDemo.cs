using System;

public class DelDemo
{
    public delegate void Dal1(int a, int y);
    public void Add(int a, int b)
    {
        Console.WriteLine("Sum = {0}", a + b);
    }
    public void product(int a, int b)
    {
        Console.WriteLine("Product = {0}", a * b);
    }
}

class main
{
    public static void Main()
    {
        Dal1 d = new Dal1(DelDemo.add);
    }
}