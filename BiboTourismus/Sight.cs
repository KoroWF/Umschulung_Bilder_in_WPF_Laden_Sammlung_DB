using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Tourismus
{
    public class Sight
    {
        public int Sid { get; private set; }
        public string Sname { get; private set; }
        public string Sort { get; private set; }
        public string Sbeschreibung { get; private set; }
        public string Sbild { get; private set; }
        public Sight(int _sid,string _sname,string _sort ,string _beschreibung,string _bild)
        {
            Sid = _sid;
            Sname = _sname;
            Sort = _sort;
            Sbeschreibung = _beschreibung;
            Sbild = _bild;
        }
        public override string ToString()
        {
            return Sname +","+Sort;

        }
    }
}
