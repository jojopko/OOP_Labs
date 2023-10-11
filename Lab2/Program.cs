using System;

public class Guitar
{
    public string Brand { get; private set; }
    public string Model { get; private set; }
    public string Type { get; private set; }
    public string Color { get; private set; }
    public double Price { get; private set; }

    public static int RandValue;

    static Guitar()
    {
        Random random = new Random();
        RandValue = random.Next(1, 100);
    }

    public Guitar()
    {
    }

    public Guitar(string brand, string model, string type, string color, double price)
    {
        Brand = brand;
        Model = model;
        Type = type;
        Color = color;
        Price = price;
    }
    
    public void PrintFields()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Type: {Type}, Color: {Color}, Price: {Price}");
    }
}

class Program {
    public static void Main(string[] args){
        Guitar guitar1 = new Guitar();

        Guitar guitar2 = new Guitar("Fender", "Stratocaster", "Electric", "Red", 1200.0);

        Console.WriteLine(Guitar.RandValue);
        Console.WriteLine(Guitar.RandValue);

        guitar1.PrintFields();
        guitar2.PrintFields();
    }
}