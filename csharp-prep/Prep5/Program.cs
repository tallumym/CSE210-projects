using System;

class Program
{
    static void Main(string[] args)
    {
        int userNumber = -1;
        Console.WriteLine("Welcome to the program!");

        Console.WriteLine("What is your name? ");
        string first = Console.ReadLine();
        Console.WriteLine($"Your name is {first}");

        Console.Write("What is your favorite number? ");
        userNumber = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your favorite number is {userNumber}");

        int result = userNumber * userNumber;
        Console.WriteLine($"The square of your favorite number is {result}");

        Console.WriteLine($"Your name is {first}, your favorite number is {userNumber}, and your favorite number squared is {result} ");
    }
}