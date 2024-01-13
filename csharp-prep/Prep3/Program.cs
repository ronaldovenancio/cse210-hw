using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        
        Console.WriteLine("Guess a number betweeen 1 to 100");
        Random randomGenerator = new Random();
       // int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;
        string firstAnswer = "yes";
        while (firstAnswer == "yes")
        {
            int magicNumber = randomGenerator.Next(1, 101);
            while (guess != magicNumber)
             {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                  Console.WriteLine("Higher");
                }
                 else if (magicNumber < guess)
                 {
                      Console.WriteLine("Lower");
                 }
                 else
                 {
                     Console.WriteLine("You guessed it!");
                }
            }  
            Console.Write("Do you want to play again (yes) or (not)? ");
            firstAnswer = Console.ReadLine();
        } 
    }
}