using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenShark_Live_Performance
{
    public class Medewerker
    {
        //Fields
        private string naam;
        private string geboortedatum;

        //Properties
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public string Geboortedatum
        {
            get { return geboortedatum; }
            set { geboortedatum = value; }
        }

        //Constructor
        public Medewerker(string naam, string geboortedatum)
        {
            this.naam = naam;
            this.geboortedatum = geboortedatum;
        }
    }
}
