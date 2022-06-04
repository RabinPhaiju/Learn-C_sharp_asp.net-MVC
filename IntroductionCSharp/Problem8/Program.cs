class Problem8
{
    public static void Main() {

        for (int i = 0; i < 3; i++) {
            for (int j = 2; j > i; j--)
            {
                Console.Write("  ");
            }
            for (int k = 0; k < i*2+1; k++)
            {
                Console.Write("X ");
            }
            Console.WriteLine("");
        }
        for (int i = 2; i > 0; i--) {
            for (int j = 3; j> i; j--)
            {
                Console.Write("  ");
            }
            for (int k =i*2+1 ; k > 2; k--)
            {
                Console.Write("X ");
            }
            Console.WriteLine("");
        }
        Console.ReadLine();
    }
}