/*
Showing Creativity and Exceeding Requirements

1. Added a ReadWriteFile.cs file and class
2. Contains a ReadFromFile  functiion that enables the readiging of prompts and 
3. The Reflecting Activity and Listing activity use this ReadWritefile object
Saving and loading a log file.

 */

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            
            Console.Write("Select a choice from the Menu: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 4)
            {
                break; // Exit the loop
            }
            

            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity(
                    "Breathing", 
                    "\nThis activity will help you relax by walking you through breathing in and out slowly. \nClear your mind and focus on your breathing.");
                    breathingActivity.Run();
                    break;

                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity(
                    "Reflecting",
                    "This activity will help you reflect on meaningful moments in your life by providing prompts and questions.");
                    reflectingActivity.Run();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity(
                    "Listing", 
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listingActivity.Run();
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }
        }
        
    }
}