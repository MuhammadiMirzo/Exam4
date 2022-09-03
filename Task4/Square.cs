namespace Task4;

public class Square : Rectangle
{
    double _side = 1.0;
    public Square()
    {
        
    }
    public Square(double side)
    {
        _side = side;
    }
    public Square(double side,string color,bool filled)
    :base(side,side,color,filled)
    {
        _side = side;
    }
    public double GetSide()
    {
        return _side;
    }
    public void SetSide(double side)
    {
        _side = side;
    }
    public void SetWidth(double side)
    {
        SetWidth(side);
    }
    public void SetLength(double side)
    {
        SetLength(side);
    }
    public override string ToString()
    {
        return ("Square[Rectnagle[Shape[color="+_color+", filled="+_filled+"], width= "+GetWidth()+",length="+GetLenth());
    }

}
