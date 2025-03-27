public class NumberPyramid
{
    public static void PrintPyramid(int height)
    {
        Console.WriteLine($"Numbriline püramiid numbrilise kõrgusega {height}:");
        for (int i = 1; i <= height; i++)
        {

            for (int j = 0; j < height - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= i; k++)
            {
                Console.Write(k);
            }

            for (int l = i - 1; l >= 1; l--)
            {
                Console.Write(l);
            }

            Console.WriteLine();
        }
    }
}
