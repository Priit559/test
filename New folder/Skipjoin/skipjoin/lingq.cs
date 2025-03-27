public class LinqOperations
{
    public static void SkipExample(List<string> names, int count)
    {
        Console.WriteLine($"Jätan vahele esimesed {count} nime:");
        var skipped = names.Skip(count);
        foreach (var item in skipped)
        {
            Console.WriteLine(item);
        }
    }

    public static void JoinExample(Data data)
    {
        Console.WriteLine("Ühendan nimed linnadega:");
        var joined = data.Names.Zip(data.Cities, (name, city) => $"{name} elab {city}");
        foreach (var item in joined)
        {
            Console.WriteLine(item);
        }
    }
}
