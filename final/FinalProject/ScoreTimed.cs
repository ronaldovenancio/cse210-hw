using System;
using System.Threading;

public class ScoreTimed : ScoringRules
{
    // Attributes of the class
    private int _score;

    // Constructors of the class

    // Methods of the class
    public override int CalculateScore(int numGuesses, List<string> letters, string word)
    {
        int _totalScore = 0;
        // int numGuesses = 0;
        // Stopwatch timer = new Stopwatch();
        // timer.Start();

        // while (timer.Elapsed < TimeSpan.FromMinutes(2) && words.Count > 0)
        // {
        //     Console.Write("Enter your guess: ");
        //     string guess = Console.ReadLine();

        //     if (words.Contains(guess))
        //     {
        //         int score = scoringRules.CalculateScore(numGuesses, guess);
        //         totalScore += score;
        //         numGuesses++;

        //         Console.WriteLine($"Correct! You scored {score} points.");
        //         words.Remove(guess);
        //     }
        //     else
        //     {
        //         Console.WriteLine("Incorrect! Try again.");
        //     }
        // }

        // timer.Stop();
        // Console.WriteLine($"Time's up! You guessed {numGuesses} words and scored {totalScore} points.");
        return _totalScore;
    }
    public override void ShowScore()
    {
        Console.WriteLine($"Your simple word score: {_score} ");
    }


}