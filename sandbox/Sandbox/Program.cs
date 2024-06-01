using System;

public abstract class Employee
{
    private string employeeName;    
    public abstract float CalculatePay();
}

public class HourlyEmployee: Employee
{
    private float rate = 9f;
    private float hours = 100f;

    public override float CalculatePay()
    {
        return rate * hours;
    }

    public void DisplayPayCheck(Employee e)
    {
        float pay = e.CalculatePay();
        Console.WriteLine(pay);
    }
}

class Program
{
    static void Main(string[] args)
    {

        HourlyEmployee hourlyEmployee = new HourlyEmployee();
        Console.WriteLine(hourlyEmployee.CalculatePay());   
    
        Employee employee = new Employee();
        Console.WriteLine(employee.CalculatePay());

        hourlyEmployee.DisplayPayCheck(employee);

    }
}
