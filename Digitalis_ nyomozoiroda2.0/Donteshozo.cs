using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis__nyomozoiroda2._0
{
    internal class Donteshozo
    {
        public void Donteshozas(Gyanusitott g, Bizonyitek b)
        {
            if (b.Megbizhatosagiszint > 3)
            {
                g.Gyanusitotsagiszint += 20;

            }
            else if (b.Megbizhatosagiszint > 1)
            {
                g.Gyanusitotsagiszint += 10;

            }
            if (g.Gyanusitotsagiszint > 80)
            {
                Console.WriteLine("Figyelem veszélyes bűnöző");
            }
        }   
    }
}
