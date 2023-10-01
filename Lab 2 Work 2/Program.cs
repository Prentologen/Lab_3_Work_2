using System;

class Point
{
    public double X { get; }
    public double Y { get; }
    public string Name { get; }

    public Point(double x, double y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}

class Figure
{
    private Point[] points;

    public Figure(Point point1, Point point2, Point point3)
    {
        points = new Point[] { point1, point2, point3 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        points = new Point[] { point1, point2, point3, point4 };
    }

    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        points = new Point[] { point1, point2, point3, point4, point5 };
    }

    public double GetSideLength(Point A, Point B)
    {
        double deltaX = B.X - A.X;
        double deltaY = B.Y - A.Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            int nextIndex = (i + 1) % points.Length; 
            perimeter += GetSideLength(points[i], points[nextIndex]);
        }
        Console.WriteLine($"Назва багатокутника: {points.Length}-кут");
        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}

class Program
{
    static void Main()
    {
        Point point1 = new Point(0, 0, "A");
        Point point2 = new Point(0, 5, "B");
        Point point3 = new Point(4, 0, "C");

        Figure triangle = new Figure(point1, point2, point3);
        triangle.CalculatePerimeter();

        Point point4 = new Point(0, 0, "A");
        Point point5 = new Point(0, 5, "B");
        Point point6 = new Point(4, 0, "C");
        Point point7 = new Point(4, 5, "D");

        Figure quadrilateral = new Figure(point4, point5, point6, point7);
        quadrilateral.CalculatePerimeter();

        Console.ReadLine();
    }
}