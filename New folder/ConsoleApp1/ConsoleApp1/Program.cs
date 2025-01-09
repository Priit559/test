namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oled sa poiss või tüdruk? (p/t): ");
            char sugu = char.Parse(Console.ReadLine());

            if (sugu == 'p')
            {
                Console.WriteLine("Sa oled noormees.");

            }
            else if (sugu == 't')
            {
                Console.WriteLine("Sa oled neiu.");
            }
            else
            {
                Console.WriteLine("Viga! Sa sisestasid vale soo.");
            }

        }
    }
}
