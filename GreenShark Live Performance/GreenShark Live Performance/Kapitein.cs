using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenShark_Live_Performance
{
    public class Kapitein : Medewerker
    {
        //Constructor
        public Kapitein(string naam, DateTime geboortedatum) : base(naam, geboortedatum)
        {

        }

        //Methodes
        //Deze methode moet een bestand wegschrijven met daarin een geselecteerd missierapport,
        // maar is nog niet klaar.
        public bool DraaiMissierapportageUit()
        {
            return false;
        }

        //Met deze methode kan een HOPE missie goedgekeurd worden,
        // maar is nog niet klaar.
        public bool KeurMissieGoed()
        {
            return false;
        }

        //Deze methode maakt een nieuw missierapport aan in de database,
        // maar is nog niet klaar.
        public bool VoerMissierapportageIn()
        {
            return false;
        }
    }
}
