using System;

public class ScoreComplex : ScoringRules
{
    // Attributes of the class
    private int _score;
    private int _len;

    // Constructors of the class

    // Methods of the class
    public override int CalculateScore(int numGuesses, List<string> letters, string word)
    {
        _len = word.Length;
        if (_len <= 7)
        {
            _score = numGuesses * 2;
        }
        else if( _len > 7 & _len <= 9)
        {
            _score = numGuesses * 3;
        }
        else {
            _score = numGuesses * 4;
        }
        return _score;
    }
    public override void ShowScore()
    {
        Console.WriteLine($"Your complex word score: {_score} ");
    }
}