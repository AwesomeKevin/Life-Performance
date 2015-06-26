using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenShark_Live_Performance
{
    public class Administrator : Medewerker
    {
        //Constructor
        public Administrator(string naam, DateTime geboortedatum) : base(naam, geboortedatum)
        {

        }

        //Methodes
        //Met deze methode kun je berekenen welke boot het dichtst bij de door jou ingevoerde locatie ligt,
        // maar deze is nog niet klaar.
        public Boot ZoekDichtstbijzijndeBoot()
        {
            Boot boot = new Boot("test", "snel", 10, 5);
            return boot;
        }

        //Deze methode voegt een missie toe in de database,
        // maar is nog niet klaar.
        public bool VoegMissieToe()
        {
            return false;
        }

        //Deze methode haalt alle missies op uit de database en zet ze in een lijst,
        // maar is nog niet klaar.
        public List<Missie> HaalMissiesOp()
        {
            List<Missie> missies = new List<Missie>();
            return missies;
        }

        //Deze methode wijzigt bepaalde gegevens van een missie in de database,
        // maar is nog niet klaar.
        public bool WijzigMissie()
        {
            return false;
        }

        //Deze methode verwijdert een missie uit de database,
        // maar is nog niet klaar.
        public bool VerwijderMissie()
        {
            return false;
        }

        //Deze methode moet een bestand wegschrijven met daarin een geselecteerd missierapport,
        // maar is nog niet klaar.
        public bool DraaiMissierapportageUit()
        {
            return false;
        }

        //Deze methode voegt een missieprofiel toe aan de database,
        // maar is nog niet klaar.
        public bool VoegMissieprofielToe()
        {
            return false;
        }

        //Deze methode haalt alle missieprofielen op uit de database en zet ze in een lijst,
        // maar is nog niet klaar.
        public List<Missieprofiel> HaalMissieprofielenOp()
        {
            List<Missieprofiel> missieprofielen = new List<Missieprofiel>();
            return missieprofielen;
        }

        //Deze methode wijzigt bepaalde gegevens van een missieprofiel in de database,
        // maar is nog niet klaar.
        public bool WijzigMissieprofiel()
        {
            return false;
        }

        //Deze methode verwijdert een missieprofiel uit de database,
        // maar is nog niet klaar.
        public bool VerwijderMissieprofiel()
        {
            return false;
        }

        //Deze methode voegt een medewerker toe aan de database,
        // maar is nog niet klaar.
        public bool VoegMedewerkerToe()
        {
            return false;
        }

        //Deze methode haalt alle medewerkers op uit de database en zet ze in een lijst,
        // maar is nog niet klaar.
        public List<Medewerker> HaalMedewerkersOp()
        {
            List<Medewerker> medewerkers = new List<Medewerker>();
            return medewerkers;
        }

        //Deze methode wijzigt bepaalde gegevens van een medewerker in de database,
        // maar is nog niet klaar.
        public bool WijzigMedewerker()
        {
            return false;
        }

        //Deze methode verwijdert een medewerker uit de database,
        // maar is nog niet klaar.
        public bool VerwijderMedewerker()
        {
            return false;
        }

        //Deze methode voegt een boot toe aan de database,
        // maar is nog niet klaar.
        public bool VoegBootToe()
        {
            return false;
        }

        //Deze methode haalt alle boten op uit de database en zet ze in een lijst,
        // maar is nog niet klaar.
        public List<Boot> HaalBotenOp()
        {
            List<Boot> boten = new List<Boot>();
            return boten;
        }

        //Deze methode wijzigt bepaalde gegevens van een boot in de database,
        // maar is nog niet klaar.
        public bool WijzigBoot()
        {
            return false;
        }

        //Deze methode verwijdert een Boot uit de database,
        // maar is nog niet klaar.
        public bool VerwijderBoot()
        {
            return false;
        }

        //Deze methode voegt een materiaal toe aan de database,
        // maar is nog niet klaar.
        public bool VoegMateriaalToe()
        {
            return false;
        }

        //Deze methode haalt al het materiaal op uit de database en zet ze in een lijst,
        // maar is nog niet klaar.
        public List<Materiaal> HaalMaterialenenOp()
        {
            List<Materiaal> materialen = new List<Materiaal>();
            return materialen;
        }

        //Deze methode wijzigt bepaalde gegevens van een materiaal in de database,
        // maar is nog niet klaar.
        public bool WijzigMateriaal()
        {
            return false;
        }

        //Deze methode verwijdert een materiaal uit de database,
        // maar is nog niet klaar.
        public bool VerwijderMateriaal()
        {
            return false;
        }
    }
}
