using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment= new Assignment('Roberto Rodriguez', 'Fractions');
        // Console.WriteLine(assignment.GetSummary()); 
        MathAssignment mathAssignment= new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8 - 19");
        Console.WriteLine(mathAssignment.GetHomeworkList());

    }
}