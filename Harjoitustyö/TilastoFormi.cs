using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitustyö
{
    public partial class TilastoFormi : Form
    {
        public TilastoFormi(List<TietojenTalletusForm.Pelaaja> pelaajat)
        {
            InitializeComponent();
            foreach (TietojenTalletusForm.Pelaaja P in pelaajat)
            {
                lbPelaajat.Items.Add( "Nimi: " + P.nimi + " " + "Pelatut pelit: " + P.pelatutPelit.ToString() + " " + "Voitot: " + P.voitot.ToString() + " " + "Tappiot: " + P.tappiot.ToString() + " " + "Tasapelit: " + P.tasapelit);
            }
        }

        private void btnPoistu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
