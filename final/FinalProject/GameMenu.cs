using System;

public class GameMenu : Menu
{
    // Attributes of the class
    private new string _menu = $@"
                Game Options
===========================================
Your Game Options are:
1. Random Words
2. Pick your word topic
3. Back to Main Menu
===========================================
Which game would you like to play?  ";

    // Constructors of the class

    // Methods of the class
    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        // This call the ListMenu
        Menu listMenu = new ListMenu();

        while (_action != 3)
        // This is a switch case for goals menu
        {
            _action = UserChoice();
            switch (_action)
            {
                case 1:
                    // Random Words; start game
                    _wordFileName = "words2.txt";
                    Hangman game = new Hangman();
                    game.StartGame(_wordFileName);
                    break;
                case 2:
                    // Pick your word topic
                    Console.Clear();  // This part will clear the console
                    listMenu.MenuChoice();
                    break;
                case 3:
                    // In this part, back to Main Menu
                    Console.Clear();  // This part will clear the console
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
}