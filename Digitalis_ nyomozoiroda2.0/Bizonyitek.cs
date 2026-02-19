using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis__nyomozoiroda2._0
{
    internal class Bizonyitek
    {
        int bizonyitekAzonosito;
        string tipus;
        string leiras;
        int megbizhatosagiszint;
        

        public Bizonyitek(int bizonyitekAzonosito, string tipus, string leiras, int megbizhatosagiszint)
        {
            this.bizonyitekAzonosito = bizonyitekAzonosito;
            this.tipus = tipus;
            this.leiras = leiras;
            this.megbizhatosagiszint = megbizhatosagiszint;
            
        }

        public int BizonyitekAzonosito { get => bizonyitekAzonosito; set => bizonyitekAzonosito = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public int Megbizhatosagiszint { get => megbizhatosagiszint; set => megbizhatosagiszint = value; }

        string valasz;
        public void Bizonyitekhozzaadas(Adattar adattar)
        {
            Console.WriteLine("Szeretnél új bizonyítékot hozzáadni? ");
            valasz = Console.ReadLine();
            if (valasz.ToLower() == "igen")
            {
                Console.WriteLine("Kérem adja meg a bizonyíték azonosítóját: ");
                int azonosito = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kérem adja meg a bizonyíték típusát: ");
                string tipus = Console.ReadLine();
                Console.WriteLine("Kérem adja meg a bizonyíték leírását: ");
                string leiras = Console.ReadLine();
                Console.WriteLine("Kérem adja meg a bizonyíték megbízhatósági szintjét (1-10): ");
                int megbizhatosagiszint = Convert.ToInt32(Console.ReadLine());
                Bizonyitek ujBizonyitek = new Bizonyitek(azonosito, tipus, leiras, megbizhatosagiszint);
                adattar.Bizonyitekok.Add(ujBizonyitek);
                Console.WriteLine("Bizonyíték sikeresen hozzáadva.");
            }
        }
        public void Bizonyitektorles(Adattar adattar)
        {
            Console.WriteLine("Szeretnél bizonyítékot törölni? ");
            valasz = Console.ReadLine();
            if (valasz.ToLower() == "igen")
            {
                Console.WriteLine("Kérem adja meg a törölni kívánt bizonyíték azonosítóját: ");
                int azonosito = Convert.ToInt32(Console.ReadLine());
                Bizonyitek torlendo = adattar.Bizonyitekok.Find(b => b.BizonyitekAzonosito == azonosito);

                if (torlendo != null)
                {
                    adattar.Bizonyitekok.Remove(torlendo);
                    Console.WriteLine("A bizonyíték sikeresen törölve.");
                }
                else
                {
                    Console.WriteLine("Nem található ilyen azonosítójú bizonyíték.");
                }
            }
        }
        public void Bizonyiteklistazas(Adattar adattar)
        {
            
            foreach (Bizonyitek b in adattar.Bizonyitekok)
            {
                Console.WriteLine($"Azonosító: {b.BizonyitekAzonosito}, Típus: {b.Tipus}, Leírás: {b.Leiras}, Megbízhatósági szint: {b.Megbizhatosagiszint}");
            }
            
        }
    }
}
