using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis__nyomozoiroda2._0
{
    internal class Ugy
    {
        int ugyAzonosito;
        string cim;
        string leiras;
        string allapot;
        List<Szemely> szemelyek;
        List<Bizonyitek> bizonyitekok;

        public Ugy(List<Szemely> szemelyek, List<Bizonyitek> bizonyitekok)
        {
            this.szemelyek = szemelyek;
            this.bizonyitekok = bizonyitekok;
        }
        public Ugy(int ugyAzonosito, string cim, string leiras, string allapot)
        {
            this.ugyAzonosito = ugyAzonosito;
            this.cim = cim;
            this.leiras = leiras;
            this.allapot = allapot;
        }

        public int UgyAzonosito { get => ugyAzonosito; set => ugyAzonosito = value; }
        public string Cim { get => cim; set => cim = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public string Allapot { get => allapot; set => allapot = value; }
        internal List<Szemely> Szemelyek { get => szemelyek; set => szemelyek = value; }
        internal List<Bizonyitek> Bizonyitekek { get => bizonyitekok; set => bizonyitekok = value; }

        public void Ugyhozzaadas(Adattar adattar)
        {
            Console.WriteLine("Szeretnél új ügyet hozzáadni? ");
            string valasz = Console.ReadLine();
            if (valasz.ToLower() == "igen")
            {
                Console.WriteLine("Kérem adja meg az ügy azonosítóját: ");
                int azonosito = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kérem adja meg az ügy címét: ");
                string cim = Console.ReadLine();
                Console.WriteLine("Kérem adja meg az ügy leírását: ");
                string leiras = Console.ReadLine();
                Console.WriteLine("Kérem adja meg az ügy állapotát: ");
                string allapot = Console.ReadLine();
                Ugy ujUgy = new Ugy(azonosito, cim, leiras, allapot);
                adattar.Ugyek.Add(ujUgy);
                Console.WriteLine("Ügy sikeresen hozzáadva.");
            }
        }
        public void Ugytorles(Adattar adattar)
        {
            Console.WriteLine("Szeretnél ügyet törölni? ");
            string valasz = Console.ReadLine();
            if (valasz.ToLower() == "igen")
            {
                Console.WriteLine("Kérem adja meg a törölni kívánt ügy azonosítóját: ");
                int azonosito = Convert.ToInt32(Console.ReadLine());
                Ugy torlendo = adattar.Ugyek.Find(u => u.UgyAzonosito == azonosito);
                if (torlendo != null)
                {
                    adattar.Ugyek.Remove(torlendo);
                    Console.WriteLine("Ügy sikeresen törölve.");
                }
                else
                {
                    Console.WriteLine("Nem található ilyen azonosítóval rendelkező ügy.");
                }
            }
        }
        public void Ugylistazas(Adattar adattar)
        {
            Console.WriteLine("Ügyek listázása:");
            foreach (Ugy ugy in adattar.Ugyek)
            {
                Console.WriteLine($"Azonosító: {ugy.UgyAzonosito}, Cím: {ugy.Cim}, Leírás: {ugy.Leiras}, Állapot: {ugy.Allapot}");
            }
        }
        
        public void Ugyallapotvaltoztatas(Adattar adattar)
        {
            Console.WriteLine("Szeretnél ügy állapotát megváltoztatni? ");
            string valasz = Console.ReadLine();
            if (valasz.ToLower() == "igen")
            {
                Console.WriteLine("Kérem adja meg a módosítani kívánt ügy azonosítóját: ");
                int azonosito = Convert.ToInt32(Console.ReadLine());
                Ugy modositando = adattar.Ugyek.Find(u => u.UgyAzonosito == azonosito);
                if (modositando != null)
                {
                    Console.WriteLine("Kérem adja meg az új állapotot: ");
                    string ujAllapot = Console.ReadLine();
                    modositando.Allapot = ujAllapot;
                    Console.WriteLine("Ügy állapota sikeresen megváltoztatva.");
                }
                else
                {
                    Console.WriteLine("Nem található ilyen azonosítóval rendelkező ügy.");
                }
            }

        }
    }
}
