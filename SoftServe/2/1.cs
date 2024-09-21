class Employee
{
    internal string name;
    private DateTime hiringDate;

    public Employee(string name, DateTime hiringDate)
    {
        this.name = name;
        this.hiringDate = hiringDate;
    }

    public int Experience()
    {
        if (DateTime.Now.Month < hiringDate.Month || (DateTime.Now.Month == hiringDate.Month && DateTime.Now.Day < hiringDate.Day))
            return DateTime.Now.Year - hiringDate.Year - 1;
        else
            return DateTime.Now.Year - hiringDate.Year;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"{name} has {Experience} years of experience");
    }
}

class Developer : Employee
{
    private string programmingLanguage;
    public Developer(string name, DateTime hiringDate, string programmingLanguage)
        : base(name, hiringDate)
    {
        this.programmingLanguage = programmingLanguage;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"{name} is {programmingLanguage} programmer");
    }
}

class Tester : Employee
{
    private bool isAuthomation;

    public Tester(string name, DateTime hiringDate, bool isAuthomation)
        : base(name, hiringDate)
    {
        this.isAuthomation = isAuthomation;
    }

    public override void ShowInfo()
    {
        if (isAuthomation)
            Console.WriteLine($"{name} is authomated tester and has {Experience()} years(s) of experience");
        else
            Console.WriteLine($"{name} is manual tester and has {Experience()} years(s) of experience");
    }
}



