interface ISwimmable
{
    public void Swim() { 
        Console.WriteLine("I can swim!");
    }
}

interface IFlyable
{
    int MaxHeight { get => 0; }

    public void Fly()
    {
        Console.WriteLine($"I can fly at {MaxHeight} meters height!");
    }
}

 interface IRunnable
{
    int MaxSpeed { get => 0; }

    public void Run()
    {
        Console.WriteLine($"I can run up to {MaxSpeed} kilometers per hour!");
    }
}

 interface IAnimal 
{
    int LifeDuration { get=> 0; }
    public void Voice()
    {
        Console.WriteLine("No voice!");
    }

    void ShowInfo()
    {
        Console.WriteLine($"I am a {this.GetType()} and I live approximately {LifeDuration} years.");
    }
}
 class Cat: IAnimal, IRunnable
{
    public int MaxSpeed { get; set; } = 25;
    public int LifeDuration { get; set; } =  20;
    public void Voice()
    {
        Console.WriteLine("Meow!");
    }
}

 class Eagle: IAnimal, IFlyable
{
    public int MaxHeight { get; set; } = 50;
    public int LifeDuration { get; set; } = 10;
}

 class Shark: IAnimal, ISwimmable
{
    public int LifeDuration { get; set; } = 100;

}