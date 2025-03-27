public class FileOperations
{
    public static void SaveToFile(string text, string path)
    {
        try
        {
            File.WriteAllText(path, text);
            Console.WriteLine($"Tekst on edukalt salvestatud {path}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Viga faili salvestamisel: {ex.Message}");

            string defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "backup.txt");
            File.WriteAllText(defaultPath, text);
            Console.WriteLine($"Tekst on salvestatud vaikimisi asukohta: {defaultPath}");
        }
    }
}