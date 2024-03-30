using System;

class Circle
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public bool IsPointInside(double x, double y)
    {
        return (x * x + y * y) <= (Radius * Radius);
    }
}

class CircleManager
{
    public Circle[] CreateCircles(int count)
    {
        Circle[] circles = new Circle[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter radius for circle {i + 1}: ");
            double radius = double.Parse(Console.ReadLine());
            circles[i] = new Circle(radius);
        }
        return circles;
    }

    public void PrintCircleInfo(Circle circle)
    {
        Console.WriteLine($"Circle with radius {circle.Radius}:");
        Console.WriteLine($"Area: {circle.CalculateArea()}");
        Console.WriteLine($"Perimeter: {circle.CalculatePerimeter()}\n");
    }

    public (double, double) GetPointFromUser()
    {
        Console.Write("Enter x coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y coordinate: ");
        double y = double.Parse(Console.ReadLine());
        return (x, y);
    }

    public void CheckPointInCircles(Circle[] circles, double x, double y)
    {
        foreach (var circle in circles)
        {
            Console.WriteLine($"Point ({x},{y}) {(circle.IsPointInside(x, y) ? "is inside" : "is outside")} Circle with radius {circle.Radius}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of circles: ");
        int numberOfCircles = int.Parse(Console.ReadLine());

        CircleManager manager = new CircleManager();
        Circle[] circles = manager.CreateCircles(numberOfCircles);

        Console.WriteLine("\nCircle Information:");
        foreach (var circle in circles)
        {
            manager.PrintCircleInfo(circle);
        }

        Console.WriteLine("Enter a point to check if it's inside the circles:");
        var (x, y) = manager.GetPointFromUser();
        manager.CheckPointInCircles(circles, x, y);
    }
}
