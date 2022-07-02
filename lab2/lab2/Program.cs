// See https://aka.ms/new-console-template for more information
Circle c = new Circle();
c.radius = 10;
Console.WriteLine(c.calculateArea());
Console.WriteLine(c.calculatePerimeter());


rectangle r = new rectangle();
r.length = 20;
r.width = 10;
Console.WriteLine(r.calculatePerimeter());
Console.WriteLine(r.calculatePerimeter());
    interface shape
{
    double calculateArea();
    double calculatePerimeter();
}

class Circle : shape
{
    static readonly double pi=3.14;
    public int radius { get; set; }
    public double calculateArea()
    {
        return pi*(radius*radius);
    }

    public double calculatePerimeter()
    {
        return 2 * pi * radius;
    }
}

class rectangle:shape
{
    public double length { get; set; }
    public double width { get; set; }

    public double calculateArea()
    {
       return (length*width);
    }

    public double calculatePerimeter()
    {
        return 2 * (length + width);
    }
}



