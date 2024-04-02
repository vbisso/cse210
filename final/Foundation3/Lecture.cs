

public class Lecture:Event
{
    public string _speaker {set; get;}
    public int _capacity {set;get;}

    public Lecture(string eventType,string eventTitle,string description,string date,string time, Address address,string speaker,int capacity):base(eventType,eventTitle,description,date,time,address){
        _speaker = speaker;
        _capacity = capacity;
    }
    public void DisplayFullEvent(){

        Console.WriteLine($"{_eventType}: {_eventTitle}");
        Console.WriteLine($"{_eventDescription}");
        Console.WriteLine($"Speaker: {_speaker} | Capacity: {_capacity}");
        Console.WriteLine($"Date: {_eventDate}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetFullAddress()}");
    }
}
