using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis__nyomozoiroda2._0
{
    internal class Szemely
    {
        string nev;
        int eletkor;
        string megjegyzes;
        public Szemely(string nev, int eletkor, string megjegyzes)
        {
            this.nev = nev;
            this.eletkor = eletkor;
            this.megjegyzes = megjegyzes;
        }
        public string Nev { get => nev; set => nev = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }
        public string Cim { get => megjegyzes; set => megjegyzes = value; }

        public void Szemelyhozzaadas(Adattar adattar)
        {
            Console.WriteLine("Szeretnél új személyt hozzáadni? ");
            string valasz = Console.ReadLine();
            if (valasz.ToLower() == "igen")
            {
                Console.WriteLine("Kérem adja meg a személy nevét: ");
                string nev = Console.ReadLine();
                Console.WriteLine("Kérem adja meg a személy életkorát: ");
                int eletkor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kérlek adj megjegyzést a személyhez: ");
                string megjegyzes = Console.ReadLine();
                Szemely ujSzemely = new Szemely(nev, eletkor, megjegyzes);
                adattar.Szemelyek.Add(ujSzemely);
                Console.WriteLine("Személy sikeresen hozzáadva.");
            }
        }
        public void Szemelytorles(Adattar adattar)
        {
            Console.WriteLine("Szeretnél személyt törölni? ");
            string valasz = Console.ReadLine();
            if (valasz.ToLower() == "igen")
            {
                Console.WriteLine("Kérem adja meg a törölni kívánt személy nevét: ");
                string nev = Console.ReadLine();
                Szemely torlendo = adattar.Szemelyek.Find(s => s.Nev == nev);
                if (torlendo != null)
                {
                    adattar.Szemelyek.Remove(torlendo);
                    Console.WriteLine("Személy sikeresen törölve.");
                }
                else
                {
                    Console.WriteLine("Nem található személy a megadott névvel.");
                }
            }
        }
        public void Szemelylistazas(Adattar adattar)
        {
            Console.WriteLine("Személyek listája:");
            foreach (Szemely s in adattar.Szemelyek)
            {
                Console.WriteLine($"Név: {s.Nev}, Életkor: {s.Eletkor}, Cím: {s.Cim}");
            }
        }
    }

}
