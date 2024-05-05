using System;

public class Blind
{
     // declare member variables / attributes
    public double _width;
    public double _height;
    public string _color;

    // methods of a class
    public double Area(){
        return _width * _height;
    }

}


public class House
{
    // declare member variables or attributes
    public string _owner;
    public Blind kitchen = new Blind();
    public Blind bedroom = new Blind();

    public List<Blind> _blinds = new List<Blind>();
}

class Program
{
    static void Main(string[] args)
    {
        House house= new House();
        house.kitchen._color = "Red";
        house.kitchen._width = 10;
        house.kitchen._height = 20;


        double area = house.kitchen.Area();
        
        Console.WriteLine("The area of House " + area);
        house._blinds.Add(house.kitchen);
        Console.WriteLine($"{house._blinds[0].Area()} {house._blinds[0]._color}");

        house.kitchen._color = "Green";
        house.kitchen._width = 30;
        house.kitchen._height = 20;
        Console.WriteLine("The area of House " + area);
        house._blinds.Add(house.kitchen);
        Console.WriteLine($"{house._blinds[1].Area()} {house._blinds[1]._color}");

        Console.WriteLine("\n===================================");
        foreach (Blind b in house._blinds){
            Console.WriteLine($"{b.Area()} {b._color}");
        }
        
        
        
    }
}
