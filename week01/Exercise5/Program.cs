using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        string lastName = Console.ReadLine();
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo; 
        firstName = textInfo.ToTitleCase(firstName.ToLower());
        lastName = textInfo.ToTitleCase(lastName.ToLower()); 
        return firstName + " " + lastName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}