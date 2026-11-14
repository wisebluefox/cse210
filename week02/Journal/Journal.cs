using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();

            // Add space between journal entries
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
        }

        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
        }
    }

    
    public void SaveToFile(string filename)
    {
        /* 
        Opens the file for writing. 
        If the file doesn't exist then it will create one
        But if it does then it replaces the contents
        */
        using (StreamWriter outputFile = new StreamWriter(filename))
        // StreamWriter is like a pencil that writes the info into a text file
        // Purpose of using opens the file -> writes info -> closes the files automatically when finished
        {
            foreach (Entry entry in _entries)
            {
                // Replace paragraph breaks with a special marker
                string savedResponse = entry._response
                    .Replace(Environment.NewLine, "[NEWLINE]");
                    /*Environment.NewLine detect line break format of the computer
                    for example Windows does \r\n Linux \n macOS \n and this automatically deals with it
                    .Replace() replaces the line break with a [NEWLINE] before saving
                    */
                outputFile.WriteLine( 
                    // Writes info into text file
                    $"{entry._date}~|~{entry._category}~|~{entry._prompt}~|~{savedResponse}"
                );
            }
        }

        Console.WriteLine("Journal saved!");
    }


   public void LoadFromFile(string filename)
   /*LoadFromFile does the opposite of saving 
    save: journal -> text file
    load: text file -> journal
    */
    {
        string[] lines = File.ReadAllLines(filename);
        // reads all lines in text file and stores inside string array
        _entries.Clear();
        //empties current list before loading and prevents duplicate entries
        foreach (string line in lines)
         //visits every line in the file
        {
            string[] parts = line.Split( 
                // Separates the info when ~|~ shows up
                new string[] {"~|~"},
                StringSplitOptions.None
            );

            if (parts.Length == 4)
             //each entry contains 4 parts
            {
                Entry entry = new Entry(
                    parts[0], 
                    //Date
                    parts[2],
                     //Question
                    parts[3].Replace("[NEWLINE]", Environment.NewLine), 
                    //Answer added newline so i can have paragraphs load back up when loaded
                    parts[1] 
                     //Category
                );

                _entries.Add(entry); 
                //puts the reconstructed entry into the list
            }
        }

        Console.WriteLine("Journal loaded!");
    }
}
/* 
Notes:
This class has for jobs
1) Collect entries
2)Display entries
3) Save entries
4) Load entries

public              Other classes can access it
void                Doesn't return information
AddEntry            Name of the method
(Entry entry)       Receives one Entry object
_entries.Add(entry) Puts that object into the list

Visual Example for add entry:
You have a note card called new entry
The note is given to Journal
Journal puts it inside _entries

---------------------------------------------------
foreach what it does:
I added some entries so it goes like this

1) _entries -> [Entry 1] [Entry 2] [Entry 3]
the code foreach (Entry entry in _entries)
it does this:
Take Entry 1 -> call Display()
Take Entry 3 -> call Display()
Take Entry 3 -> call Display()
It stops once there are no entries

so -> if (_entries.Count == 0) 
_entries = list
.Count = how many objects are inside
== equal to
0 = nothing inside

so it checks if the journal is empty

--------------------------------------------------
SaveToFile() -> journal writes info into journal.txt
*/