public class Swimming:Activity
{
    protected int _numOfLaps;
    public Swimming(string name, string date, double time, int numOfLaps) : base(name, date, time)
    {
        _numOfLaps = numOfLaps;
    }
    public override double GetDistance()
    {
        return _numOfLaps * 50 / 1000.0 * 0.62;
        
    }
    public override double GetSpeed()
    {
        return GetDistance() / (_time / 60.0); //miles per hour
    }
    public override double GetPace()
    {
        return _time/ GetDistance();
    }
}
