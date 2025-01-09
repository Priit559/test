namespace EvenAndOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sisesta number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} on paarisarv.");
                }
                else
                {
                    Console.WriteLine($"{number} on paaritu arv.");
                }
            }
            else
            {
                Console.WriteLine("Vigane sisend. Palun sisesta täisarv.");
            }
            Console.ReadKey();
        }
    }
}
