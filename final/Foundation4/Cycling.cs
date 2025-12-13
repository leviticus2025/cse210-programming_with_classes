public class Cycling : Activity
{
    private double _speed; // miles per hour
    public Cycling(double speed, string date, string activity, int lengthMinutes) : base(activity, date, lengthMinutes)
    {
        _speed = speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return (_speed * GetLengthMinutes()) / 60;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():0.00} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}
