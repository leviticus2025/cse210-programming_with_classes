public class Video
{
    private string _name;
    private string _title;
    private int _lengthSeconds;
    private List<Comment> _comments;
    public Video(string title, string name, int lengthSeconds)
    {
        _title = title;
        _name = name;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comment>();
    }
    public void AddComment(Comment c)
    {
        _comments.Add(c);
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
    public string GetVideoInfo()
    {
        return $"{_title} by {_name} - {_lengthSeconds} seconds - {_comments.Count} comments";
    }
}