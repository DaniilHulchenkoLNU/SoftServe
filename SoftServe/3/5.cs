using System;

public class EventProgram
{
    public event EventHandler Show;

    public EventProgram()
    {
        Show += Dog;
        Show += Cat;
        Show += Mouse;
        Show += Elephant;

        OnShow(EventArgs.Empty);
    }

    protected virtual void OnShow(EventArgs e)
    {
        if (Show != null)
        {
            Show(this, e);
        }
    }

    public static void Dog(object sender, EventArgs e)
    {
        Console.WriteLine("Dog");
    }

    public static void Cat(object sender, EventArgs e)
    {
        Console.WriteLine("Cat");
    }

    public static void Mouse(object sender, EventArgs e)
    {
        Console.WriteLine("Mouse");
    }

    public static void Elephant(object sender, EventArgs e)
    {
        Console.WriteLine("Elephant");
    }
}
