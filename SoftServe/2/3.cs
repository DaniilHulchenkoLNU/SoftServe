﻿using System;

class Science
{
    public virtual void Awards()
    {
        Console.WriteLine("We can obtain The Nobel Prize");
    }
}

class Mathematics : Science
{
    public override void Awards()
    {
        Console.WriteLine("We don't need any awards, but we still can obtain The Abel Prize that nobody else can! ");
    }
}

class Physics : Science { }

//class Program
//{
//    static void Main(string[] args)
//    {
//        Science science1 = new Mathematics();
//        Science science2 = new Physics();
//        Science science3 = new Science();
//        science1.Awards();
//        science2.Awards();
//        science3.Awards();
//    }
//}
