using System;

public abstract class ScoringRules
{
    // Attributes of the class

    // Constructors of the class

    // Methods of the class
    public abstract int CalculateScore(int numGuesses, List<string> letters, string word);

    public abstract void ShowScore();

}