using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName= PromptUserName();
        int userNumber = PromptUserNumber();

        int squared = SquareNumber(userNumber);
        DisplayResult(userName, squared);
    }
   static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
        int squared = userNumber * userNumber;

        return squared;
    }
    static void DisplayResult(string userName, int squared)
    {
        Console.WriteLine($"{userName}, the square of your number is: {squared}");
    }
}