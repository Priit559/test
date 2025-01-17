namespace M_koer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene arv: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sisesta teine arv: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sisesta tehe(+, -, *, /);");

            char operation = Convert.ToChar(Console.ReadLine());

            double result;

            switch (operation)
            {
                case '+':
                    result =
                        number1 + number2;

                    break;
                case '-':
                    result =
                        number1 - number2;

                    break;
                case '*':
                    result =
                        number1 * number2;

                    break;

                case '/':
                    if (number2 == 0)

                    {
                        Console.WriteLine("Jagamine nulliga ei ole võimalik!");
                        return;
                    }
                    result = number1 / number2;

                    break;
                default:

                    Console.WriteLine("Lubamatu tehe!");
                    return;


            }
            Console.WriteLine("Tulemus: " + result);
        }
    }
}
