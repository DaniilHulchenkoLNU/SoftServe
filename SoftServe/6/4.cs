static class ShowPowerRange
{
    public static IEnumerable<int> PowerRanger(int degree, int start, int finish)
    {
        if (start > finish || start <= 0 || finish <= 0)
        {
            yield return 0;
            yield break;
        }

        if (degree == 0)
        {
            if (1 >= start && 1 <= finish)
            {
                yield return 1; // Since any number to the power of 0 is 1
            }
            yield break;
        }

        int number = 1;
        int powerResult = (int)Math.Pow(number, degree);

        while (powerResult <= finish)
        {
            if (powerResult >= start)
            {
                yield return powerResult;
            }

            number++;
            powerResult = (int)Math.Pow(number, degree);
        }
    }
}


//Within the class, ShowPowerRange create a static method PowerRanger() that takes in integer degree, start, finish. 

//The method returns all the numbers from the range [start, finish] (inclusive and finish > 0 and start > 0) that are equal to the degree-th power of any positive integer.

//In the case start > finish, or start < 0, or finish < 0 the method returns 0.

//The method involves yielding the intermediate result on each iteration.


//For example, when calling the method PowerRanger():