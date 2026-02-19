using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis__nyomozoiroda2._0
{
    internal class Idovonal
    {
        DateTime DateTime;
        string esemeny;

        public Idovonal(DateTime dateTime, string esemeny)
        {
            DateTime = dateTime;
            this.esemeny = esemeny;
        }

        public DateTime DateTime1 { get => DateTime; set => DateTime = value; }
        public string Esemeny { get => esemeny; set => esemeny = value; }


        public void Idovonalhozzaadas(Adattar adattar)
        {
            Console.WriteLine("Szeretnél új eseményt hozzáadni az idővonalhoz? ");
            string valasz = Console.ReadLine();
            if (valasz.ToLower() == "igen")
            {
                Console.WriteLine("Kérem adja meg az esemény dátumát (ÉÉÉÉ-HH-NN): ");
                DateTime datum = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Kérem adja meg az esemény leírását: ");
                string leiras = Console.ReadLine();
                Idovonal ujEsemeny = new Idovonal(datum, leiras);
                adattar.Idovonal.Add(ujEsemeny);
                Console.WriteLine("Esemény sikeresen hozzáadva az idővonalhoz.");
            }
        }
        public void Idovonaltorles(Adattar adattar)
        {
            Console.WriteLine("Szeretnél eseményt törölni az idővonalról? ");
            string valasz = Console.ReadLine();
            if (valasz.ToLower() == "igen")
            {
                Console.WriteLine("Kérem adja meg a törölni kívánt esemény dátumát (ÉÉÉÉ-HH-NN): ");
                DateTime datum = Convert.ToDateTime(Console.ReadLine());
                Idovonal torlendo = adattar.Idovonal.Find(e => e.DateTime1 == datum);
                if (torlendo != null)
                {
                    adattar.Idovonal.Remove(torlendo);
                    Console.WriteLine("Esemény sikeresen törölve az idővonalról.");
                }
                else
                {
                    Console.WriteLine("Nem található esemény a megadott dátummal.");
                }
            }
        }
        public void Idovonalmegjelenites(Adattar adattar)
        {
            Console.WriteLine("Idővonal eseményei:");
            foreach (Idovonal e in adattar.Idovonal)
            {
                Console.WriteLine($"{e.DateTime1.ToString("yyyy-MM-dd")}: {e.Esemeny}");
            }
        }
    }

}
