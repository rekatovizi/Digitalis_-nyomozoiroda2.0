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
    }
}
