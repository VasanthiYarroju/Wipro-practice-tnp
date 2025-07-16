using System;
public class Task1{
    public static void Run()
    {
        int attempts = 0;
        string correctUsername = "admin";
        string correctPassword = "1234";

        while (attempts < 3)
        {
            Console.Write("enter your login name: ");
            string login = Console.ReadLine();
            Console.Write("enter your password: ");
            string password = Console.ReadLine();
            if (login == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("Incorrect username or password ❌");
                attempts++;
            }
        }
        Console.WriteLine("too many attempts rejected");
    }
}