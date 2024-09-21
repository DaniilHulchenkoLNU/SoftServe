
public abstract class Acinonychini
{
    public string Name { get; protected set; }
    public double Weight { get; protected set; } 

    public Acinonychini(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }

    public abstract void Hunt();
}

public sealed class Acinonyx : Acinonychini
{
    public Acinonyx(string name, double weight)
        : base(name, weight) { }

    public override void Hunt()
    {
        Console.WriteLine($"{Name} hunts ");
    }
}

public class Puma : Acinonychini
{
    public Puma(string name, double weight)
        : base(name, weight) { }

    public override void Hunt()
    {
        Console.WriteLine($"{Name} hunts ");
    }
}
