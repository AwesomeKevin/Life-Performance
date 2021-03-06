﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenShark_Live_Performance
{
    public class Incident
    {
        //Fields
        private string informatie;
        private string datum;
        private int tijdstip;

        //Properties
        public string Informatie
        {
            get { return informatie; }
            set { informatie = value; }
        }

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

        //Constructor
        public Incident(string informatie, string datum, int tijdstip)
        {
            this.informatie = informatie;
            this.datum = datum;
            this.tijdstip = tijdstip;
        }
    }
}
