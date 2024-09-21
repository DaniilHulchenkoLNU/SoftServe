public class Fraction
{
    readonly int numerator;
    readonly int denominator;

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0) throw new ArgumentException("Denominator cannot be zero");

        int gcd = GCD(numerator, denominator);
        this.numerator = numerator / gcd;
        this.denominator = denominator / gcd;

        if (this.denominator < 0)
        {
            this.numerator = -this.numerator;
            this.denominator = -this.denominator;
        }
    }

    private static int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public override string ToString()
    {
        return $"{numerator} / {denominator}";
    }

    public double ToDouble()
    {
        return (double)numerator / denominator;
    }

    public static explicit operator double(Fraction fraction)
    {
        return fraction.ToDouble();
    }

    public static implicit operator Fraction(double value)
    {
        int denominator = 1;
        while (value % 1 != 0){
            value *= 10;
            denominator *= 10;
        }
        return new Fraction((int)value, denominator);
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        int newNumerator = a.numerator * b.denominator + b.numerator * a.denominator;
        int newDenominator = a.denominator * b.denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        int newNumerator = a.numerator * b.denominator - b.numerator * a.denominator;
        int newDenominator = a.denominator * b.denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public static Fraction operator -(Fraction f) => new Fraction(-f.numerator, f.denominator);
    public static Fraction operator +(Fraction f) => f;

    public static Fraction operator !(Fraction f) => new Fraction(f.denominator, f.numerator);

    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        return new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
    }

    public override bool Equals(object obj)
    {
        if (obj is Fraction fraction)
        {
            return this.numerator == fraction.numerator && this.denominator == fraction.denominator;
        }
        return false;
    }

    public static bool operator ==(Fraction a, Fraction b)
    {
        if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;
        if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

        return a.Equals(b);
    }

    public static bool operator !=(Fraction a, Fraction b)
    {
        return !(a == b);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(numerator, denominator);
    }
}
