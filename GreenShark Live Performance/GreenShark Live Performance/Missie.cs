using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenShark_Live_Performance
{
    public class Missie
    {
        //Fields
        private string naam;
        private string begindatum;
        private int locatieX;
        private int locatieY;

        //Properties
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public string Begindatum
        {
            get { return begindatum; }
            set { begindatum = value; }
        }

        public int LocatieX
        {
            get { return locatieX; }
            set { locatieX = value; }
        }

        public int LocatieY
        {
            get { return locatieY; }
            set { locatieY = value; }
        }

        //Constructor
        public Missie(string naam, string begindatum, int locatieX, int locatieY)
        {
            this.naam = naam;
            this.begindatum = begindatum;
            this.locatieX = locatieX;
            this.locatieY = locatieY;
        }
    }
}
