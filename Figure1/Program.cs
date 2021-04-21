using System;

namespace Figure1
{
    class Program
    {
        static void Main()
        {
            Line L = new Line(1, 2, 3, 4);
            Console.WriteLine("Line:");
            Console.WriteLine(L.Draw());

            Rectangle R = new Rectangle(4, 5, 6, 7, 4, 5);
            Console.WriteLine("Rectangle:");
            Console.WriteLine(R.Draw());

            Triangle T = new Triangle(2, 4, 3, 5);
            Console.WriteLine("Triangle:");
            Console.WriteLine(T.Draw());

            Circle C = new Circle(3, 3, 5);
            Console.WriteLine("Circle:");
            Console.WriteLine(C.Draw());

        }

    }
}

class Figure
{
    public int x { get; protected set; }
    public int y { get; protected set; }

    public Figure(int x1, int y1)
    {
        x = x1;
        y = y1;
    }
}

class Line : Figure
{
    public int x2;
    public int y2;

    public Line(int x2, int y2, int c2, int d2) : base(x2, y2)
    {
        this.x2 = c2;
        this.y2 = d2;
    }
    public string Draw()
    {
        return $"Start:{x} {y}, End:{x2}, {y2}";
    }
}
class Rectangle : Figure
{
    public int a2, a3, a4;
    public int b2, b3, b4;

    public Rectangle(int c1, int d1, int c2, int d2, int c3, int d3) : base(c2, d2)
    {
        this.a2 = c1;
        this.a3 = c2;
        this.a4 = c3;
        this.b2 = d1;
        this.b3 = d2;
        this.b4 = d3;
    }
    public string Draw()
    {
        return $"Vertex1: ({x}, {y}), Vertex2: ({a2}, {b2}) Vertex3: ({a3}, {b3}), Vertex4: ({a4}, {b4})";
    }
}
class Triangle : Figure
{
    public int a2, a3;
    public int b2, b3;

    public Triangle(int c1, int d1, int c2, int d2) : base(c2, d2)
    {
        this.a2 = c1;
        this.a3 = c2;
        this.b2 = d1;
        this.b3 = d2;
    }
    public string Draw()
    {
        return $"Vertex1: ({x}, {y}), Vertex2: ({a2}, {b2}), Vertex3: ({a3}, {b3})";
    }
}
class Circle : Figure
{
    public int a2, b2;
    public int radius;

    public Circle(int c2, int d2, int radius) : base(c2, d2)
    {
        this.a2 = c2;
        this.b2 = d2;
        this.radius = radius;
    }
    public string Draw()
    {
        return $"Center: ({a2}, {b2}) Radius: {radius}";
    }
}
