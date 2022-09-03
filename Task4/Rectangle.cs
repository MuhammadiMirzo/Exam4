namespace Task4;

public class Rectangle : Shape
{
    double _width = 1.0;
    double _length = 1.0;
    public Rectangle()
    {
        
    }
    public Rectangle(double width,double height)
    {
        _width = width ;
        _length = height;
    }
    public Rectangle(double width,double height,string color, bool filled) 
    :base(color, filled)
    {
        _width = width ;
        _length = height;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }
    public double GetLenth()
    {
        return _length;
    }

    public override double GetArea()
    {
        return _width * _length;
    }

    public override double GetPerimeter()
    {
        return 2*(_width + _length);
    }
    public override string ToString()
    {
        return ("Rectangle[Shape[color="+_color+", filled="+_filled+"], width="+_width+", length="+_length+"]]");
    }
}
