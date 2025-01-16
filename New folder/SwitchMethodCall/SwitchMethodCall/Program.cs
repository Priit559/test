namespace SwitchMethodCall
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Sisesta sõiduki tüüp (Coupe, Truck, Buss):");
            string soidukiTüüp = Console.ReadLine().ToLower();

            switch(soidukiTüüp)
            {
                case "coupe":
                    KuvaCoupeInfo();
                    break;
                case "truck":
                    KuvaTruckInfo();
                    break;
                case "buss":
                    KuvaBussInfo();
                    break;
                default:
                    Console.WriteLine("Tundmatu sõiduki tüüp.");
                    break;
            }
            Console.ReadKey();
        }
        static void KuvaCoupeInfo()
        {
            Console.WriteLine("Coupe on kaheukseline auto.");
        }
        static void KuvaTruckInfo()
        {
            Console.WriteLine("Truck on veoauto, mida kasutatakse kaupade transpordiks.");
        }
        static void KuvaBussInfo()
        {
            Console.WriteLine("Buss on sõiduk inimeste transpordiks.");
        }
    

    }
}
