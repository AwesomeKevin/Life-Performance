using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenShark_Live_Performance
{
    public class Bioloog : Medewerker
    {
        //Constructor
        public Bioloog(string naam, string geboortedatum) : base(naam, geboortedatum)
        {

        }

        //Methodes
        //Deze methode voegt een meting toe in de database,
        // maar is nog niet klaar.
        public bool VoegMetingToe()
        {
            return false;
        }

        //Deze methode haalt alle metingen op uit de database en zet ze in een lijst,
        // maar is nog niet klaar.
        public List<Meting> HaalMetingenOp()
        {
            List<Meting> metingen = new List<Meting>();
            return metingen;
        }

        //Deze methode wijzigt bepaalde gegevens van een meting in de database,
        // maar is nog niet klaar.
        public bool WijzigMeting()
        {
            return false;
        }

        //Deze methode verwijdert een meting uit de database,
        // maar is nog niet klaar.
        public bool VerwijderMeting()
        {
            return false;
        }
    }
}
