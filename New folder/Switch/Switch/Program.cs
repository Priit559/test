namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomNumber = random.Next(1, 6);

            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("Üks");
                    break;

                case 2:
                    Console.WriteLine("Kaks");
                    break;

                    case 3:
                    Console.WriteLine("Kolm");
                    break;

                    case 4:
                    Console.WriteLine("Neli");
                    break;

                    case 5:
                    Console.WriteLine("Viis");

                    break;
                    case 6:
                    Console.WriteLine("Kuus");
                    break;

                    default:
                    Console.WriteLine("Viga: number peab olema vahemikus 1 kuni 6.");
                    break;




            }

        }
    }
}
