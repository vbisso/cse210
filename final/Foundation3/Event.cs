using Microsoft.Win32.SafeHandles;


public class Event
{
    public string _eventType {set; get;}
    public string _eventTitle {set; get;}
    public string _eventDescription {set; get;}
    public string _eventDate {set; get;}
    public string _time {set; get;}
    public Address _address {set; get;}

    public Event(string eventType,string eventTitle,string description,string date,string time, Address address){
        _eventType = eventType;
        _eventTitle = eventTitle;
        _eventDescription = description;
        _eventDate = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"{_eventTitle}");
        Console.WriteLine($"{_eventDescription}");
        Console.WriteLine($"Date: {_eventDate}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetFullAddress()}");
    }
    public void DisplayShortDescription()
    {
        Console.WriteLine($"{_eventType}: {_eventTitle}");
        Console.WriteLine($"Date: {_eventDate}");
    }

}
