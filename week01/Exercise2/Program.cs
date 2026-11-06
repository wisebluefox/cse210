using System; 
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        //Displays "Enter number:" and waits for user to type input
        string userInput = Console.ReadLine();
        //Gets what the user types and stores it as a string (text)
        int x = int.Parse(userInput);
        //Converts the user's text into an integer (whole number)
        //Stores the number in a variable called x
        string letter;
        //Creates a string variable called letter
        //Used to store the grade (A, B, C, D, or F)
        if (x >= 90)
        //Checks if x is greater than 90
        {
            letter = "A";
        }
       
        else if (x >= 80)
        //if the first condition was false, checks this condition
        //Checks if x is between 80-90
        {
            letter = "B";
        }
          else if (x >= 70)
        //Checks if x is between 70-80
        {
            letter = "C";
        }
          else if (x >=60)
        //Checks if x is between 60-70
        {
            letter = "D";
        }
        
        else 
        //If none of the previous conditions are true then this is the result
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is a {letter}");
        //Prints the grade stored in the letter variable
        //$ allows the variable to be put inside text using { }

        if (x >= 70)
        //check if the number is 70+
        {
            Console.WriteLine("Congrats you are passing the class!!!");
            //If 70+ this prints
        }
        
        else
        {
            Console.WriteLine("Work harder!!! You are currently failing.");
            //If 70- this prints
        }
    }
}