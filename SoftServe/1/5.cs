public class Person
{
    
    protected string name;
    protected int yearOfBirth;
    protected string healthInfo;

    public Person(int yearOfBirth, string name, string healthInfo)
    {
        this.yearOfBirth = yearOfBirth;
        this.name = name;
        this.healthInfo = healthInfo;
    }

    //public string GetHealthStatus()
    //{
    //    return name + ": " + yearOfBirth + ". " + healthInfo;
    //}
}

public class Child : Person
{
    private string childIDNumber;
    public Child(int yearOfBirth, string name, string childIDNumber, string healthInfo)
        : base(yearOfBirth, name, healthInfo)
    {
        this.childIDNumber = childIDNumber;
    }
     public string GetHealthStatus()
    {
        return name + ": " + yearOfBirth + ". " + healthInfo;
    }
    

    public override string ToString()
    {
        return $"{name} {childIDNumber}";
    }
}

public class Adult : Person
{
    private string passportNumber;

    public Adult(int yearOfBirth, string name, string passportNumber, string healthInfo)
        : base(yearOfBirth, name, healthInfo)
    {
        this.passportNumber = passportNumber;
    }

    public string GetHealthStatus()
    {
        return name + ": " + yearOfBirth + ". " + healthInfo;
    }
    public override string ToString()
    {
        return $"{name} {passportNumber}";
    }
}
