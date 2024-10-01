//class Program2
//{
//    delegate int Operation(int x, int y);
//    static void Main(string[] args)
//    {
//        Operation del = Add;
//        del += Multiply;
//        del += Multiply;
//        del += Add;
//        del -= Multiply;
//        int result = del(6, 5);
//        Console.WriteLine(result);
//        Console.Read();
//    }
//    private static int Add(int x, int y) { return x + y; }
//    private static int Multiply(int x, int y) { return x * y; }
//}