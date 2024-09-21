public class Point
{
    private int x;
    private int y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public override string ToString()
    {
        return $"({x}, {y})";
    }

    public int[] GetXYPair()
    {
        return new int[] { x, y };
    }

    protected internal double Distance(int x, int y)
    {
        return Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y - y, 2));
    }

    protected internal double Distance(Point point)
    {
        return Distance(point.x, point.y);
    }
    public static explicit operator double(Point point)
    {
        return point.Distance(0, 0);
    }

}