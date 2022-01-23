using System;

class stud
{
    public string name;
    public int rno;
    public string[] sub = new string[6] {
            "Chemistry", "Physics", "Mathes",
            "GK", "English", "Computer"
        };
    public int[] marks = new int[6];
    public int totalMarks = 600;
    public int obtainMarks = 0;
    public float per;

    public static void Main()
    {
        stud s = new stud();
        get_data();
        cal_data();
        display();
    }

    public static void get_data()
    {
        stud s = new stud();
        Console.Write("Enter Roll No : ");
        s.rno = Int32.Parse(Console.ReadLine());
        Console.Write("Enter Name : ");
        s.name = Console.ReadLine();
        for (int i = 0; i < s.marks.Length; i++)
        {
            Console.Write("Enter Marks of {0} = ", s.sub[i]);
            s.marks[i] = Int32.Parse(Console.ReadLine());
        }
        Console.WriteLine();
    }

    public static void cal_data()
    {
        stud s = new stud();
        for (int i = 0; i < s.marks.Length; i++)
        {
            s.obtainMarks = s.obtainMarks + s.marks[i];
        }
        s.per = s.obtainMarks / s.totalMarks * 100;
    }

    public static void display()
    {
        stud s = new stud();
        Console.WriteLine("******************************************************");
        Console.WriteLine("*                    Final Marksheet                 *");
        Console.WriteLine("******************************************************");
        Console.WriteLine("*  Roll No : {0}                                     *", s.rno);
        Console.WriteLine("*  Name : {0}                                        *", s.name);
        Console.WriteLine("******************************************************");
        for (int i = 0; i < s.sub.Length; i++)
        {
            Console.Write("{0, -5}", i + 1);
            Console.Write("{0, -19} {1}", s.sub[i], s.marks[i]);
            Console.WriteLine();
        }
        Console.WriteLine("******************************************************");
        Console.WriteLine("*  Obtained Marks : {0}                              *", s.obtainMarks);
        Console.WriteLine("*  Percentage : {0}                                  *", s.per);
        if (s.per >= 85)
        {
            Console.WriteLine("*  Remarks : Excellent                           *");
        }
        else if (s.per < 75)
        {
            Console.WriteLine("*  Remarks : Very Good                           *");
        }
        else if (s.per < 65)
        {
            Console.WriteLine("*  Remarks : Good                                *");
        }
        else if (s.per < 45)
        {
            Console.WriteLine("*  Remarks : Need Improvement                    *");
        }
        else if (s.per > 33)
        {
            Console.WriteLine("*  Remarks : Fail, Better Luck Next Tim          *");
        }
        Console.WriteLine("******************************************************");
    }
}