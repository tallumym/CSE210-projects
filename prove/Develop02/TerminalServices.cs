using System;
using System.Collections.Generic;

public class TerminalServices{
    public int _userResponse;
    public string _question;
     public List<string> _menu = new List<string>() {"Add Prompt", "Write", "Display", "Load", "Save", "Quit"};
    public List<string> _questionPrompts = new List<string>() {
        "What was the best part of my day?",
        "If I could do one thing differently from today, what would I do?",
        "What was the favorite part of my day?",
        "What was the strongest emotion I felt today?"
    };

    public bool _promptsRemaining = true;

    public void DisplayRandomQuestions()
    {
        Random genRand = new Random();

        if (_questionPrompts.Count != 0)
        {

           int promptIndex = genRand.Next(_questionPrompts.Count);
            _question = _questionPrompts[promptIndex];
            Console.WriteLine(_question);

             _questionPrompts.RemoveAt(promptIndex); 
        }
        else
        {
            Console.WriteLine("No more prompts for today. Check back later!");
            _promptsRemaining = false;
        }
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        for (int i = 0; i < _menu.Count; i++)
        {
            // Display each menu option with its corresponding number
            Console.WriteLine($"{i + 1}. {_menu[i]}");
        }
        Console.Write("What would you like to do? ");
        _userResponse = int.Parse(Console.ReadLine()); // Capture user input for menu choice
    
    }
        

}