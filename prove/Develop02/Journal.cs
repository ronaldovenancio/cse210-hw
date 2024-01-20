using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Journal
{
    /* public List<Entry> _journal;

    public void AddEntry(Entry newEntry)
    {
    
    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {
        
    }
 */
    public Journal()
    {
        
    }

    // variables
    public List<Entry> _journal = new List<Entry>();
    // private string fileName = "MyJournal.txt";
    private string _userFileName;

    // A method that displays each journal entry
    public void Display()
    {
        Console.WriteLine("\n==================== Journal Entries ====================");
        foreach (Entry journalEntry in _journal)
        {
            journalEntry.Display();
        }
        Console.WriteLine("\n==================== End of the Program ====================");
    }

    public void CreateJournalFile()
    // Method to check if txt file is created if not create one
    {
        Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (!File.Exists(_userFileName))
        {
            File.CreateText(_userFileName);
            Console.Write($"\n*** {_userFileName} has been created! ***\n");
            Console.Write("***  Your journal entries have been saved. ***\n");
            SaveJournalFile(_userFileName);
            CreateJSON(userInput);
        }
        else
        {
            Console.Write($"\n*** {_userFileName} already exits. ***\n");
            Console.Write("***  Your journal entries have been added. ***\n");
            AppendJournalFile(_userFileName);
        }
    }
    public void SaveJournalFile(string _userFileName)
    // Method to save journal to txt file 
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (Entry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._entryNumber}; {journalEntry._dateTime}; {journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }

    public void AppendJournalFile(string _userFileName)
    // Method to save a new entry to journal txt file 
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append: true))
        {
            foreach (Entry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._entryNumber}; {journalEntry._dateTime}; {journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }

    public void LoadJournalFile()
    // Method to check if txt file is created and load it into the list.  
    // This should replace any current info in the list
    {
        Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (File.Exists(_userFileName))
        {
            List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                Entry entry = new Entry();

                entry._entryNumber = entries[0];
                entry._dateTime = entries[1];
                entry._journalPrompt = entries[2];
                entry._journalEntry = entries[3];

                _journal.Add(entry);
            }
        }
    }


    public void CreateJSON(string userInput)
    // This part is a method to create a JSON file 
    // https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to
    {
        string fileName = userInput + ".json";
        List<JsonItem> _data = new List<JsonItem>();

        foreach (Entry journalEntry in _journal)
        {
            _data.Add(new JsonItem()
            {
                ID = journalEntry._entryNumber,
                Date = journalEntry._dateTime,
                Prompt = journalEntry._journalPrompt,
                Entry = journalEntry._journalEntry
            });
        }

        string json = JsonSerializer.Serialize(_data);
        File.WriteAllText(fileName, json);
    }
}