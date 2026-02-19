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
        public Tanu(Szemely szemely, string vallomas, DateTime vallomasIdeje    )
        {
            this.szemely = szemely;
            this.vallomas = vallomas;
            this.vallomasIdeje = vallomasIdeje;
        }
        public string Vallomas { get => vallomas; set => vallomas = value; }
        public DateTime VallomasIdeje { get => vallomasIdeje; set => vallomasIdeje = value; }
        internal Szemely Szemely { get => szemely; set => szemely = value; }
    }
}
