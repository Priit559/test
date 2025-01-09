namespace IfandElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sisesta oma vanus: ");
            
            int vanus = int.Parse(Console.ReadLine());
            
            if (vanus < 18 )
            
            {
                Console.WriteLine("Oled alaealine.");
            }
            else if (vanus >= 19 && vanus < 65)
            {
                Console.WriteLine("Oled täisealine.");
            }
            else
            {
                Console.WriteLine("Oled pensionär.");
            }
                
                



        }
    }
}
