using System.Diagnostics;

public class Event
{
    private string _eventType;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    public Event(string eventType, string title, string description, string date, string time, string address)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetShortDescription()
    {
        return $"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date}";
    }
    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date} | Time: {_time}\nAddress: {_address}";
    }
}