using System;

public class Reference
{
    public string _book;
    public int _chapter;
    public int _startVerse;
    public int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = verse;
        this._endVerse = verse; 
    }

    public Reference(string book,int chapter, int startVerse, int endVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = startVerse;
        this._endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        if (this._startVerse == this._endVerse)
        { 
            return $"{this._book} {this._chapter}:{this._startVerse}";
        }
        else
        {
            return $"{this._book} {this._chapter}:{this._startVerse}-{this._endVerse}";
        }
    }
}