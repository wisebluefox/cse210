using System;
using System.Globalization; //Text info to make the first letter of the names capital

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        firstname = textInfo.ToTitleCase(firstname.ToLower());
        lastname = textInfo.ToTitleCase(lastname.ToLower());

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");
    }
}