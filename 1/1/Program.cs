{
    public static int Main(string[] args)
    {
        Console.Write("enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("the entered number is even.");
        }
        else
        {
            Console.WriteLine("the entered number is odd.");
        }

        return 0;
    }
}