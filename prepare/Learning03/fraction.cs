public class Fraction{

    //atributes
    private int _top;
    private int _bottom;
    //constructors
    public Fraction(){
        _top = 1;
        _bottom =1;
    }
    public Fraction(int top){
        _top = top;
        _bottom = 1;
    }
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }
   //setters and getters
    public int GetTop(){
        return _top;
    }
    public void SetTop(int top){
        _top = top;
    }
    public int GetBottom(){
        return _bottom;
    }
    public void SetBottom(int bottom){
        _bottom = bottom;
    }

    //methods
    public string GetFractionString(){
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }


}