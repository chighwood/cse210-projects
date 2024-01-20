using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void RandomPrompt()
    {
        string randomPrompt = Prompt.GetRandomPrompt();

        Console.WriteLine("Random Prompt: " + randomPrompt);

        Console.Write("Your Response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry
        {
            _date = DateTime.Now.ToString(),
            _promptText = randomPrompt,
            _entryText = response 
        };

        _entries.Add(entry);

        Console.WriteLine("Entry saved to journal.\n");
    }

    public void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveJournal()
    {
        Console.Write("Enter filename to save journal: ");
        string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }

            Console.WriteLine("Journal saved to file.\n");
        
      
    }
    public void LoadJournal()
    {
        Console.Write("What filename do you want to load: ");
        string filename = Console.ReadLine();

         List<Entry> loadedEntries = new List<Entry>();

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime date))
                    {
                        Entry entry = new Entry
                        {
                            _date = parts[0],
                            _promptText = parts[1],
                            _entryText = parts[2]
                        };

                        loadedEntries.Add(entry);
                    }
                }
            }

            _entries = loadedEntries;
            Console.WriteLine("Journal loaded from file.\n");
        
    }
}