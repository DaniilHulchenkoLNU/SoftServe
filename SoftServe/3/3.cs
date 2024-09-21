using System.Collections.Generic;

class ListProgram
{
    public static List<int> ListWithPositive(List<int> numbers)
    {
        return numbers.FindAll(delegate (int number)
        {
            return number > 0 && number <= 10;
        });
    }
}