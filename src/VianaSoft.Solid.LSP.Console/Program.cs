public class Shape
{
    public virtual double Area()
    {
        throw new NotImplementedException();
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return Width * Height;
    }
}

public class Square : Shape
{
    public double SideLength { get; set; }

    public override double Area()
    {
        return SideLength * SideLength;
    }
}

public class Program
{
    static void PrintArea(Shape shape)
    {
        Console.WriteLine($"Area: {shape.Area()}");
    }

    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle { Width = 5, Height = 3 };
        Square square = new Square { SideLength = 4 };

        PrintArea(rectangle);
        PrintArea(square);
    }
}