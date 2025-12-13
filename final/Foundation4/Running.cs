public class Running : Activity
{
    private double _distance;
    public Running(double distance, string activity, string date, int lengthMinutes) : base(activity, date, lengthMinutes)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / GetLengthMinutes()) * 60;
    }
    public override double GetPace()
    {
        return GetLengthMinutes() / _distance;
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}