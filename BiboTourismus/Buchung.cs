using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Tourismus
{
    public class Buchung
    {
        public int Bid { get; private set; }
        public string Kname { get; private set; }
        public string  Sname { get; private set; }
        public string Oname { get; private set; }
        public decimal Preis { get; private set; }
        public DateTime Datum { get; private set; }
        public bool Bezahlt { get; private set; }
        public Buchung(int _bid, string _kname , string _sname , string _oname,decimal _preis, DateTime _datum,bool _bezahlt)
        {
            Bid = _bid;
            Kname = _kname;
            Sname = _sname;
            Oname = _oname;
            Preis = _preis;
            Datum = _datum;
            Bezahlt = _bezahlt;
        }
    }
}
