using System;
 
public class Reference
{
    // This part of the program list the variables
    public List<Reference> _reference = new List<Reference>();
    private string _fileName = "DataText.txt";
    private string _key;
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // This part of the program shows the methods
    public void LoadReference()
    {
        List<string> readText = File.ReadAllLines(_fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

        foreach (string line in readText)
        {
            string[] entries = line.Split(";");

            Reference entry = new Reference();

            entry._key = entries[0];
            entry._book = entries[1];
            entry._chapter = int.Parse(entries[2]);
            entry._verse = int.Parse(entries[3]);
            entry._endVerse = int.Parse(entries[4]);

            _reference.Add(entry);
        }
    }

    public void ReferenceDisplay()
    {
        foreach (Reference item in _reference)
        {
            // var test = item._endVerse.Equals(0);
            // Console.WriteLine(test);
            if (item._endVerse.Equals(0))
            {
                item.ReferenceOne();
            }
            else
            {
                item.ReferenceTwo();
            }
        }
    }
    public string GetReference(Scripture scripture)
    {
        var index = scripture._index;

        var refi = _reference[index];
        string ref1;
        if (refi._endVerse.Equals(0))
        {
            return ref1 = ($"\n{refi._book} {refi._chapter}:{refi._verse}");
            
        }
        else
        {
            return ref1 = $"\n{refi._book} {refi._chapter}:{refi._verse}-{refi._endVerse}";
        }
    }


    public void ReferenceOne()
    {
        Console.WriteLine($"\n{_book} {_chapter}:{_verse}");
    }
    public void ReferenceTwo()
    {
        Console.WriteLine($"\n{_book} {_chapter}:{_verse}-{_endVerse}");
    }
}