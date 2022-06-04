// using System; // na vayani chalyo
class Problem4
{
    public static void Main()
    {
        Console.WriteLine("Enter Name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter City");
        string city = Console.ReadLine();

        Console.WriteLine("Enter Ward No");
        string ward = Console.ReadLine();

        Console.WriteLine("Enter Profession");
        string profession = Console.ReadLine();

        Console.WriteLine("Enter Tole");
        string tole = Console.ReadLine();

        Console.WriteLine("Enter Country");
        string country = Console.ReadLine();

        Console.WriteLine("Name: {0} \t Profession: {1}\n", name,profession);
        Console.WriteLine("City: {0} \t Tole: {1}\n", city, tole);
        Console.WriteLine("Ward No: {0} \t\t Country: {1}\n", ward, country);

    }
}