using System;
public class Program
{
    public static void Main()
    {
        Console.Write("enter first no");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter second no");
        int num2 = Convert.ToInt32(Console.ReadLine());
        num2 = ++num1;
        Console.WriteLine("num2 = " + num2);
        num2 = num1++;
        Console.WriteLine("num2 = " + num2);
        Console.WriteLine("num1 = " + num1);

        int temp=num1;
        num1=num2;
        num2=temp;
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

    }
}