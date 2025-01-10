namespace SwitchDayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            DayOfWeek dayOfWeek = today.DayOfWeek;

            switch (dayOfWeek)

            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Täna on Esmaspäev");
                    break;

                case DayOfWeek.Tuesday:
                    Console.WriteLine("Täna on Teisipäev");
                    break;

                case DayOfWeek.Wednesday:
                    Console.WriteLine("Täna on Kolmapäev");
                    break;

                case DayOfWeek.Thursday:
                    Console.WriteLine("Täna on Neljapäev");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("Täna on Reede");
                    break;

                case DayOfWeek.Saturday:
                    Console.WriteLine("Täna on Laupäev");
                    break;

                case DayOfWeek.Sunday:
                    Console.WriteLine("Täna on Pühapäev");
                    break;

                default:
                    Console.WriteLine("Viga!");
                    break;
            }






        }
    }
}
