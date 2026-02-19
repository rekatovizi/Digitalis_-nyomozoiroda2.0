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
    }
}
