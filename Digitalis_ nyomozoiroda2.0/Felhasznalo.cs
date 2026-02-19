using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis__nyomozoiroda2._0
{
    internal class Felhasznalo
    {
        string nev;
        int azonosito;
        string szerepkor;

        public Felhasznalo(string nev, int azonosito, string szerepkor)
        {
            this.nev = nev;
            this.azonosito = azonosito;
            this.szerepkor = szerepkor;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Azonosito { get => azonosito; set => azonosito = value; }
        public string Szerepkor { get => szerepkor; set => szerepkor = value; }

        public string Szerepkorvalasztas()
        {
            Console.WriteLine("Kérem válassza ki a szerepkörét: ");
            Console.WriteLine("1. Nyomozó");
            Console.WriteLine("2. Vendég");
            string valasz = Console.ReadLine();
            switch (valasz)
            {
                case "1":
                    szerepkor = "Nyomozó";
                    return "Nyomozó";
                case "2":
                    return "Vendég";
                default:
                    Console.WriteLine("Érvénytelen választás, kérlek próbáld újra.");
                    return Szerepkorvalasztas();
            }
        }
    }
    
}
