public class Circle : Shape
{
    double pi = 3.14;
    double _radius = 1.0;
    public Circle()
    {
        
    }
    public Circle(double radius)
    {
        _radius = radius;
    }
    public Circle(double radius,string color,bool filled)
    : base(color,filled)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }
    public override double GetArea()
    {
        return pi * _radius * _radius;
    }

    public override double GetPerimeter()
    {
        return 2 * pi * _radius;
    }

    public override string ToString()
    {
        return ("Circle[Shape[color= "+_color+", filled="+_filled+"],radius="+_radius+"]");
    }
}