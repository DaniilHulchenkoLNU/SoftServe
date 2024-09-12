//using AutoMapper;

//public class MyAccessModifiers
//{
//    private int birthYear;
//    protected string personalInfo;
//    private protected string IdNumber;

//    public MyAccessModifiers(int birthYear, string personalInfo, string IdNumber) { throw new NotImplementedException(); }

//    public int Age { get { return DateTime.Now.Year - this.birthYear; } }
//    public byte averageMiddleAge = 50;
//    internal string Name{   get { return this.Name; }
//                            set { this.Name = value; } }
//    public string NickName { get { return NickName; }
//                             internal set { this.NickName = value; } }
//    protected internal bool HasLivedHalfOfLife(int currentAge, int lifeExpectancy) {
//        return currentAge <= lifeExpectancy / 2;
//    }


//    private static Mapper mapper = new Mapper(new MapperConfiguration(cfg => { }));
//    public static bool operator ==(MyAccessModifiers a, MyAccessModifiers b)
//    {   
//        return mapper.Map<MyAccessModifiers>(a).Equals(mapper.Map<MyAccessModifiers>(b));
//    }
//    public static bool operator !=(MyAccessModifiers a, MyAccessModifiers b)
//    {
//        return !mapper.Map<MyAccessModifiers>(a).Equals(mapper.Map<MyAccessModifiers>(b));
//    }
//}

//{
//    return (a.Name == b.Name && a.personalInfo == b.personalInfo && a.Age == b.Age);
//}

//return !Mapper(a, b);



public class MyAccessModifiers
{
    private int birthYear;

    protected string personalInfo;

    private protected string IdNumber;

    public static byte averageMiddleAge = 50;

    public int Age
    {
        get { return DateTime.Now.Year - this.birthYear; }
    }

    internal string Name { get; set; }

    public string NickName { get; internal set; }

    public MyAccessModifiers(int birthYear, string IdNumber, string personalInfo)
    {
        this.birthYear = birthYear;
        this.IdNumber = IdNumber;
        this.personalInfo = personalInfo;
    }

    protected internal void HasLivedHalfOfLife() { }


    public static bool operator ==(MyAccessModifiers obj1, MyAccessModifiers obj2)
    {
        return (obj1.Name == obj2.Name && obj1.Age == obj2.Age && obj1.personalInfo == obj2.personalInfo);
    }

    public static bool operator !=(MyAccessModifiers obj1, MyAccessModifiers obj2)
    {
        return !(obj1 == obj2);
    }

    public override bool Equals(object obj)
    {
        if (obj is MyAccessModifiers person)
        {
            return this == person;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age, personalInfo);
    }
}
