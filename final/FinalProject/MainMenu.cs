using System;

public class MainMenu : Menu
{
    // Attributes of the class
    private new string _menu = $@"
             Main Menu Options
===========================================
Please select one of the following options:
1. Play Game
2. How to Play
3. Quit
===========================================
Select an option from the menu:  ";

    private string _welcome = @"
===========================================
===                                     ===
===          Welcome to Hangman         ===
===                                     ===
===========================================";
    private string _goodbye = @"
===========================================
===                                     ===
===    Thank you for playing Hangman!   ===
===                                     ===
===========================================";

    // Constructors of the class

    // Methods of the class
    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        // This part call the GameMenu
        Menu gameMenu = new GameMenu();
        // Print welcome message
        PrintWelcome();

        while (_action != 3)
        // This is a switch case for main menu
        {
            // Ask for user input (1-6)
            _action = UserChoice();
            switch (_action)
            {
                case 1:
                    // Play Game - Untimed (not timed)
                    Console.Clear();  // This part will clear the console
                    gameMenu.MenuChoice();
                    break;
                
                case 2:
                    // How to Play
                    HowToPlay info = new HowToPlay();
                    info.GetInstructions();
                    break;
                case 3:
                    // Quite of the program
                    PrintGoodbye();
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
    private void PrintWelcome()
    {
        Console.Clear();  // This part will clear the console
        Console.Write($"{_welcome}\n\n");
    }
    private void PrintGoodbye()
    {
        Console.Clear();  // This part will clear the console
        Console.Write($"{_goodbye}\n\n");
    }
}