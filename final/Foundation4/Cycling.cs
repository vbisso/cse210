public class Cycling : Activity
{
    protected double _speed;
    public Cycling(string name, string date, double time, double speed) : base(name, date, time)
    {
        _speed = speed; //mph
    }
    public override double GetDistance()
    {
        return _speed * (_time / 60.0); //miles
    }
    public override double GetPace()
    { //min per mile
        return 60.0 / GetSpeed();
    }
    public override double GetSpeed()
    {
        return _speed;
    }
}
