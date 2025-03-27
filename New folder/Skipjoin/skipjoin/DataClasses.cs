public class Data
{
    public List<string> Names { get; set; }
    public List<int> Ages { get; set; }
    public List<string> Cities { get; set; }

    public Data()
    {
        Names = new List<string> { "Mari", "Jüri", "Andu", "Tom", "Liisa", "Mihkel", "Liia", "Sirli" };
        Ages = new List<int> { 25, 30, 22, 35, 28, 40, 19, 33 };
        Cities = new List<string> { "Tallinnas", "Tartus", "Pärnus", "Tallinnas", "Narvas", "Tartus", "Pärnus", "Tallinnas" };
    }
}