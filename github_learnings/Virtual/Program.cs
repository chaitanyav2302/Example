class Program
{
    public void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

class Circle : Shape
{
    // This method is not marked as override, but it is still using the base class method.
    public void DrawCircle()
    {
        Draw(); // Calls the Draw method from the base class
        Console.WriteLine("Drawing a circle");
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle();
        circle.DrawCircle(); // Calls the Draw method from the base class
    }
}
