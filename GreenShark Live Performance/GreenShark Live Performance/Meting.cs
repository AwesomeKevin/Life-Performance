using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenShark_Live_Performance
{
    public class Meting
    {
        //Fields
        private string datum;
        private int tijdstip;
        private int locatieX;
        private int locatieY;
        private int o2Niveau;
        private int co2Niveau;

        //Properties
        public string Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        public int Tijdstip
        {
            get { return tijdstip; }
            set { tijdstip = value; }
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

        public int O2Niveau
        {
            get { return o2Niveau; }
            set { o2Niveau = value; }
        }

        public int CO2Niveau
        {
            get { return co2Niveau; }
            set { co2Niveau = value; }
        }

        //Constructor
        public Meting(string datum, int tijdstip, int locatieX, int locatieY, int o2Niveau, int co2Niveau)
        {
            this.datum = datum;
            this.tijdstip = tijdstip;
            this.LocatieX = locatieX;
            this.locatieY = locatieY;
            this.o2Niveau = o2Niveau;
            this.co2Niveau = co2Niveau;
        }
    }
}
