using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        //creates a string variable called playAgain. 
        //Starts it at "yes" so the game will begin.

        while (playAgain == "yes")
        //Keeps repeating the game as long as playAgain is equal to "yes"
        {
            Random randomGenerator = new Random();
            //Creates a Random object that can generate random numbers
            int magicNumber = randomGenerator.Next(1, 101);
            //Generates a random whole number from 1 to 100
            //1 = starting number and 101 is the stopping point
            int guess = -1;
            //creates a variable called guess. starts it at -1 because player hasn't guess yet
            int guessCount = 0;
            //creates variable that counts guesses. starts at zero because hasn't guessed yet

            while (guess != magicNumber)
            //keeps asking for guesses until correct number is found != means does not equal
            {
                Console.Write("What is your guess? ");
                //asks for input
                guess = int.Parse(Console.ReadLine());
                //gets players input

                guessCount++;
                //adds 1 to guessCount
                //same as guessCount = guessCount + 1

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher!");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower!");
                }
                else
                //If neither condition is true, the numbers must be equal
                {
                    Console.WriteLine("You guessed it!!! Congrats!!!");
                    //Tells the player they got the correct number
                }
            }
        
        Console.WriteLine($"You made {guessCount} guesses. ");

        Console.Write("Would you like to play again? ");
        playAgain = Console.ReadLine();
        }
    }
}