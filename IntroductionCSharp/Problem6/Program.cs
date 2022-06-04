using System;
public class Problem6
{
    public static void Main()
    {
        string a = "C Sharp ";
        string b = "Programming";
        Console.Write("{0}", a);
        Util.Second(ref b);
        Console.ReadLine();
    }
}
public class Util
{
    public static void Second(ref string x)
    {
        Console.WriteLine("{0}",x);
    }
}