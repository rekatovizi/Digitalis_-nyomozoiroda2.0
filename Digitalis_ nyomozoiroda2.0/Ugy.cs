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
    }
}
