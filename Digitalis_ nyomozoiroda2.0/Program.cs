namespace Digitalis__nyomozoiroda2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adattar adattar = new Adattar(new List<Ugy>(), new List<Szemely>(), new List<Bizonyitek>(), new List<Felhasznalo>(), new List<Idovonal>(), new List<Tanu>(), new List<Gyanusitott>() );
            do
            {
                int valasztas = 0;
                int valasz =0;
                Console.WriteLine("1 Ügyek kezelése\r\n2 Személyek kezelése\r\n3 Bizonyítékok kezelése\r\n4 Idővonal megtekintése\r\n5 Elemzés / döntések\r\n6 Kilépés");
                valasztas = Convert.ToInt32(Console.ReadLine());
                Ugy u = new Ugy(0, "", "", "");
                Szemely s = new Szemely("", 0, "");
                Gyanusitott g = new Gyanusitott(s, 0, "");
                Tanu t = new Tanu(s, "", DateTime.Now);
                Bizonyitek b = new Bizonyitek(0, "", "", 0);
                Donteshozo d = new Donteshozo();
                switch (valasztas)
                {

                    case 1:
                        Console.WriteLine("1 ügy hozzáadása\r\n2 Ügy törlése\r\n3 Ügyek listázása\r\n4 Ügy állapotváltoztatása\r\n5 érintett hozzáadása\r\n6 érintett törlése\r\n7 érintett bizonyíték hozzáadása\r\n8 érintett bizonyíték törlése");
                        valasz = Convert.ToInt32(Console.ReadLine());
                        

                        switch (valasz)
                        {
                            case 1: u.Ugyhozzaadas(adattar); break;
                            case 2: u.Ugytorles(adattar); break;
                            case 3: u.Ugylistazas(adattar); break;
                            case 4: u.Ugyallapotvaltoztatas(adattar); break;
                            case 5: u.Ugyszemelyhozzaadas(adattar); break;
                            case 6: u.Ugyszemelytorles(adattar); break;
                            case 7: u.Ugybizonyitekhozzaadas(adattar); break;
                            case 8: u.Ugybizonyitektorles(adattar); break;
                            default: Console.WriteLine("Érvénytelen választás."); break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("1 szemely hozzáadása\r\n2 személy törlése\r\n3 személyek listázása\r\n4 gyanusított hozzáadása\r\n5 gyanusított törlése\r\n6 gyanusítottak listázása\r\n7 tanu huzzáadása\r\n8 tanu törlése\r\n9 tanuk listázása");
                        valasz = Convert.ToInt32(Console.ReadLine());
                        
                        switch (valasz)
                        {
                            case 1: s.Szemelyhozzaadas(adattar); break;
                            case 2: s.Szemelytorles(adattar); break;
                            case 3: s.Szemelylistazas(adattar); break;
                            case 4:
                                s.Szemelylistazas(adattar);
                                g.Gyanusitotthozzaadas(adattar); break;
                            case 5: g.Gyanusitottitorles(adattar); break;
                            case 6: g.Gyanusitottlistazas(adattar); break;
                            case 7: t.Tanufelvetel(adattar); break;
                            case 8: t.Tanutorles(adattar); break;
                            case 9: t.Tanulistazas(adattar); break;
                            default: Console.WriteLine("Érvénytelen választás."); break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("1 bizonyíték hozzáadása\r\n2 bizonyíték törlése \r\n3 bizonyítékok listázása");
                        valasz = Convert.ToInt32(Console.ReadLine());
                        

                        switch (valasz)
                        {
                            case 1: b.Bizonyitekhozzaadas(adattar); break;
                            case 2: b.Bizonyitektorles(adattar); break;
                            case 3: b.Bizonyiteklistazas(adattar); break;
                            default: Console.WriteLine("Érvénytelen választás."); break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("1 esemény hozzáadása\r\n 2 esemény törlése\r\n 3 események megtekintése");
                        valasz = Convert.ToInt32(Console.ReadLine());
                        Idovonal i = new Idovonal(DateTime.Now, "");
                        switch (valasz)
                        {
                            case 1: i.Idovonalhozzaadas(adattar); break;
                            case 2: i.Idovonaltorles(adattar); break;
                            case 3: i.Idovonalmegjelenites(adattar); break;
                            default: Console.WriteLine("Érvénytelen választás."); break;
                        }

                        break;
                    case 5:
                        Console.WriteLine("Elemzés / döntések");
                        g.Gyanusitottlistazas(adattar);
                        Console.WriteLine("Válassz egy gyanusítotat (sorszám)");
                        valasz = Convert.ToInt32(Console.ReadLine());
                        b.Bizonyiteklistazas(adattar);
                        Console.WriteLine("Válassz egy bizonyítékot (sorszám)");
                        int valasz2 = Convert.ToInt32(Console.ReadLine());
                        d.Donteshozas(adattar.Gyanusitottak[valasz - 1], adattar.Bizonyitekok[valasz2 - 1]);
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
