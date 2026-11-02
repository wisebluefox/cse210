using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        string userInput = Console.ReadLine();

        int x = int.Parse(userInput);

        if (x > 90)
        {
            Console.WriteLine("Your grade is an A! ");
        }
       
        else if (x < 90 && x > 80)
        {
            Console.WriteLine("Your grade is a B! ");
        }
          else if (x < 80 && x > 70)
        {
            Console.WriteLine("Your grade is a C! ");
        }
          else if (x < 70 && x > 60)
        {
            Console.WriteLine("Your grade is a D! ");
        }
        
        else 
        {
            Console.WriteLine("Your grade is an F!!!! ");
        }

        if (x > 70)
        {
            Console.WriteLine("Congrats you are passing the class!!!  ");
        }
        
        else if (x < 70)
        {
            Console.WriteLine("Work harder!!! You are currently failing. ");
        }
    }
}