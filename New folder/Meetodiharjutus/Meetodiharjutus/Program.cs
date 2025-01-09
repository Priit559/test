namespace Meetodiharjutus
{
    internal class Program
    {
        public static void Jalgratas(string tootja, string mudel, int rattad, bool onElektriline)
        {
            Console.WriteLine("Jalgratta info:");
            Console.WriteLine($"Tootja: {tootja}");
            Console.WriteLine($"Mudel: {mudel}");
            Console.WriteLine($"Rattaid: {rattad}");

            if (onElektriline)
            {
                Console.WriteLine("See on elektriline jalgratas.");
            }
            else
            {
                Console.WriteLine("See ei ole elektriline jalgratas.");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            Jalgratas("Ereljuukas", "Versioon 3", 2, false);
            Jalgratas("Kokukas", "Turbo", 2, true);
            Jalgratas("Tõuks", "Jalg2", 2, false);
            Jalgratas("BMX", "Ülelaadimisega GT", 2, true);

            Console.ReadKey();
        }
    }
}
