public class Activity
{
    private string _activity;
    private string _date;
    private int _lengthMinutes;
    public Activity(string activity, string date, int lengthMinutes)
    {
        _activity = activity;
        _date = date;
        _lengthMinutes = lengthMinutes;
    }
    protected string GetActivity()
    {
        return _activity;
    }
    protected string GetDate()
    {
        return _date;
    }
    protected int GetLengthMinutes()
    {
        return _lengthMinutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return $"{_date} {_activity} ({_lengthMinutes} min)";
    }
}
