using System;
public class Task2
{
    public static void Run()
    {
        int position = 1;
        Console.Write("enter first no");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter second no");
        int b = Convert.ToInt32(Console.ReadLine());
        bool found = false;
        while (a != 0)
        {
            int digit = a % 10;
            if (digit == b)
            {
                switch (position)
                {
                    case 1: Console.WriteLine("Digit is in Unit's place"); break;
                    case 10: Console.WriteLine("Digit is in Tens place"); break;
                    case 100: Console.WriteLine("Digit is in Hundreds place"); break;
                    case 1000: Console.WriteLine("Digit is in Thousands place"); break;
                    case 10000: Console.WriteLine("Digit is in Ten Thousands place"); break;
                    case 100000: Console.WriteLine("Digit is in Hundred Thousands place"); break;
                    default:
                        Console.WriteLine("Digit is beyond the Hundred thousand's place"); break;
                }
                found = true;
                break;
            }
            a /= 10;
            position *= 10;
        }
        if (!found)
        {
            Console.WriteLine("Digit not found");
        }
    }
}