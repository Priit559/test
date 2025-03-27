class Program
{
    static void Main(string[] args)
    {
        Data data = new Data();

        while (true)
        {
            Console.WriteLine("\nValikud:");
            Console.WriteLine("1. LINQ Skip");
            Console.WriteLine("2. LINQ Join");
            Console.WriteLine("3. Salvesta tekst faili");
            Console.WriteLine("4. Tee numbri püramiid");
            Console.WriteLine("5. Välju rakendusest");

            Console.Write("Tee oma valik (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Mitu nime vahele jätame: ");
                    if (int.TryParse(Console.ReadLine(), out int skipCount))
                    {
                        LinqOperations.SkipExample(data.Names, skipCount);
                    }
                    else
                    {
                        Console.WriteLine("Valikut ei eksisteeri");
                    }
                    break;

                case "2":
                    LinqOperations.JoinExample(data);
                    break;

                case "3":
                    Console.Write("Sisesta tekst mida salvestada: ");
                    string text = Console.ReadLine();
                    Console.Write("Sisesta faili asukoht (e.g. C:\\temp\\myfile.txt): ");
                    string path = Console.ReadLine();
                    FileOperations.SaveToFile(text, path);
                    break;

                case "4":
                    Console.Write("Sisesta püramiidi kõrgus: ");
                    if (int.TryParse(Console.ReadLine(), out int height) && height > 0)
                    {
                        NumberPyramid.PrintPyramid(height);
                    }
                    else
                    {
                        Console.WriteLine("Vale valik - peab olema positiivne number");
                    }
                    break;

                case "5":
                    Console.WriteLine("Väljun programmist...");
                    return;

                default:
                    Console.WriteLine("Vale valik, proovi uuesti");
                    break;
            }
        }
    }
}