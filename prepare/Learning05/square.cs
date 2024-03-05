public class Square: Shape{
    private double _site;

    public Square(string color, double site): base(color){
        _site = site;
    }
    public override double GetArea(){
        return _site * _site;
    }

}