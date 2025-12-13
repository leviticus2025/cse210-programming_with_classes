using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    private List<Lecture> _lectures;
    private List<Reception> _receptions;
    private List<Outdoor> _outdoorEvents;
    public Program()
    {
        _lectures = new List<Lecture>();
        _receptions = new List<Reception>();
        _outdoorEvents = new List<Outdoor>();
    }
    public void Run()
    {
        Lecture lecture1 = new Lecture("Joseph Doewith", 200, "Lecture", "Whale Anatomy", "In-depth course of the anatomy of a whale, their systems and their life cycles.", "12/15/2025", "7:45AM", "11 Center St. - Lecture Hall #3");
        Lecture lecture2 = new Lecture("Annabelle Pennywise", 200, "Lecture", "Into the diseased mind of Serial Killers", "In-depth course of serial killers' diseased minds and what went wrong.", "1/11/2026", "10:15AM", "1095 University St. - Lecture Hall #11");

        Reception reception1 = new Reception("Email: elara.vance@inbox.net", "Reception", "Wedding for Sophia and Levi", "Come celebrate the recent wedding of Sophia and Levi at a reception in their honor!", "02/02/2027", "5:00PM", "455 Navajo Rd");
        Reception reception2 = new Reception("Email: marcus.jordan@emailcorp.io", "Reception", "Mission Reunion for the California Ventura Mission", "All missionaries that served under President and Sister Rodriguez are invited to come socialize with us!", "07/03/2026", "1:00PM", "8240 Misionero Blvd");

        Outdoor outdoor1 = new Outdoor("Weather Forecast: Cloudy, 89% chance of snow, 33°F", "Outdoor Event", "Color Fun Run", "Come grab your Color Fun Run T-Shirt and run down Center St from temple to temple!", "04/04/2026", "9:00AM", "750 S 2nd E");
        Outdoor outdoor2 = new Outdoor("Weather Forecast: Mostly Sunny, 4 MPH winds Southwest bound, 41°F", "Outdoor Event", "Winter Rodeo", "Love the rodeo? This event is for you! Come sit in our heated stadium and watch the first ever Winter Rodeo!", "03/04/2026", "4:00PM", "378 N Achier Parkway");

        _lectures.Add(lecture1);
        _lectures.Add(lecture2);

        _receptions.Add(reception1);
        _receptions.Add(reception2);

        _outdoorEvents.Add(outdoor1);
        _outdoorEvents.Add(outdoor2);

        foreach (Lecture lecture in _lectures)
        {
            Console.WriteLine("Short Description:");
            Console.WriteLine(lecture.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine("Standard Details:");
            Console.WriteLine(lecture.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine("Full Details:");
            Console.WriteLine(lecture.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine();
        }

        foreach (Reception reception in _receptions)
        {
            Console.WriteLine("Short Description:");
            Console.WriteLine(reception.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine("Standard Details:");
            Console.WriteLine(reception.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine("Full Details:");
            Console.WriteLine(reception.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine();
        }

        foreach (Outdoor outdoor in _outdoorEvents)
        {
            Console.WriteLine("Short Description:");
            Console.WriteLine(outdoor.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine("Standard Details:");
            Console.WriteLine(outdoor.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine("Full Details:");
            Console.WriteLine(outdoor.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        new Program().Run();
    }
}