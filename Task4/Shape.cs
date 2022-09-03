public abstract class Shape
{
    public string _color { get; private set; }
    public bool _filled { get; private set; }   
    public Shape()
    {
        
    }
    public Shape(string color, bool filled)
    {
        _color = color;
        _filled = filled;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
         _color = color;
    }
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return ("Shape [color = "+_color+","+" filled = "+_filled+"]");
    }

}
