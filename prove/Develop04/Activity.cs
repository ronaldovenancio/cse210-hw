using System;

public class Activity
{
    // Attributes
    private string _name;
    private int _duration;
    private string _description = "You may begin in...";

    // Constructors
    public Activity(string name, int duration)
    {
        _name = name;
        _duration = duration;
    }
    public void GetActivityName()
    {
        Console.WriteLine($"Welcome to the {_name} Activity\n");
    }
    public void SetActivityName(string name)
    {
        _name = name;
    }
    public int GetActivityTime()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _duration = userSeconds;
        return userSeconds;
    }
    public void SetActivityTime(int duration)
    {
        _duration = duration;
    }

    // Methods
    public void GetReady()
    {
        Console.Clear();
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerReady();
    }

    public void GetDone()
    {
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerDone();
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity!");
        spinner.ShowSpinner();
    }
     public void CountDown(int time)
    {
        Console.WriteLine();  //insert blank line to start
        for (int i = time; i > 0; i--)
        {
            Console.Write($"{_description}{i}");
            Thread.Sleep(1000);
            string blank = new string('\b', (_description.Length + 5));  // Overwrite line
            Console.Write(blank);
        }
        Console.WriteLine($"Go:                                  ");  // last prompt
    }


}