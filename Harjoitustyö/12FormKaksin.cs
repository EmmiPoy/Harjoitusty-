using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Harjoitustyö
{
    public partial class Kaksin12Form : Form
    {

        Label ekaKlikkaus = null;

        Label tokaKlikkaus = null;

        Random rnd = new Random();

        Boolean pelaaja1 = true;
        int pisteet1 = 0;
        int pisteet2 = 0;
        int loydetytParit = 0;

        public int pelit1;
        public int pelit2;
        public int pelatutPelit1;
        public int voitot1;
        public int tappiot1;
        public int tasapelit1;
        public int pelatutPelit2;
        public int voitot2;
        public int tappiot2;
        public int tasapelit2;
        public int PelatutPelit1 { get { return pelatutPelit1; } }
        public int Voitot1 { get { return voitot1; } }
        public int Tappiot1 { get { return tappiot1; } }
        public int Tasapelit1 { get { return tasapelit1; } }
        public int Voitot2 { get { return voitot2; } }
        public int Tappiot2 { get { return tappiot2; } }
        public int Tasapelit2 { get { return tasapelit2; } }
        public int PelatutPelit2 { get { return pelatutPelit2; } }

        List<string> kuvakkeet = new List<string>()
        {
            "b", "b", "%", "%", "h", "h", "P", "P", "~", "~", "e", "e"
        };

        private void AsetaKuvatKortteihin()
        {
            
            foreach (Control control in tblHelppo.Controls)
            {
                Label kuvaLabel = control as Label;
                try
                {
                    if (kuvaLabel != null)
                    {
                        int randomNumero = rnd.Next(kuvakkeet.Count);
                        kuvaLabel.Text = kuvakkeet[randomNumero];
                        kuvaLabel.ForeColor = kuvaLabel.BackColor;
                        kuvakkeet.RemoveAt(randomNumero);

                    }
                }
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            }
            
        }
        public Kaksin12Form()
        {
            InitializeComponent();
            AsetaKuvatKortteihin();
            
        }

        public void lblHelppo_Click(object sender, EventArgs e)
            {


            if (timerHelppo.Enabled == true)
            {
                return;
            }

            Label klikattuLabel = sender as Label;

            if (tokaKlikkaus != null) //Ei voida klikata kolmatta korttia näkyviin
            {
                return;
                throw new Exception("Yritetään klikata kolmatta korttia");
            }
  

            if (klikattuLabel != null)
            {
                
                if (klikattuLabel.ForeColor == Color.White)
                    return;

                if (ekaKlikkaus == null){

                    ekaKlikkaus = klikattuLabel;
                    ekaKlikkaus.ForeColor = Color.White; //Ensimmäisen kortin klikkaus

                    return;
                }

                tokaKlikkaus = klikattuLabel;
                tokaKlikkaus.ForeColor = Color.White; // Toisen kortin klikkaus
                

                if (ekaKlikkaus.Text == tokaKlikkaus.Text)  //Korteissa samat kuvat ja vuoro pysyy pelaajalla
                {

                    ekaKlikkaus = null;             //asetetaan korteille null-arvot seuraavien korttien kääntämistä varten
                    tokaKlikkaus = null;
                    if (pelaaja1)                   // jos vuorossa oleva pelaaja on pelaaja1
                    {
                        pisteet1++;                 //kasvatetaan pelaaja 1:n piste- ja löydetyt parit-laskuria
                        loydetytParit++;
                        
                        tlsPelaaja1.Text = "Pelaaja1: " + pisteet1.ToString();   //Ilmoitetaan toolstripissä pelaajan senhetkinen pistemäärä
                        if (loydetytParit == 6)                                 //kun kaikki oikeat parit on löydetty, tarkastetaan onko kumpi pelaajista voittaja vai tuliko tasapwli
                        {
                            
                            if (pisteet1 > pisteet2)                        //jos pelaajan 1 pistelaskurin arvo on suurempi kuin pelaaja 2:sen.
                            {
                                voitot1++;                                  //pelaaja 1: sen voitto- ja pelatut pelit-laskuria kasvatetaan yhdellä, 
                                tappiot2++;                                 //kun taas pelaaja 2:n tappio- ja pelatut pelit-laskiria kasvatetaan yhdellä.
                                pelatutPelit1++;
                                pelatutPelit2++;

                                MessageBox.Show("Pelaaja1 voitti!");

                            }
                            else if (pisteet2 > pisteet1)                   //jos pelaajan 2 pistelaskurin arvo on suurempi kuin pelaaja 1:sen.
                            {
                                voitot2++;                                  //pelaaja 2: sen voitto- ja pelatut pelit-laskuria kasvatetaan yhdellä, 
                                tappiot1++;                                  //kun taas pelaaja 1:n tappio- ja pelatut pelit-laskiria kasvatetaan yhdellä.
                                pelatutPelit1++;
                                pelatutPelit2++;
                                MessageBox.Show("Pelaaja2 voitti!");

                            }

                            else if (pisteet1 == 3 && pisteet2 == 3)        //jos pelaajilla on saa määrä pisteitä = tasapeli
                            {
                                tasapelit1++;                               //molempien pelaajien tasapeli-laskureita ja pelatut pelit-laskur
                                tasapelit2++;
                                pelatutPelit1++;
                                pelatutPelit2++;
                                MessageBox.Show("Tasapeli!");
                            }
                        }
                    }
                    else
                    {
                        pisteet2++;                                         //korttien kuvat samat pelaajan 2 vuorolla --> pisteitä ja löydettyjä pareja kasvatetaan yhdellä
                        loydetytParit++;

                        tlsPelaaja2.Text = "Pelaaja2: "+ pisteet2.ToString();
                        if (loydetytParit == 6)                             //kun kaikki parit löydetty
                        {
                            
                            if (pisteet2 > pisteet1)                        //pelaaja 2 voittaa ja sen mukaan kasvatetaan molempien pelaajien laskureita
                            {
                                voitot2++;
                                tappiot1++;
                                pelatutPelit1++;
                                pelatutPelit2++;
                                MessageBox.Show("Pelaaja2 voitti!");
                               

                            }
                            else if (pisteet1 > pisteet2)                   //pelaaja 1 voittaa ja sen mukaan kasvatetaan molempien pelaajien laskureita
                            {
                                voitot1++;
                                tappiot2++;
                                pelatutPelit1++;
                                pelatutPelit2++;
                                MessageBox.Show("Pelaaja1 voitti!");
                            }

                            else if (pisteet1 == 3 && pisteet2 == 3)        //tasapeli ja kasvatetaan laskureita sen mukaan 
                            {
                                tasapelit1++;
                                tasapelit2++;
                                pelatutPelit1++;
                                pelatutPelit2++;

                                MessageBox.Show("Tasapeli!");
                                
                            }
                        }
                    }
                    return;
                }
                //jos korttien kuvat ei ole samat, vaihtuu pelaajan vuoro
                else if (ekaKlikkaus.Text != tokaKlikkaus.Text)
                {
                    try {
                    if (pelaaja1)
                    {
                        pelaaja1 = false;
                        tlsPelaajanVuoro.Text = "Pelaaja2:sen vuoro!";

                    }
                    else {
                        pelaaja1 = true;
                        tlsPelaajanVuoro.Text = "Pelaaja1:sen vuoro!";
                    }}
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                timerHelppo.Start();
            }

        }

        //Timerin asettaminen
        private void timerHelppo_Tick(object sender, EventArgs e)
        {
            timerHelppo.Stop();
            
            ekaKlikkaus.ForeColor = ekaKlikkaus.BackColor;
            tokaKlikkaus.ForeColor = tokaKlikkaus.BackColor;

            ekaKlikkaus = null;
            tokaKlikkaus = null;
            
            
        }


        //Siirtyminen pelaajan/pelaajien tietojen tallennukseen
        private void btnTallenna_Click(object sender, EventArgs e)
        {
            try { 
            TietojenTalletusForm fe = new TietojenTalletusForm(pelatutPelit1, voitot1, tappiot1, tasapelit1, pelatutPelit2, voitot2, tappiot2, tasapelit2);
            fe.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void btnUudelleen_Click(object sender, EventArgs e)
        {
            List<string> kuvakkeet = new List<string>()
        {
            "b", "b", "%", "%", "h", "h", "P", "P", "~", "~", "e", "e"
        };
            foreach (Control control in tblHelppo.Controls)
            {
                Label kuvaLabel = control as Label;
                try
                {
                    if (kuvaLabel != null)
                    {
                        int randomNumero = rnd.Next(kuvakkeet.Count);
                        kuvaLabel.Text = kuvakkeet[randomNumero];
                        kuvaLabel.ForeColor = kuvaLabel.BackColor;
                        kuvakkeet.RemoveAt(randomNumero);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            pisteet1 = 0;
            pisteet2 = 0;
            loydetytParit = 0;
            tlsPelaaja1.Text = "Pelaaja1: " + pisteet1.ToString();
            tlsPelaaja2.Text = "Pelaaja2: " + pisteet2.ToString();
            tlsPelaajanVuoro.Text = "Pelaaja1 aloittaa!";
            pelaaja1 = true;
            
        }
    }
}

