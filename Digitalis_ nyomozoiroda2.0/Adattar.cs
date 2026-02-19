using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis__nyomozoiroda2._0
{
    internal class Adattar
    {
        List<Ugy> ugyek;
        List<Szemely> szemelyek;
        List<Bizonyitek> bizonyitekok;
        List<Felhasznalo> felhasznalok;

        public Adattar(List<Ugy> ugyek, List<Szemely> szemelyek, List<Bizonyitek> bizonyitekok, List<Felhasznalo> felhasznalok)
        {
            this.ugyek = ugyek;
            this.szemelyek = szemelyek;
            this.bizonyitekok = bizonyitekok;
            this.felhasznalok = felhasznalok;
        }

        internal List<Ugy> Ugyek { get => ugyek; set => ugyek = value; }
        internal List<Szemely> Szemelyek { get => szemelyek; set => szemelyek = value; }
        internal List<Bizonyitek> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
        internal List<Felhasznalo> Felhasznalok { get => felhasznalok; set => felhasznalok = value; }
    }
}
