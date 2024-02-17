using System;

public class ScoreSimple : ScoringRules
{
    // Attributes of the class
    private int _score;


    // Constructors of the class


    // Methods of the class
    public override int CalculateScore(int numGuesses, List<string> letters, string word)
    {
        _score = numGuesses;
        return _score;
    }
    public override void ShowScore()
    {
        Console.WriteLine($"Your simple word score: {_score} ");
    }

}