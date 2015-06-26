using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenShark_Live_Performance
{
    public partial class KeuzeForm : Form
    {
        public KeuzeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPersoneel_Click(object sender, EventArgs e)
        {
            var personeel = new PersoneelForm();
            personeel.Show();
        }

        private void btnMissies_Click(object sender, EventArgs e)
        {
            var missies = new MissieForm();
            missies.Show();
        }

        private void btnBoten_Click(object sender, EventArgs e)
        {
            var boten = new BotenForm();
            boten.Show();
        }

        private void btnMateriaal_Click(object sender, EventArgs e)
        {
            var materiaal = new MateriaalForm();
            materiaal.Show();
        }

        private void btnRapportages_Click(object sender, EventArgs e)
        {
            var rapportages = new RapportageForm();
            rapportages.Show();
        }

        private void btnProfielen_Click(object sender, EventArgs e)
        {
            var profielen = new MissieProfielForm();
            profielen.Show();
        }

        private void btnMetingen_Click(object sender, EventArgs e)
        {
            var metingen = new MetingForm();
            metingen.Show();
        }

        private void btnIncidenten_Click(object sender, EventArgs e)
        {
            var incidenten = new IncidentForm();
            incidenten.Show();
        }
    }
}
