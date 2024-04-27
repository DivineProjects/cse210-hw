using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "2";
        List<int> numbersList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        while (int.Parse(input) != 0)
        {
          Console.Write("Enter Number: ");
          input = Console.ReadLine();
          if (int.Parse(input) != 0)
          {
            numbersList.Add(int.Parse(input));
          }
        }

        int sum = 0;
        int largestNumber = 0;
        int smallestNumber = 100000000;
        foreach (int number in numbersList)
        {
            sum += number;
            if (largestNumber < number)
            {
               largestNumber = number; 
            }

            if (smallestNumber > number && number > 0)
            {
                smallestNumber = number;
            }
        }

        float average = ((float)sum) / (numbersList.Count);
        // print out
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");

        numbersList.Sort();
        foreach (int number in numbersList){
            Console.WriteLine(number);
        }

    }
}