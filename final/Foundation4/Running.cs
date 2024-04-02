
public class Running:Activity
{
    protected double _distance; //miles
    public Running(string name, string date, double time,double distance):base( name,  date,  time){
        _distance = distance;
    }

    public override double GetDistance(){
        return _distance;
    }
    public override double GetPace(){ //min per mile
        return  _time / _distance;
    }
    public override double GetSpeed(){
        return 60 / GetPace();
    }
    
    

}
