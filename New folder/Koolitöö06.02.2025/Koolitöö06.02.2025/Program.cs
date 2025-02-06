namespace Koolitöö06._02._2025
{
    internal class Program
    {

        static void DrawSquare(int sideLength)
        {
            Console.WriteLine("Ruut:");
            for (int i = 0; i < sideLength; i++)
            {
                Console.WriteLine(new string('*', sideLength));
            }
            int perimeter = 4 * sideLength;
            int area = sideLength * sideLength;
            Console.WriteLine($"Ümbermõõt cm: {perimeter}");
            Console.WriteLine($"Pindala: {area}\n");
        }


        static void DrawDiamond(int sideLength)
        {
            Console.WriteLine("Teemant:");
            for (int i = 0; i < sideLength; i++)
            {
                Console.WriteLine(new string(' ', sideLength - i - 1) + new string('*', 2 * i + 1));
            }
            for (int i = sideLength - 2; i >= 0; i--)
            {
                Console.WriteLine(new string(' ', sideLength - i - 1) + new string('*', 2 * i + 1));
            }
            int perimeter = 4 * sideLength;
            int area = sideLength * sideLength;
            Console.WriteLine($"Ümbermõõt: {perimeter}");
            Console.WriteLine($"Pindala: {area}\n");
        }


        static void DrawRectangle(int length, int width)
        {
            Console.WriteLine("Ristkülik:");
            for (int i = 0; i < width; i++)
            {
                Console.WriteLine(new string('*', length));
            }
            int perimeter = 2 * (length + width);
            int area = length * width;
            Console.WriteLine($"Ümbermõõt: {perimeter}");
            Console.WriteLine($"Pindala: {area}\n");
        }


        static void DrawTriangle(int baseLength, int height)
        {
            Console.WriteLine("Kolmnurk:");
            for (int i = 1; i <= height; i++)
            {
                Console.WriteLine(new string(' ', height - i) + new string('*', 2 * i - 1));
            }
            double side = Math.Sqrt(Math.Pow(baseLength / 2.0, 2) + Math.Pow(height, 2));
            double perimeter = baseLength + 2 * side;
            double area = 0.5 * baseLength * height;
            Console.WriteLine($"Ümbermõõt: {perimeter:F2}");
            Console.WriteLine($"Pindala: {area}\n");
        }


        static void Main()
        {
            Console.WriteLine("Vali kujund: ");
            Console.WriteLine("1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");

            string shapeChoice = Console.ReadLine();

            if (shapeChoice == "1")
            {
                Console.Write("Sisesta ruudu külje pikkus: ");
                int side = int.Parse(Console.ReadLine());
                DrawSquare(side);
            }
            else if (shapeChoice == "2")
            {
                Console.Write("Sisesta teemandi külje pikkus: ");
                int side = int.Parse(Console.ReadLine());
                DrawDiamond(side);
            }
            else if (shapeChoice == "3")
            {
                Console.Write("Sisesta ristküliku pikkus: ");
                int length = int.Parse(Console.ReadLine());
                Console.Write("Sisesta ristküliku laius: ");
                int width = int.Parse(Console.ReadLine());
                DrawRectangle(length, width);
            }
            else if (shapeChoice == "4")
            {
                Console.Write("Sisesta kolmnurga alusmõõt: ");
                int baseLength = int.Parse(Console.ReadLine());
                Console.Write("Sisesta kolmnurga kõrgus: ");
                int height = int.Parse(Console.ReadLine());
                DrawTriangle(baseLength, height);
            }
            else
            {
                Console.WriteLine("Vale valik!");
            }
        }
    }
}
