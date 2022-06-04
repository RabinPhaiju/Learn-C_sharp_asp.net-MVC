class Problem5
{
    public static void Main() {
        Console.WriteLine("Enter: Airport Tribhuwan International");
    string name = Console.ReadLine();
    List<string> result = name.Split(" ").ToList();

    Console.WriteLine("{0} {1} {2} ",result[1],result[2],result[0]);
        Console.ReadLine();
    }
 
}