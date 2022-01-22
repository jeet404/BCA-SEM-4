import java.util.*;

public class salcalc
{
    public static void main(String[] args)
    {
        Scanner input = new Scanner(System.in);

        String gender;
        int sal, ta, da, netsal;
        
        System.out.print("Enter Gender : ");
        gender = input.nextLine();
        System.out.print("Enter Salary : ");
        sal = input.nextInt();

        if (gender.equals("M"))
        {
            if (sal < 10000)
            {
                ta = (sal * 5) / 100;
                da = (sal * 10) / 100;
                netsal = sal + ta + da;
                System.out.println("Your Total Salary is : " + netsal);
            }
            else if (sal >= 10000 && sal < 60000)
            {
                ta = (sal * 6) / 100;
                da = (sal * 11) / 100;
                netsal = sal + ta + da;
                System.out.println("Your Total Salary is : " + netsal);
            }
            else if (sal >= 60000)
            {
                ta = (sal * 7) / 100;
                da = (sal * 12) / 100;
                netsal = sal + ta + da;
                System.out.println("Your Total Salary is : " + netsal);
            }
        }
        else if (gender.equals("F"))
        {
            if (sal < 10000)
            {
                ta = (sal * 4) / 100;
                da = (sal * 9) / 100;
                netsal = sal + ta + da;
                System.out.println("Your Total Salary is : " + netsal);
            }
            else if (sal >= 10000 && sal < 60000)
            {
                ta = (sal * 5) / 100;
                da = (sal * 10) / 100;
                netsal = sal + ta + da;
                System.out.println("Your Total Salary is : " + netsal);
            }
            else if (sal >= 60000)
            {
                ta = (sal * 6) / 100;
                da = (sal * 11) / 100;
                netsal = sal + ta + da;
                System.out.println("Your Total Salary is : " + netsal);
            }
        }
    }
}