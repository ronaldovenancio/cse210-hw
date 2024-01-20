using System.ComponentModel;
using System;

public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        return "";
    }
    
    // The most of questions on the internet https://www.latinhire.com/40-questions-for-an-english-conversation-class/

    public static string[] _prompt = {
        "Who was the most interesting person I interacted with today?",
         "What was the best part of my day?",
         "How did I see the hand of the Lord in my life today?",
         "What was the strongest emotion I felt today?",
         "How do you feel today?",
         "If I had one thing I could do over today, what would it be?",
         "What places have you been to today?",
         "What was the best idea you had today?",
         "What was the most outrageous thing you did today?",
         "What was the best meal of the day today and what was it?",
         "Who made you feel good today?",
         "What did you learn today?",
         "What is the funniest thing that happened today?",
         "If you could become an expert in any subject or activity, what would it be?",
         "What would you buy today if money were no object?",
         "How did you procrastinate on important tasks today?",
         "What scripture just popped into your head right now?",
         "What is something that made you laugh today?",
         "Who made your day better today?",
         "What is one thing you want to remember from today?",
         "What steps did you take today towards a goal you’re working on?",
         "How can you make tomorrow (even) better than today?",
         "What went well today?",
         "What’s a simple pleasure in your life that you are thankful for?",
         "How did you show love to someone today?",
         "How would you describe your spirituality today?",
         "What was your magic power today?",
         "Identify three times that you felt challenged today.",
         "What do I need to let go of today?",
         "What do you need the most right now?",
         "If you could only accomplish three things tomorrow, what would they be?",
         "What was the most peaceful moment during the day?",
         "Would you change any of the decisions you made today?",
         "What frightened you today?",
         "Who do you wish you had talked to today? What would you say?",
         "If you’d had another hour during the day, how would you have spent it?",
         "Did you read a book today? If so what?",
         "Did you watch a movie today? If so what?",
         "Did you watch a TV show today? If so what?",
         "What makes you feel the happiest?",    
         "How would your friends and family describe you? Do you agree? Why or why not?",
         "What is the best advice you have ever received?", 
         "What is an unusual habit that you have or an unusual thing that you own?",
         "How have your goals changed as you’ve gotten older?",
         "Do you have any rare talents? What is your best talent/skill?",
         "Are you more of a spontaneous or structured person?",
         "Do you often remember your dreams? What was the last dream you had?",
         "What three websites or three apps do you use the most? Why?",
         "What are your morning and evening routines?"
    };
    public List<string> _journalPrompt = new List<string>(_prompt);

    public PromptGenerator()
    {

    }

    public void Display()
    {
        var _random = new Random();
        int _index = _random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[_index];
        Console.WriteLine($"\n{_journalPrompt}");
    }

    public string GetPrompt()
    {
        var _random = new Random();
        int _index = _random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[_index];
        
        return journalPrompt;
    }

}