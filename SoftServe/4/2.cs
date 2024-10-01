namespace qw;
public interface IAnimal
{
    string Name { get => this.GetType().Name; set => this.Name = value; }
    public void Feed();
    public void Voice();
}

public class Dog : IAnimal
{
    public void Feed()
    {
        Console.WriteLine("I eat meat");
    }

    public void Voice()
    {
        Console.WriteLine("Woof");
    }
}

class Cat : IAnimal
{

    public void Feed()
    {
        Console.WriteLine("I eat mice");
    }

    public void Voice()
    {
        Console.WriteLine("Mew");
    }
}

