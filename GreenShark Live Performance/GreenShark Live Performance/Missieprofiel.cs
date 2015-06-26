using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenShark_Live_Performance
{
    public class Missieprofiel
    {
        //Fields
        private string naam;
        private Materiaal  materiaal;
        private Medewerker bemanning;
        private Boot boot;

        //Properties
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public Materiaal Materiaal
        {
            get { return materiaal; }
            set { materiaal = value; }
        }

        public Medewerker Bemanning
        {
            get { return bemanning; }
            set { bemanning = value; }
        }

        public Boot Boot
        {
            get { return boot; }
            set { boot = value; }
        }

        //Constructor
        public Missieprofiel(string naam, Materiaal materiaal, Medewerker bemanning, Boot boot)
        {
            this.naam = naam;
            this.materiaal = materiaal;
            this.bemanning = bemanning;
            this.boot = boot;
        }
    }
}
