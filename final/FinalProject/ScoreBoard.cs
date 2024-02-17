using System;

public class ScoreBoard
{
    // Attribute of the class
    private ScoringRules scoringRules;

    // Constructors of the class
    public ScoreBoard(ScoringRules scoringRules)
    {
        this.scoringRules = scoringRules;
    }

    // Methods of the class
    public void DisplayScore(int numGuesses, List<string> letters, string word)
    {
        int score = scoringRules.CalculateScore(numGuesses, letters, word);
        // Console.WriteLine($"Your Score: {score}");
        scoringRules.ShowScore();

    }
}