public class Printer
{
    public string Brand { get; private set; }
    public string Model { get; private set; }
    public bool IsColor { get; private set; }

    public Printer(string brand, string model, bool isColor)
    {
        Brand = brand;
        Model = model;
        IsColor = isColor;
    }
    
    public void Print()
    {
        Console.WriteLine("Printing...");
    }

    public void TurnOn()
    {
        Console.WriteLine("Printer is turned on.");
    }
}

public class LaserPrinter : Printer
{
    public int Speed { get; private set; }

    public LaserPrinter(string brand, string model, bool isColor, int speed)
        : base(brand, model, isColor)
    {
        Speed = speed;
    }

    public void WarmUp()
    {
        Console.WriteLine("Warming up...");
    }
}

public class InkjetPrinter : Printer
{
    public int InkLevel { get; private set; }

    public InkjetPrinter(string brand, string model, bool isColor, int inkLevel)
        : base(brand, model, isColor)
    {
        InkLevel = inkLevel;
    }

    public void CheckInkLevel()
    {
        Console.WriteLine($"Ink level: {InkLevel}%");
    }
}

class Program {
    public static void Main(string[] args){
        LaserPrinter laserPrinter = new LaserPrinter("HP", "LaserJet Pro M15w", true, 20);
        InkjetPrinter inkjetPrinter = new InkjetPrinter("Canon", "PIXMA MG3620", true, 85);

        laserPrinter.TurnOn();
        laserPrinter.WarmUp();
        laserPrinter.Print();

        inkjetPrinter.TurnOn();
        inkjetPrinter.CheckInkLevel();
        inkjetPrinter.Print();
    }
}
