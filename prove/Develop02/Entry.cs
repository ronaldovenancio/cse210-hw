public class Entry
 {
    // This part of the program, by convention in C#, is to start member variables with an underscore _
    public string _entryNumber = "";
    public string _dateTime = "";
    public string _journalPrompt = "";
    public string _journalEntry = "";
    public string _journalFile = "";

    // This part use a method that displays 
    public void Display()
    {
        Console.WriteLine($"\n#: {_entryNumber}");
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_journalPrompt}");
        Console.WriteLine($"Entry: {_journalEntry}");
    }

}