public delegate double CalcDelegate(double a, double b, char sign);

public class CalcProgram
{
    public CalcDelegate funcCalc = Calc;

    public static double Calc(double a, double b, char sign)
    {
        switch (sign)
        {
            case '+':
                return a + b;
            case '-':
                return a - b;
            case '*':
                return a * b;
            case '/':
                if (b == 0)
                    return 0;
                return a / b;
            default:
                throw new ArgumentException("Invalid sign");
        }
    }
}
