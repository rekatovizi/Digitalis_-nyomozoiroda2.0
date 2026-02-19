namespace Digitalis__nyomozoiroda2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adattar adattar = new Adattar(new List<Ugy>(), new List<Szemely>(), new List<Bizonyitek>(), new List<Felhasznalo>());
            do
            {
                int valasztas = 0;
                int valasz =0;
                Console.WriteLine("1 Ügyek kezelése\r\n2 Személyek kezelése\r\n3 Bizonyítékok kezelése\r\n4 Idővonal megtekintése\r\n5 Elemzés / döntések\r\n6 Kilépés");
                valasztas = Convert.ToInt32(Console.ReadLine());
                switch (valasztas)
                {
                    case 1:
                        Console.WriteLine("1 ügy hozzáadása 2 Ügy törlése 3 Ügyek listázása 4 Ügy állapotváltoztatása");
                        break;
                    case 2:
                        Console.WriteLine("Személyek kezelése");
                        break;
                    case 3:
                        Console.WriteLine("1 bizonyíték hozzáadása\r\n2 bizonyíték törlése \r\n3 bizonyítékok listázása");
                        valasz = Convert.ToInt32(Console.ReadLine());
                        switch (valasz)
                        {
                            case 1:
                                Console.WriteLine("Bizonyíték hozzáadása");
                                Bizonyitek b = new Bizonyitek(0, "", "", 0);
                                b.Bizonyitekhozzaadas(adattar);
                                break;
                            case 2:
                                Console.WriteLine("Bizonyíték törlése");
                                b = new Bizonyitek(0, "", "", 0);
                                b.Bizonyitektorles(adattar);
                                break;
                            case 3:
                                Console.WriteLine("Bizonyítékok listázása");
                                b = new Bizonyitek(0, "", "", 0);
                                b.Bizonyiteklistazas(adattar);
                                break;
                            default:
                                Console.WriteLine("Érvénytelen választás. Kérem, válasszon újra.");
                                break;
                        }
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
            } while (true);

        }
    }
}
