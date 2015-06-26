using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenShark_Live_Performance
{
    public class Boot
    {
        //Fields
        private string naam;
        private string type;
        private int maximumSnelheid;
        private int maximumAantalPersonen;

        //Properties
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int MaximumSnelheid
        {
            get { return maximumSnelheid; }
            set { maximumSnelheid = value; }
        }

        public int MaximumAantalPersonen
        {
            get { return maximumAantalPersonen; }
            set { maximumAantalPersonen = value; }
        }

        //Constructor
        public Boot(string naam, string type, int maximumSnelheid, int maximumAantalPersonen)
        {
            this.naam = naam;
            this.type = type;
            this.maximumSnelheid = maximumSnelheid;
            this.maximumAantalPersonen = maximumAantalPersonen;
        }
    }
}
