using System;
using System.Collections.Generic;
//Gives access to List<T>
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        //Creates a List that can store whole numbers (int)
        //numbers is the name of the list
        int userNumber = -1;
        //Creates an integer variable called userNumber
        //Starts at -1 so that the while loop can begin
        while (userNumber != 0)
        //Keeps repeating while userNumber is NOT 0
        //0 will be used as a signal to stop entering numbers
        {
            Console.Write("Enter a number (Enter 0 to quit): ");
            //asks the user for number
            string userResponse = Console.ReadLine();
            //gets user input
            userNumber = int.Parse(userResponse);
            //converts text to an integer and stores in userNumber
            if (userNumber != 0)
            //checks if the user entered something other then 0
            {
                numbers.Add(userNumber);
                //Adds the number to the List
                //The 0 is not added because 0 means quit
            }
        }
        int sum = 0;
        //creates a variable called sum 
        foreach (int number in numbers)
        //Goes through EVERY number in the numbers list
        {
            sum += number;
            //adds current number to sum -> sum = sum + number
        }
        Console.WriteLine($"The sum is: {sum}");
        //displays the total of all the numbers
        float average = ((float)sum) / numbers.Count;
        //calculates average, (float) converts sum to decimal
        //numbers.Count -> how many numbers are in the list
        //Average = (sum / number of items)
        Console.WriteLine($"The average is: {average}");
        //displays average
        int max = numbers[0];
        //starts max as the FIRST number in the List
        //[0] means the first item in a List
        foreach (int number in numbers)
        //Goes through every number in the List again
        {
            if (number > max)
            //Checks if the current number is greater than max
            {
                max = number;
                //If the current number is bigger make it the max number
            }
        }
        Console.WriteLine($"The max is: {max}");
        //Displays the largest number in the list
    }
}