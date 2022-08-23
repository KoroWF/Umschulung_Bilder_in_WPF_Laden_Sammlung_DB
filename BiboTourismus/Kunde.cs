using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Tourismus
{
   public class Kunde
    {
        public int Kid { get; private set; }
        public string Kname { get; private set; }
        public Kunde(int _kid, string _kname)
        {
            Kid = _kid;
            Kname = _kname;
            
        }
    }
}
