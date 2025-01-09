namespace PaarisPaarituIfjaElseMeetod
{
    internal class Program
    {
        public static bool OnPaaris(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
              
        }
        public static void Main(string[] args)
        {
            Console.Write("Sisesta number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            { 
                if (OnPaaris(number))
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
