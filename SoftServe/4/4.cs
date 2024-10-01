using System;
using System.Collections.Generic;

public interface IShape
{
    public double Area() => 0;
    public object Clone() => this.Clone();
}

public class Rectangle : IShape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public double Area() => Length * Width;
}

public class Trapezoid : IShape
{
    public double Length1 { get; set; }
    public double Length2 { get; set; }
    public double Width { get; set; }

    public double Area() => (Length1 + Length2) * Width / 2;
}

public class Room<T> : ICloneable, IComparable<Room<T>> where T : IShape
{
    public double Height { get; set; }
    public T Floor { get; set; }

    public double Volume() => Floor.Area() * Height;

    public object Clone()
    {
        return new Room<T>
        {
            Height = this.Height,
            Floor = (T)this.Floor.Clone()
        };
    }

    public int CompareTo(Room<T> other)
    {
        if (other == null) return 1;

        return this.Floor.Area().CompareTo(other.Floor.Area());
    }
}

public class RoomComparerByVolume<T> : IComparer<Room<T>> where T : IShape
{
    public int Compare(Room<T>? r1, Room<T>? r2)
    {
        double volume1 = r1.Volume();
        double volume2 = r2.Volume();
        return volume1.CompareTo(volume2);
    }
}


