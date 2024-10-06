using System;
using System.Collections.Generic;


    static void Main(string[] args)
    {
        AddPrompt newPrompt = new AddPrompt();
        TerminalServices menu = new TerminalServices();
        Journal journal = new Journal();
        File newFile = new File();

        Console.WriteLine("Welcome to the Journal Program!");
        int prompt;

        do{
            menu.Displaymenu();

            if (prompt == 1)
            {
                newPrompt.AddNewPrompt();
                string addPrompt = newPrompt._prompt;
                menu._questionPrompts.Add(addPrompt);
            }
            else if (prompt == 2)
            {
                Entry entry = new Entry();
                menu.DisplayRandomQuestions();

                if (menu._promptsRemaining)
                {
                    string answer = Console.ReadLine();
                    string question = menu._question;

                    entry.SetEntry(answer, question);
                    journal._journal.Add(entry);
                }

            }
            else if (prompt == 3)
            {
                journal.DisplayJournal();
            }
            else if (prompt == 4)
            {
                string file = newFile._fileName;
                List<Entry> savedEntries =  newFile.ReadFile();
                foreach (Entry entry in savedEntries)
                {
                    journal._journal.Add(entry);
                }
            }
            else if (prompt ==5)
            {
                newFile.WriteFile(journal._journal);
                string file = newFile._fileName;
            }
            else
            {
                Console.WriteLine("Okay, See you next time!")
            }
        }
        while (prompt < 6);//loops until user quits
    }
}