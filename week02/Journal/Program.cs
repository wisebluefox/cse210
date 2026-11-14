using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(); 
        //create the journal object
        PromptGenerator promptGenerator = new PromptGenerator();
         //create PromptGenerator object

        string filename = "journal.txt"; 
        //name of file where entries are saved

        // LOAD EXISTING JOURNAL
        if (File.Exists(filename))
         //checks if journal.txt exists
        {
            journal.LoadFromFile(filename); 
            //if exists loads file
        }

        bool running = true;
         //creates true false variable. If true program stays on if false then program stops

        // MAIN MENU
        while (running) 
        //while the program running shows the menu and options
        {
            Console.WriteLine("\n𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂");
            Console.WriteLine("    MY LIFE JOURNAL");
            Console.WriteLine("𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂");
            Console.WriteLine("1. Add New Entry");
            Console.WriteLine("2. View Entries");
            Console.WriteLine("3. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            /*
            COnsole.ReadLine() waits for the person to type, string make it text, choice is the name of the variable
            */

            // OPTION 1: ADD NEW ENTRY
            if (choice == "1")
            {
                // asks PromptGenerator for a question at random
                string randomPrompt = promptGenerator.GetRandomPrompt();

                // Separate category and question
                string[] parts = randomPrompt.Split(
                    new string[] { "~|~" },
                    StringSplitOptions.None
                );

                string category = parts[0];
                string question = parts[1];

                Console.WriteLine($"\nCategory: {category}");
                Console.WriteLine($"Question: {question}");
                Console.WriteLine("Your response (type END on new line to save):");
                string response = "";
                string line;

                while ((line = Console.ReadLine()) != "END")
                {
                    response += line + Environment.NewLine;
                }

                // Get today's date
                string date = DateTime.Now.ToString("yyyy-MM-dd");

                // Create a new entry
                Entry newEntry = new Entry(
                    date,
                    question,
                    response,
                    category
                );

                // Add entry to journal
                journal.AddEntry(newEntry);

                // Automatically save everything
                journal.SaveToFile(filename);

                Console.WriteLine("Your entry has been saved!");
            }

            // OPTION 2: VIEW ENTRIES
            else if (choice == "2")
            {
                Console.WriteLine("\n𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂 YOUR LIFE STORY 𐦂𐦂𐦂𐦂𐦂𐦂𐦂𐦂");

                journal.DisplayAll();
            }

            // OPTION 3: QUIT
            else if (choice == "3")
            {
                running = false;

                Console.WriteLine("Goodbye!");
            }

            // INVALID OPTION
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}
