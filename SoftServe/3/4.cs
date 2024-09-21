//using System.Collections.Generic;
//public static class IListExtensions: List<T>
//{
//    public static List<int> IncreaseWith(this IList<int> ints, int value)
//    {
//        //return ints.Select(i => i + value).ToList();
//        return ints.Select(delegate (int i)
//        {
//            return i + value;
//        }).ToList();    
//    }
//}

//public static class IEnumerableExtensions: List
//{
//    public string ToString(this IEnumerable<int> ints)
//    {
//        return '['+string.Join(", ", ints)+']';
//    }
//}