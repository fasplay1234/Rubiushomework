using System;

public interface IPrintableShape
{
    void PrintType();

    void PrintSquare();

    void PrintPerimeter();
}
public abstract class Shape
{
    public abstract double CalculateArea();

    public abstract double CalculatePerimeter();
}

public class Circle : Shape, IPrintableShape
{
    private double radius;

    public Circle(double radius)
    {
        if (radius < 0) throw new ArgumentException("Радиус не может быть отрицательным");

        this.radius = radius;
    }
    public bool TrySetRadius(double radius)
    {
        if (radius < 0) return false;

        this.radius = radius;

        return true;
    }
    public override double CalculateArea() => Math.PI * radius * radius;

    public override double CalculatePerimeter() => 2 * Math.PI * radius;

    public void PrintType() => Console.WriteLine("Circle");

    public void PrintSquare() => Console.WriteLine($"Area: {CalculateArea()}");

    public void PrintPerimeter() => Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
}

public class Rectangle : Shape, IPrintableShape
{
    private double width;

    private double height;

    public Rectangle(double width, double height)
    {
        if (width < 0 || height < 0) throw new ArgumentException("Размеры не могут быть отрицательными");

        this.width = width;

        this.height = height;
    }

    public bool TrySetDimensions(double width, double height)
    {
        if (width < 0 || height < 0) return false;

        this.width = width;

        this.height = height;

        return true;
    }
    public override double CalculateArea() => width * height;

    public override double CalculatePerimeter() => 2 * (width + height);

    public void PrintType() => Console.WriteLine("Rectangle");

    public void PrintSquare() => Console.WriteLine($"Area: {CalculateArea()}");

    public void PrintPerimeter() => Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
}

public class Triangle : Shape, IPrintableShape
{
    private double sideA, sideB, sideC;

    public Triangle(double a, double b, double c)
    {
        if (!TrySetSides(a, b, c)) throw new ArgumentException("неверные стороные треугольника");
        sideA = a; sideB = b; sideC = c;
    }

    public bool TrySetSides(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a) return false;
        sideA = a; sideB = b; sideC = c;
        return true;
    }

    public override double CalculateArea() => Math.Sqrt(CalculatePerimeter() * (CalculatePerimeter() - sideA) * (CalculatePerimeter() - sideB) * (CalculatePerimeter() - sideC));
    public override double CalculatePerimeter() => sideA + sideB + sideC;

    public void PrintType() => Console.WriteLine("Triangle");
    public void PrintSquare() => Console.WriteLine($"Area: {CalculateArea()}");
    public void PrintPerimeter() => Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
}

public class Trapezoid : Shape, IPrintableShape
{
    private double base1, base2, height;

    public Trapezoid(double base1, double base2, double height)
    {
        if (!TrySetDimensions(base1, base2, height)) throw new ArgumentException("неверные размеры трапеции");
        this.base1 = base1; this.base2 = base2; this.height = height;
    }

    public bool TrySetDimensions(double base1, double base2, double height)
    {
        if (base1 <= 0 || base2 <= 0 || height <= 0) return false;
        this.base1 = base1; this.base2 = base2; this.height = height;
        return true;
    }

    public override double CalculateArea() => ((base1 + base2) / 2) * height;
    public override double CalculatePerimeter() => base1 + base2 + (2 * height);

    public void PrintType() => Console.WriteLine("Trapezoid");
    public void PrintSquare() => Console.WriteLine($"Area: {CalculateArea()}");
    public void PrintPerimeter() => Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        circle.PrintType();
        circle.PrintSquare();
        circle.PrintPerimeter();

        Rectangle rect = new Rectangle(4, 6);
        rect.PrintType();
        rect.PrintSquare();
        rect.PrintPerimeter();

        Triangle triangle = new Triangle(5, 4, 6);
        triangle.PrintType();
        triangle.PrintSquare();
        triangle.PrintPerimeter();

        Trapezoid trapeze = new Trapezoid(5, 4, 7);
        trapeze.PrintType();
        trapeze.PrintSquare();
        trapeze.PrintPerimeter();
    }
}