using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Value of A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Value of B: ");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Before Swapping : ");
        Console.WriteLine("A = " + A);
        Console.WriteLine("B = " + B);
        (A, B) = (B, A);
        Console.WriteLine("After Swapping : ");
        Console.WriteLine("A = " + A);
        Console.WriteLine("B = " + B);
    }
}
