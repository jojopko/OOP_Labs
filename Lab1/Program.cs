
public class Guitar
{
    public string Brand { get; private set; }
    public string Model { get; private set; }
    public string Type { get; private set; }
    public string Color { get; private set; }
    public double Price { get; private set; }
    public static int Count { get; private set; }

    public Guitar()
    {
        Count++;
    }

    public void InitFields(string brand, string model, string type, string color, double price)
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
        guitar1.InitFields("Fender", "Stratocaster", "Electric", "Red", 1200.0);

        Guitar guitar2 = new Guitar();
        guitar2.InitFields("Gibson", "Les Paul", "Electric", "Sunburst", 2500.0);

        Guitar guitar3 = new Guitar();
        guitar3.InitFields("Martin", "D-28", "Acoustic", "Natural", 3000.0);

        guitar1.PrintFields();
        guitar2.PrintFields();
        guitar3.PrintFields();

        Console.WriteLine($"Total guitars created: {Guitar.Count}");
    }
}