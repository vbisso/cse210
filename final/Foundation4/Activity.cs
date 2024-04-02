public class Activity
{
    public string _activityName {set;get;}
    public string _date {set;get;}
    public double _time {set;get;} //minutes

    public Activity(string name, string date, double time){
        _activityName = name;
        _date = date;
        _time = time;
    }
    public virtual double  GetDistance(){
        return 0.0;
    }
    public virtual double GetSpeed(){
        return 0.0;
    }
    public virtual double GetPace(){
        return 0.0;
    }

//03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    public void GetSummary(){
        Console.WriteLine($"{_date} {_activityName} ({_time} min) - Distance {GetDistance():0.00} miles, Speed {GetSpeed():0.00} mph, Pace {GetPace():0.00} min per mile");
    }
}
