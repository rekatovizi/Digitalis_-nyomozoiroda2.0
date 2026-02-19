using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis__nyomozoiroda2._0
{
    internal class Tanu
    {
        Szemely szemely;
        string vallomas;
        DateTime vallomasIdeje;
        public Tanu(Szemely szemely, string vallomas, DateTime vallomasIdeje)
        {
            this.szemely = szemely;
            this.vallomas = vallomas;
            this.vallomasIdeje = vallomasIdeje;
        }
        public string Vallomas { get => vallomas; set => vallomas = value; }
        public DateTime VallomasIdeje { get => vallomasIdeje; set => vallomasIdeje = value; }
        internal Szemely Szemely { get => szemely; set => szemely = value; }

        public void Tanufelvetel(Adattar adattar)
        {
            Console.WriteLine("Ki a tanú a személyek közül? ");
            string nev = Console.ReadLine();
            foreach (var item in adattar.Szemelyek)
            {
                if (item.Nev == nev)
                {
                    szemely = item;
                    break;
                }
            }
            Console.WriteLine("Milyen vallomást ad meg? ");
            vallomas = Console.ReadLine();
            Console.WriteLine("Mikor adta a vallomást? (ÉÉÉÉ-HH-NN)");
            vallomasIdeje = Convert.ToDateTime(Console.ReadLine());
            Tanu tanu = new Tanu(szemely, vallomas, vallomasIdeje);
            adattar.Tanuk.Add(tanu);
        }

        public void Tanutorles(Adattar adattar)
        {
            Console.WriteLine("Ki a törölni kívánt tanú? ");
            string nev = Console.ReadLine();
            Tanu torlendo = adattar.Tanuk.Find(t => t.Szemely.Nev == nev);
            if (torlendo != null)
            {
                adattar.Tanuk.Remove(torlendo);
                Console.WriteLine("Tanú sikeresen törölve.");
            }
            else
            {
                Console.WriteLine("Nem található ilyen nevű tanú.");
            }
        }
    }
}
