using System;

class Program
{
    static void Main(string[] args)
    {

    }
}

public interface IPaintTool
{
    void MouseUp();
    void MouseOver();
}

public class IPencilTool : IPaintTool
{
    public void MouseOver()
    {
        Console.WriteLine("Show pencil icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Draw a line.");
    }
}

public class ISquare : IPaintTool
{
    public void MouseOver()
    {
        Console.WriteLine("Show square icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Draw a square.");
    }
}

public class IEraser : IPaintTool
{
    public void MouseOver()
    {
        Console.WriteLine("Show an eraser icon");
    }

    public void MouseUp()
    {
        Console.WriteLine("Erase the selected object.");
    }
}