// This is the Storage Box of the project. It holds one journal entry: date, question, answer, category
using System;

public class Entry 
// created Entry class (the class is the blueprint for making objects)
// Public means that other classes can use the info
{
    public string _date; 
    // The _ means that is belongs to a class. string stores it as TEXT
    public string _prompt;
    public string _response;
    public string _category;

// Gets 4 pieces of info from Program. Runs automatically each time a new entry is created. 
    public Entry(string date, string prompt, string response, string category)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _category = category;
    }

// This shows the information that is stored inside one entry object
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
         // Writeline displays the info 
        Console.WriteLine($"Category: {_category}");
        Console.WriteLine($"Question: {_prompt}");
        Console.WriteLine($"Answer: {_response}");
    }
}

/* Notes:
date            Incoming info
_date           Information stored in the object
public string   Text that can be accessed by the other classes
new Entry()     Create a new Entry object
void Display()  A method that performs an action
*/
