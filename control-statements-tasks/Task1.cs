using System;

public class Task1
{
    public static void Run()
    {
        int attempts = 0;
        string correctUsername = "admin";
        string correctPassword = "1234";
        bool isAuthenticated = false;

        while (attempts < 3)
        {
            Console.Write("Enter your login name: ");
            string login = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (login == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login successful ✅");
                isAuthenticated = true;
                break;
            }
            else
            {
                Console.WriteLine("Incorrect username or password ❌");
                attempts++;
            }
        }

        if (!isAuthenticated)
        {
            Console.WriteLine("Too many failed attempts. You are rejected 🚫");
        }
    }
}
