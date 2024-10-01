static class ShowPower
{
    public static IEnumerable<double> SuperPower(int number, int power)
    {
        double result = 1;

        if (power == 0)
        {
            yield return 1;
        }
        if (power >= 0)
        {
            for (int i = 1; i <= power; i++)
            {
                result *= number;
                yield return result;
            }
        }
        else
        {
            for (int i = -1; i >= power; i--)
            {
                result /= number;
                yield return result;
            }
        }
    }
}


