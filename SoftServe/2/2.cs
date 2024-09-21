public abstract class Car
{
    internal string mark;
    internal int prodYear;
    public Car(string mark, int prodYear)
    {
        this.mark = mark;
        this.prodYear = prodYear;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Mark: {mark}, Producted in {prodYear}");
    }
}

public class SportCar : Car
{
    private int maxSpeed;
    public SportCar(string mark, int prodYear, int maxSpeed)
        : base(mark, prodYear)
    {
        this.maxSpeed = maxSpeed;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Max speed: {maxSpeed}");
    }
}

public class Lory : Car
{
    private double loadCapacity;
    public Lory(string mark, int prodYear, double loadCapacity)
        : base(mark, prodYear)
    {
        this.loadCapacity = loadCapacity;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Load capacity: {loadCapacity}");
    }
}