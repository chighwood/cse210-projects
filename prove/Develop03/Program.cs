using System;

public class Program
{
    static void Main(string[] args)
    {

        List<Scripture> scriptures = new List<Scripture>
                {
                    new Scripture(new Reference("John", 3, 16), CreateWords("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.")),
                    new Scripture(new Reference("Matthew", 5, 16), CreateWords("Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.")),
                };

        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();

            Console.WriteLine("Original Scripture:");
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();

            int wordsToHide = random.Next(1, selectedScripture.GetWordCount() + 1);
            selectedScripture.HideRandomWords(wordsToHide);

            Console.WriteLine($"Scripture with {wordsToHide} Random Words Hidden:");
            Console.WriteLine(selectedScripture.GetDisplayText());

            Console.WriteLine($"All words hidden: {selectedScripture.IsCompletlyHidden()}");

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
        List<Word> CreateWords(string text)
        {
            string[] words = text.Split(' ');
            List<Word> wordList = new List<Word>();

            foreach (string word in words)
            {
                wordList.Add(new Word(word));
            }

            return wordList;
        }
    }   

}
