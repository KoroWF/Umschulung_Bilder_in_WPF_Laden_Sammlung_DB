using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Tourismus
{
    public class Organiser
    {
        public int Oid { get; private set; }
        public string Oname { get; private set; }
        public Organiser(int _Oid, string _Oname)
        {
            Oid = _Oid;
            Oname = _Oname;
        }
    }
}
