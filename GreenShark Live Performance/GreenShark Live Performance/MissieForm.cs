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
    public partial class MissieForm : Form
    {
        //Fields
        Databasekoppeling database;
        public MissieForm()
        {
            InitializeComponent();
            database = new Databasekoppeling();
        }

        private void MissieForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMaakAan_Click(object sender, EventArgs e)
        {
            if (tbNaam.Text != "")
            {
                if (tbLocatieX.Text != "")
                {
                    if (tbLocatieY.Text != "")
                    {
                        if (tbEinddatum.Text != "")
                        {
                            int missieID = database.VraagHoogsteMissieIDOp() + 1;
                            int hopeID = database.VraagHoogsteHOPEIDOp() + 1;
                            string naam = tbNaam.Text;
                            string begindatum = tbBegindatum.Text;
                            string einddatum = tbEinddatum.Text;
                            int locatieX = Convert.ToInt32(tbLocatieX.Text);
                            int locatieY = Convert.ToInt32(tbLocatieY.Text);
                            if (database.VoegMissieToe(missieID))
                            {
                                if (database.VoegHOPEToe(hopeID, naam, begindatum, einddatum, locatieX, locatieY))
                                {
                                    MessageBox.Show("HOPE missie aanmaken gelukt");
                                }
                                else
                                MessageBox.Show("HOPE missie aanmaken mislukt");
                            }
                            else
                            MessageBox.Show("Hope missie aanmaken mislukt");
                        }
                        else
                        {
                            int missieID = database.VraagHoogsteMissieIDOp() + 1;
                            int sinID = database.VraagHoogsteSINIDOp() + 1;
                            string naam = tbNaam.Text;
                            string begindatum = tbBegindatum.Text;
                            int locatieX = Convert.ToInt32(tbLocatieX.Text);
                            int locatieY = Convert.ToInt32(tbLocatieY.Text);
                            if (database.VoegMissieToe(missieID))
                            {
                                if (database.VoegSINToe(sinID, naam, begindatum, locatieX, locatieY))
                                {
                                    MessageBox.Show("SIN missie aanmaken gelukt");
                                }
                                else
                                MessageBox.Show("SIN missie aanmaken mislukt");
                            }
                            else
                            MessageBox.Show("SIN missie aanmaken mislukt");
                        }
                    }
                    else
                    MessageBox.Show("Voer een Y locatie in");
                }
                else
                MessageBox.Show("Voer een X locatie in");
            }
            else
            MessageBox.Show("Voer een naam in");
        }

        private void tbBegindatum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
