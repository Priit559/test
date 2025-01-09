namespace AroundEarth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maaRaadiusKm = 6371;

            double maaÜmbermõõtKm = 2 * Math.PI * maaRaadiusKm;

            double mündiLäbimõõtM = 0.02575;

            double maaÜmbermõõtM = maaÜmbermõõtKm * 1000;

            long müntideArv = (long)(maaÜmbermõõtM / mündiLäbimõõtM);

            Console.WriteLine("Maa ümbermõõt: " + maaÜmbermõõtKm + " km");
            Console.WriteLine("Vajalikud 2-eurosed mündid ümber Maa: " + müntideArv);

            Console.ReadKey();
        } 
    }
}
