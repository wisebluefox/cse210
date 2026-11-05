using System; //provides access to C# tools
using System.Globalization; //Gives is text/culture tools, such as TextInfo for changing capitalization

class Program //Creates a class called program
{
    static void Main(string[] args) //Main is where the program starts running
    {
        Console.Write("What is your first name? "); //Displays the text and waits for the user to type an input
        string firstName = Console.ReadLine(); //Stores the input as a string

        Console.Write("What is your last name? "); //Display text and waits for user input
        string lastName = Console.ReadLine(); //Stores the input as a string

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo; //Creates a TextInfo tool that can change how the text is capitalized
        firstName = textInfo.ToTitleCase(firstName.ToLower()); //Changes the first name to lowercase then capitalizes the first letter
        lastName = textInfo.ToTitleCase(lastName.ToLower());  //Changes the last name to lowercase the capitalizes the first letter

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}."); //Prints the final result using the inputs stored in the variables
    }
}