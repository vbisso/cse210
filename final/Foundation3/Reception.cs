

public class Reception:Event
{
    public string _emailRSVP {set; get;}

    public Reception(string eventType,string eventTitle,string description,string date,string time, Address address,string emailRSVP):base(eventType,eventTitle,description,date,time,address){
        _emailRSVP = emailRSVP;
    }
    public void DisplayFullEvent(){

        Console.WriteLine($"{_eventType}: {_eventTitle}");
        Console.WriteLine($"{_eventDescription}");
        Console.WriteLine($"RSVP to: {_emailRSVP}");
        Console.WriteLine($"Date: {_eventDate}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetFullAddress()}");
    }

}
