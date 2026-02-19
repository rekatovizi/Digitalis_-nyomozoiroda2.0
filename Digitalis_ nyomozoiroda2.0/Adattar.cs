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
        List<Idovonal> idovonal;

        public Adattar(List<Ugy> ugyek, List<Szemely> szemelyek, List<Bizonyitek> bizonyitekok, List<Felhasznalo> felhasznalok, List<Idovonal> idovonal )
        {
            this.ugyek = ugyek;
            this.szemelyek = szemelyek;
            this.bizonyitekok = bizonyitekok;
            this.felhasznalok = felhasznalok;
            this.idovonal = idovonal;
        }

        internal List<Ugy> Ugyek { get => ugyek; set => ugyek = value; }
        internal List<Szemely> Szemelyek { get => szemelyek; set => szemelyek = value; }
        internal List<Bizonyitek> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
        internal List<Felhasznalo> Felhasznalok { get => felhasznalok; set => felhasznalok = value; }
        internal List<Idovonal> Idovonal { get => idovonal; set => idovonal = value; }
    }
}
