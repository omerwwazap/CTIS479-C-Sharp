using System;
using System.Collections.Generic;
using System.Text;

//13.Create at least one structure and use it in your application.
//18.Implement at least one operator overload
namespace LeventDurdali_HomeWork1
{

    public struct Location
    {

        public int X;
        public int Y;

        public Location(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        public void Increment(int num)
        {
            X += num;
            Y += num;
        }

        public void Decrement(int num)
        {
            X -= num;
            Y -= num;
        }

        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1} \n", X, Y);
        }

        public static Location operator +(Location p1, Location p2)
        {
            return new Location(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Location operator -(Location p1, Location p2)
        {
            return new Location(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static Location operator ++(Location p1)
        {
            return new Location(p1.X + 1, p1.Y + 1);
        }

        public static Location operator --(Location p1)
        {
            return new Location(p1.X - 1, p1.Y - 1);
        }


    }
}