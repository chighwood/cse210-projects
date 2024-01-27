using System;

public class References
{
    public string _book;
    public int _chapter;
    public int _startVerse;
    public int _endVerse;

    public References(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = verse;
        this._endVerse = verse; 
    }
    public References(string book,int chapter, int startVerse, int endVerse)
    {
         this._book = book;
        this._chapter = chapter;
        this._startVerse = startVerse;
        this._endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (startVerse == endVerse)
        { 
            return $"{book} {chapter}:{startVerse}";
        }
        else
        {
            return $"{book} {chapter}:{startVerse}-{endVerse}";
        }
    }

}