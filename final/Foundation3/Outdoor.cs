
public class Outdoor:Event
{
    public string _weather {set; get;}
    public Outdoor(string eventType,string eventTitle,string description,string date,string time, Address address,string weather):base(eventType,eventTitle,description,date,time,address){
        _weather = weather;
    }
    public void DisplayFullEvent(){
        Console.WriteLine($"{_eventType}: {_eventTitle}");
        Console.WriteLine($"{_eventDescription}");
        Console.WriteLine($"Weather: {_weather}");
        Console.WriteLine($"Date: {_eventDate}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetFullAddress()}");
    }

}
