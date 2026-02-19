namespace Digitalis__nyomozoiroda2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Ügyek kezelése\r\n2.Személyek kezelése\r\n3.Bizonyítékok kezelése\r\n4.Idővonal megtekintése\r\n5.Elemzés / döntések\r\n6.Kilépés");
            int valasztas = Convert.ToInt32(Console.ReadLine());
            switch (valasztas)
            {
                case 1:
                    Console.WriteLine("Ügyek kezelése");
                    break;
                case 2:
                    Console.WriteLine("Személyek kezelése");
                    break;
                case 3:
                    Console.WriteLine("Bizonyítékok kezelése");
                    break;
                case 4:
                    Console.WriteLine("Idővonal megtekintése");
                    break;
                case 5:
                    Console.WriteLine("Elemzés / döntések");
                    break;
                case 6:
                    Console.WriteLine("Kilépés");
                    break;
                default:
                    Console.WriteLine("Érvénytelen választás. Kérem, válasszon újra.");
                    break;
            }
        }
    }
}
