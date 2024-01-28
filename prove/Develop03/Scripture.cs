using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public int GetWordCount()
    {
    return _words.Count;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide && i < _words.Count; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";
        foreach (Word w in _words) {
            displayText += w.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletlyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}