using System;
using System.IO;

// I tried to save and load the file in JSON.
// https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to

class Program
{

    static void Main(string[] args)
    {
        int[] _possibleNumbers = { 1, 2, 3, 4, 5 };
        int _action = 0;
        Console.Write("\n====== Welcome to the Journal Program! ======\n");
        // Create new journal reference/list
        Journal journal = new Journal();
        PromptGenerator myPromptGenerator = new PromptGenerator();

        //This part is to execute the program while action is not iqual to 5
        while (_action != 5)
        {
            // Ask for user input (1-5)
            //Call Choices
            _action = Choices();

            switch (_action)
            {
                case 1:
                    // Write Journal Entry
                    string entryId = GetEntryId();
                    string dateInfo = GetDateTime();
                    string prompt = myPromptGenerator.GetPrompt();

                    Entry entry = new Entry();
                    entry._entryNumber = entryId;
                    entry._dateTime = dateInfo;
                    entry._journalPrompt = prompt;

                    Console.Write($"{prompt}\n");
                    Console.Write(">> ");
                    string userEntry = Console.ReadLine();
                    entry._journalEntry = userEntry;
                    journal._journal.Add(entry);

                    // Console.WriteLine("Success Choice 1!");
                    break;
                case 2:
                    // This part is to display Journal Entries
                    journal.Display();
                    // Console.WriteLine("Success Choice 2!");
                    break;
                case 3:
                    // This part is to load text file of the program
                    journal.LoadJournalFile();
                    // Console.WriteLine("Success Choice 3!");
                    break;
                case 4:
                    // This part is to save to text file
                    journal.CreateJournalFile();
                    // Console.WriteLine("Success Choice 4!");
                    break;
                case 5:
                    // This part is to quite of the program
                    Console.WriteLine("\nThank you for using the Journal App!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }

    static int Choices()
    // This is a method to display choices to users
    {
        string choices = @"
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ";

        Console.Write(choices);
        string userInput = Console.ReadLine();
        int _action = 0;
        // This part catches any non integer values that are entered
        try
        {
            _action = int.Parse(userInput); // this convert string to integer
        }
        catch (FormatException)
        {
            _action = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _action;
    }

    static string GetDateTime()
    // This is a method to get the date and time for journal record
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        return currentDateTime;
    }
    static void AddJournalEntry()
    // This is a Method to add entry to text file
    {
        string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, "");
    }

    static string GetEntryId()
    {
        Guid entryuuid = Guid.NewGuid();
        string entryuuidAsString = entryuuid.ToString();

        return entryuuidAsString;
    }


}