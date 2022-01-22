using System;
using mymath;

class calc
{
    public static void Main(String[] args)
    {
        Scanner get = new Scanner(System.in);
        int firstNum,secondNum,sum,multip;
        String sign;
        int res;

        Console.Write("Enter A = ");
        firstNum = Int32.Parse(Console.ReadLine());
        Console.Write("Enter B = ");
        secondNum = Int32.Parse(Console.ReadLine());
        Console.Write("Sign = ");
        sign = Console.ReadLine();

        if(sign == "+")
        {
            res = ForAdd.add(x,y)
            System.out.println("Sum = {0}",res);
        }
        else if(sign == "*")
        {
            res = ForAdd.multi(x,y)
            System.out.println("Product = {0}",res);
        }
    }
}