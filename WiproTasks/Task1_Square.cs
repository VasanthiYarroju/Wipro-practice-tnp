using System;

public class Task1_Square
{
    public static void Run()
    {
        Console.Write("Enter side of square: ");
        int side = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Area of the square: " + (side * side));
    }
}
