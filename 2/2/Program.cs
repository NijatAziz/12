﻿namespace multiple_factorials
{
    class Program
{
    static void Main(string[] args)
    {
        int num, n;

        Console.WriteLine(".....................[Application 1].....................\n\n");
        Console.WriteLine("Please enter a number to get its factorial: ");
        num = Convert.ToInt32(Console.ReadLine());

        n = num; // Assign n to num

        while (num > 0)
        {
            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }
            Console.WriteLine("Factorial of {0}! = {1}\n", num, n);
            num--;
        }
    }
}
}