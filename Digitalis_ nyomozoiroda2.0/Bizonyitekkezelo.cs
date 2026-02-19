using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis__nyomozoiroda2._0
{
    internal class Bizonyitekkezelo
    {
        List<Bizonyitek> bizonyitekok;
        public Bizonyitekkezelo()
        {
            bizonyitekok = new List<Bizonyitek>();
        }
        public void BizonyitekHozzaadasa(Bizonyitek bizonyitek)
        {
            bizonyitekok.Add(bizonyitek);
        }
        public void BizonyitekTorlese(Bizonyitek bizonyitek)
        {
            bizonyitekok.Remove(bizonyitek);
        }
        public List<Bizonyitek> BizonyitekekLekerdezese()
        {
            return bizonyitekok;
        }
    }
}
