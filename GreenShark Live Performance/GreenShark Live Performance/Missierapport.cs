using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenShark_Live_Performance
{
    public class Missierapport
    {
        //Fields
        private Missie missie;
        private string verslag;
        private Incident incident;
        private Meting meting;

        //Properties
        public Missie Missie
        {
            get { return missie; }
            set { missie = value; }
        }

        public string Verslag
        {
            get { return verslag; }
            set { verslag = value; }
        }

        public Incident Incident
        {
            get { return incident; }
            set { incident = value; }
        }

        public Meting Meting
        {
            get { return meting; }
            set { meting = value; }
        }

        //Constructor
        public Missierapport(Missie missie, string verslag, Incident incident, Meting meting)
        {
            this.missie = missie;
            this.verslag = verslag;
            this.incident = incident;
            this.meting = meting;
        }
    }
}
