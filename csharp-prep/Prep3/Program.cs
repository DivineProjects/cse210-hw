using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int random_number = 0;
        string input = "";
        int guess_number = 0;
        int count = 0;
        string play = "yes";

        do
        {
            count = 1;
            random_number = randomGenerator.Next(1, 100);
            Console.WriteLine($"Random Number: {random_number}");
            Console.Write("\nWhat is the magic number? ");
            input= Console.ReadLine();
            guess_number = int.Parse(input);
            Console.WriteLine($"Your guess is {guess_number}");
            
            while (guess_number != random_number)
            {
                
                if (guess_number < random_number)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    input = Console.ReadLine();
                    guess_number = int.Parse(input);
                }else if (guess_number > random_number)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    input = Console.ReadLine();
                    guess_number = int.Parse(input);
                }
                count += 1;
            }
            
            Console.WriteLine($"\nYou guessed it! {random_number}");
            Console.WriteLine($"You have made {count} guesses");

            Console.Write("Do you want to play again? Yes/No ");
            input = Console.ReadLine();
            play = input.ToLower();
        } while (play == "yes");
        
    }
}