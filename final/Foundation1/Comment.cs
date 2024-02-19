public class Comment
{
    private string _commenterName;
    private string _words;
    public Comment(string commenterName, string words)
    {
        this._commenterName = commenterName;
        this._words = words;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }
    public string GetWords()
    {
        return _words;
    }
}
