using System;

class Program
{
    static void Main(string[] args)
    {
        
        // BreathingActivity breathingActivity= new BreathingActivity();
        // breathingActivity.Run();
        ListingActivity activity = new ListingActivity(
            "Listing", 
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
            5);
        activity.Run();
    }
}