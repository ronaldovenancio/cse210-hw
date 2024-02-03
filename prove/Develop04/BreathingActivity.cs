using System;

public class BreathingActivity : Activity
{
    // This part of the program shows the attributes. Here, everything was defined private
    private string _message1 = "Breathe in...";
    private string _message2 = "Breathe out...";
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

  
    // This part of the program shows the methods
    public BreathingActivity(string name, int duration) : base(name, duration)
    {

    }
    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

    public void Breathing(int seconds)
    {
        Console.WriteLine();  //insert blank line to start
        int secondsTimer = 0;
        while (secondsTimer < seconds)
        {
            Console.WriteLine();  //insert blank line to start
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"{_message1}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_message1.Length + 2));  // Overwrite line
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_message1}  ");  // last prompt
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{_message2}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_message2.Length + 2));  // Overwrite line
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_message2}  ");  // last prompt
        }
    }
}