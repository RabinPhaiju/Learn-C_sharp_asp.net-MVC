using System;
/*class Rectangle
{
   public int length, width;
    public Rectangle(int x, int y)
    {
        length = x;
        width = y;
    }
    public int RectArea()
    {
        return(length * width);
    }
}
class Rectangle2D
{
    public static void Main()
    {
        int area1,area2;
        Rectangle rect1 = new Rectangle(0,0);
        Rectangle rect2 = new Rectangle(20,12);

        rect1.length = 15;
        rect1.width = 10;
        area1 = rect1.length * rect1.width;

        area2 = rect2.RectArea();

        Console.WriteLine("Area1 = " + area1);
        Console.WriteLine("Area2 = " + area2);
    }
}*/

class Room
{
    public double length;
    public double breadth;
    public Room (double x, double y)
    {
        length = x;
        breadth = y;
    }
    public Room(double x)
    {
        length = breadth = x;
    }
    public int Area()
    {
        return (int)(length * breadth);
    }
}
class Room2D
{
    public static void Main()
    {
        Room room1 = new Room(25.0, 15.0);
        Room room2 = new Room(20.0);
        Console.WriteLine("Room1 Area = "+room1.Area());
        Console.WriteLine("Room2 Area = " + room2.Area());
    }
}