using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Tourismus
{
    public class Tour
    {
        public int Tid { get; private set; }
        public string Sname { get; private set; }
        public string Oname { get; private set; }
        public decimal Preis { get; private set; }
        public DateTime Datum { get; private set; }
         public Tour(int _tid, string _sname, string _oname, decimal _Preis,DateTime _datum)
        {
            Tid = _tid;
            Sname = _sname;
            Oname = _oname;
            Preis = _Preis;
            Datum = _datum;
        }

    }
}
