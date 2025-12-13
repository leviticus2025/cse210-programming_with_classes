public class Outdoor : Event
{
    private string _weatherForecast;
    public Outdoor(string weatherForecast, string eventType, string title, string description, string date, string time, string address) : base(eventType, title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }
    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nWeather Statement: {_weatherForecast}";
    }
}