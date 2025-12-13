public class Swimming : Activity
{
    private int _lapCount;
    public Swimming(int lapCount, string activity, string date, int lengthMinutes) : base(activity, date, lengthMinutes)
    {
        _lapCount = lapCount;
    }
    public override double GetDistance()
    {
        double meters = _lapCount * 50;
        return meters / 1609.34;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetLengthMinutes()) * 60;
    }
    public override double GetPace()
    {
        return GetLengthMinutes() / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():0.00} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}