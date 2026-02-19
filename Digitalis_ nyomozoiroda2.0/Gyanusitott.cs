using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis__nyomozoiroda2._0
{
    internal class Gyanusitott
    {
        Szemely szemely;
        int gyanusitotsagiszint;
        string statusz;

        public Gyanusitott(Szemely szemely, int gyanusitotsagiszint, string statusz)
        {
            this.szemely = szemely;
            this.gyanusitotsagiszint = gyanusitotsagiszint;
            this.statusz = statusz;
        }

        public int Gyanusitotsagiszint { get => gyanusitotsagiszint; set => gyanusitotsagiszint = value; }
        public string Statusz { get => statusz; set => statusz = value; }
        internal Szemely Szemely { get => szemely; set => szemely = value; }

        public void Gyanusitotthozzaadas(Adattar adattar)
        {
            Console.WriteLine("Ki a gyanusított a személyek közül? ");
            string nev = Console.ReadLine();
            foreach (var item in adattar.Szemelyek)
            {
                if (item.Nev == nev)
                {
                    szemely = item;
                    break;
                }
            }
            Console.WriteLine("Milyen gyanúsítottsági szintet adsz meg? (1-10)");
            gyanusitotsagiszint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Milyen státuszt adsz meg? (pl. előzetes letartóztatás, szabadlábon védekezik, stb.)");
            statusz = Console.ReadLine();
            Gyanusitott gyanusitott = new Gyanusitott(szemely, gyanusitotsagiszint, statusz);
            adattar.Gyanusitottak.Add(gyanusitott);
            adattar.Szemelyek.Remove(szemely);

        }
        public void Gyanusitottitorles(Adattar adattar)
        {
            Console.WriteLine("Ki a törölni kívánt gyanusított? ");
            string nev = Console.ReadLine();
            Gyanusitott torlendo = adattar.Gyanusitottak.Find(g => g.Szemely.Nev == nev);
            if (torlendo != null)
            {
                adattar.Gyanusitottak.Remove(torlendo);
                Console.WriteLine("Gyanusított sikeresen törölve.");
            }
            else
            {
                Console.WriteLine("Nem található ilyen nevű gyanusított.");
            }
        }
    }
}
