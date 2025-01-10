
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Fantaasia kohvik!");
        Console.WriteLine("\n\nMenüü (kohvi valik)\n\n");
        Console.WriteLine("1. Vaike tass");
        Console.WriteLine("2. Keskmine tass");
        Console.WriteLine("3. Suur tass");
        Console.WriteLine("\n\nPalun tee valik numbriga: ");

        if (byte.TryParse(Console.ReadLine(), out byte coffeeSize))
        {
            double price = 0;

            switch (coffeeSize)
            {
                case 1:
                    price = 1.5;
                    break;

                case 2:
                    price = 2.5;
                    break;

                case 3:
                    price = 3;
                    break;

                default:
                    Console.WriteLine("Selline valik puudub.");
                    break;
            }

            Console.WriteLine($"Teie valiku hind on: {price} eurot.");
        }
        else
        {

            Console.WriteLine("Vigane sisestus. Palun sisesta number.");
        }


        Console.ReadKey();

    }
}

