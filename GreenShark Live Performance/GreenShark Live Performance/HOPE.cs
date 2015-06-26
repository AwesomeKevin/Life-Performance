using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenShark_Live_Performance
{
    public class HOPE : Missie
    {
        //Field
        private DateTime einddatum;

        //Propertie
        public DateTime Einddatum
        {
            get { return einddatum; }
            set { einddatum = value; }
        }

        //Constructor
        public HOPE(string naam, DateTime begindatum, DateTime einddatum, int locatieX, int locatieY) : base(naam, begindatum, locatieX, locatieY)
        {
            
        }
    }
}
