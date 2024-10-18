using System;

public class Program
{
    static int number;

    public static void Main(string[] args)
    {
        Console.WriteLine(" :) | Hello! Please enter your grade down below for a letter equivalent! (integers only)");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine();
        GradeCalculator();

    }

    public static void GradeCalculator()
    {
        if (number >= 100)
        {
            Console.WriteLine(" B) | Letter grade: A+");
            Console.WriteLine("    | Wow! 100... that's impressive!");
        }
        else if (number >= 90)
        {
            Console.WriteLine(" :D | Letter grade: A");
            Console.WriteLine("    | Very nice!");
        }
        else if (number >= 80)
        {
            Console.WriteLine(" :) | Letter grade: B");
            Console.WriteLine("    | Keep it up!");
        }
        else if (number >= 70)
        {
            Console.WriteLine(" :> | Letter grade: C");
            Console.WriteLine("    | You got this, keep working!");
        }
        else if (number >= 60)
        {
            Console.WriteLine(" :T | Letter grade: D");
            Console.WriteLine("    | Keep trying!");
        }
        else
        {
            Console.WriteLine(" :} | Letter grade: E");
            Console.WriteLine("    | Don't give up!");
        }
    }
}