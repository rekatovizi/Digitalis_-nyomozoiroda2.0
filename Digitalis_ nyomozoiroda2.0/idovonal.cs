using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis__nyomozoiroda2._0
{
    internal class Idovonal
    {
        DateTime DateTime;
        string esemeny;

        public Idovonal(DateTime dateTime, string esemeny)
        {
            DateTime = dateTime;
            this.esemeny = esemeny;
        }

        public DateTime DateTime1 { get => DateTime; set => DateTime = value; }
        public string Esemeny { get => esemeny; set => esemeny = value; }
    }
}
