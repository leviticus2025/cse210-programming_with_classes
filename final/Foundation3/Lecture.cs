public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string speaker, int capacity, string eventType, string title, string description, string date, string time, string address) : base(eventType, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}