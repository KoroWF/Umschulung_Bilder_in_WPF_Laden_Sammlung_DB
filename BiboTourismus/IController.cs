using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Tourismus
{
  
        public interface IController
        {
        Sight[] AllSight();
        Sight [] AllSight(string _name);
        Sight GetSight(int _id);
        Organiser[] AllOrga();
        Organiser GetOrga(int id);
        Tour[] AllTour();
        Tour[] AllTour(string _sight);
        Buchung[] AllBuchung();
        Buchung GetBuchung(string name);
        Kunde Insertkunde(string name);


        }
    
}
