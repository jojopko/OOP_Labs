public class Set
{
    private List<int> elements;

    public Set(params int[] elements)
    {
        this.elements = new List<int>(elements);
    }

    public static Set operator &(Set set1, Set set2)
    {
        var result = new Set();
        foreach (int element in set1.elements)
        {
            if (set2.elements.Contains(element))
            {
                result.elements.Add(element);
            }
        }
        return result;
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

        Set intersection = set1 & set2;

        Console.WriteLine(intersection);
    }
}
