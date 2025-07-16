using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose Task (1–4):");
        int task = Convert.ToInt32(Console.ReadLine());

        switch (task)
        {
            case 1: Task1.Run(); break;
        }
    }
}
