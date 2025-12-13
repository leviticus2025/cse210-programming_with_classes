public class Reception : Event
{
    private string _rsvp;
    public Reception(string rsvp, string eventType, string title, string description, string date, string time, string address) : base(eventType, title, description, date, time, address)
    {
        _rsvp = rsvp;
    }
    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP Email: {_rsvp}";
    }
}