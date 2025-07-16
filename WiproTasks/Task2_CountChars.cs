using System;

public class Task2_CountChars
{
    public static void Run()
    {
        Console.Write("Enter a string: ");
        string? input = Console.ReadLine();  // Nullable string

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("No input provided.");
            return;
        }

        int digitCount = 0;
        int letterCount = 0;

        foreach (char ch in input)
        {
            if (char.IsDigit(ch))
                digitCount++;
            else if (char.IsLetter(ch))
                letterCount++;
        }

        Console.WriteLine("Number of alphabets: " + letterCount);
        Console.WriteLine("Number of digits: " + digitCount);
    }
}
