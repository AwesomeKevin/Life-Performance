using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenShark_Live_Performance
{
    public class Politie : Medewerker
    {
        //Constructor
        public Politie(string naam, DateTime geboortedatum) : base(naam, geboortedatum)
        {

        }

        //Methodes
        //Deze methode voegt een incident toe aan de database,
        // maar is nog niet klaar.
        public bool VoegIncidentToe()
        {
            return false;
        }

        //Deze methode haalt alle incidenten op uit de database en zet ze in een lijst,
        // maar is nog niet klaar.
        public List<Incident> HaalIncidentenOp()
        {
            List<Incident> incidenten = new List<Incident>();
            return incidenten;
        }

        //Deze methode wijzigt bepaalde gegevens van een incident in de database,
        // maar is nog niet klaar.
        public bool WijzigIncident()
        {
            return false;
        }

        //Deze methode verwijdert een incident uit de database,
        // maar is nog niet klaar.
        public bool VerwijderIncident()
        {
            return false;
        }
    }
}
