public interface IOperations
{
    Set Union(Set otherSet);
    Set Intersection(Set otherSet);
    Set Difference(Set otherSet);
}

public interface ILimits
{
    int Min();
    int Max();
}

public class Set : IOperations, ILimits
{
    private List<int> elements;

    public Set(params int[] elements)
    {
        this.elements = new List<int>(elements);
    }

    public Set Union(Set otherSet)
    {
        var result = new Set(this.elements.ToArray());
        foreach (var element in otherSet.elements)
        {
            if (!this.elements.Contains(element))
            {
                result.elements.Add(element);
            }
        }
        return result;
    }

    public Set Intersection(Set otherSet)
    {
        var result = new Set();
        foreach (var element in this.elements)
        {
            if (otherSet.elements.Contains(element))
            {
                result.elements.Add(element);
            }
        }
        return result;
    }

    public Set Difference(Set otherSet)
    {
        var result = new Set();
        foreach (var element in this.elements)
        {
            if (!otherSet.elements.Contains(element))
            {
                result.elements.Add(element);
            }
        }
        return result;
    }

    public int Min()
    {
        return this.elements.Min();
    }

    public int Max()
    {
        return this.elements.Max();
    }

    public override string ToString()
    {
        return "{" + string.Join(", ", this.elements) + "}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Set set1 = new Set(1, 2, 3, 4, 5);
        Set set2 = new Set(4, 5, 6, 7, 8);

        Set union = set1.Union(set2);
        Set intersection = set1.Intersection(set2);
        Set difference = set1.Difference(set2);

        Console.WriteLine($"Union: {union}");
        Console.WriteLine($"Intersection: {intersection}");
        Console.WriteLine($"Difference: {difference}");

        Console.WriteLine($"Min of set1: {set1.Min()}");
        Console.WriteLine($"Max of set1: {set1.Max()}");
    }
}
