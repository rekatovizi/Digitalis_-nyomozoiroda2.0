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
        string cim;
        public Szemely(string nev, int eletkor, string cim)
        {
            this.nev = nev;
            this.eletkor = eletkor;
            this.cim = cim;
        }
        public string Nev { get => nev; set => nev = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }
        public string Cim { get => cim; set => cim = value; }
    }
}
