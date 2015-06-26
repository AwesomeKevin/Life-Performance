using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenShark_Live_Performance
{
    public class Materiaal
    {
        //Field
        private string naam;

        //Propertie
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        //Constructor
        public Materiaal(string naam)
        {
            this.naam = naam;
        }
    }
}
