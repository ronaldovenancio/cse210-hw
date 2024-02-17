using System;

public class Dictionary
{
    // Attributes of the class
    private List<string> _dictionary = new List<string>();
   
    // Constructors of the class
    public List<string> GetList(string fileName)
    {
        LoadWords(fileName);
        return _dictionary;
    }
    public void AddWord(string word)
    {
        _dictionary.Add(word);
    }
    // Methods of the class

    public void LoadWords(string fileName)
    {
        // Get file with words
        // string fileName = "words2.txt"; This is a file with more words than the file words.txt
        // Read file into dictionary
        string[] readText = File.ReadAllLines(fileName);

        // this is a loop though text file for words
        foreach (string line in readText)
        {
            string entries = line;
            AddWord(entries);
        }
        // This is a test to see if words loaded into word dictionary list
        // _dictionary.ForEach(Console.WriteLine);

    }
}