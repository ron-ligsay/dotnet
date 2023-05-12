using System;
// math pow
using System.Math;
using System.Math.Pow;

public class Drawing
{
    public virtual double Area()
    {
        return 0;
    }
}

public class Circle : Drawing
{
    public double Radious { get; set; }
    public Circle() {
        Radious = 5;
    }
    public override double Area()
    {
        return 3.14 * Radious * Radious;
    }
}

public class Square : Drawing
{
    public double Length { get; set; }
    public Square() {
        Length = 6;
    }
    public override double Area()
    {
        return Math.Pow(Length, 2);
    }
}

public class Rectangle : Drawing{
    public double Height { get; set; }
    public double Width { get; set; }
    public Rectangle() {
        Height = 7;
        Width = 8;
    }
    public override double Area()
    {
        return Height * Width;
    }

}

class polymorphism_dynamic{
    static void Main(string[] args)
    {
        Drawing[] draw = new Drawing[3];
        draw[0] = new Circle();
        draw[1] = new Square();
        draw[2] = new Rectangle();

        foreach (Drawing d in draw)
        {
            Console.WriteLine("Area: {0}", d.Area());
        }
    }
}