using System;

public class obaidul2210Ass1
{
    public static void Main(string[] args)
    {
        string name = "hishiro";
        int counter = 0;
        Console.WriteLine("Guess The name of your friend?");
        while (true)
        {
            string guessName = Console.ReadLine();
            if (name == guessName)
            {
                Console.WriteLine("Your guess is correct");
                counter = counter + 1;
                break;
            }
            else
            {
                Console.WriteLine("Guess Again");
                counter = counter + 1;
            }
        }
        Console.WriteLine("The number of guesses was: " + counter);
    }
}
