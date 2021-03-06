﻿using System;
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
    public partial class Yksin36Form : Form
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
            "b", "b", "%", "%", "h", "h", "P", "P", "~", "~", "e", "e", "@", "@", "Y", "Y", "N", "N", "o", "o",
            "O", "O", "s", "s", "Z", "Z", "X", "X", "r", "r", "v", "v", "-", "-", "$", "$"
        };

        private void AsetaKuvatKortteihin()
        {

            foreach (Control control in tblVaikea.Controls)
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
        public Yksin36Form()
        {
            InitializeComponent();
            AsetaKuvatKortteihin();

        }

        public void lblVaikea_Click(object sender, EventArgs e)
        {


            if (timer1Vaikea.Enabled == true)
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

                if (ekaKlikkaus == null)
                {

                    ekaKlikkaus = klikattuLabel;
                    ekaKlikkaus.ForeColor = Color.White; //Ensimmäisen kortin klikkaus

                    return;
                }

                tokaKlikkaus = klikattuLabel;
                tokaKlikkaus.ForeColor = Color.White; // Toisen kortin klikkaus


                if (ekaKlikkaus.Text == tokaKlikkaus.Text)  //Korteissa samat kuvat
                {

                    ekaKlikkaus = null;                    //asetetaan korteille null-arvot seuraavien korttien kääntämistä varten
                    tokaKlikkaus = null;                   
                    loydetytParit++;                       //kasvatetaan pelaaja löydetyt parit-laskuria

                    tlsPelaaja.Text = "Löydetyt parit:" + loydetytParit.ToString();   //Ilmoitetaan toolstripissä pelaajan löydettyjen parien määrä
                        if (loydetytParit == 18)                                       //kun kaikki oikeat parit on löydetty, ilmoitetaan siitä pelaajalle
                        {
                            voitot1++;
                            pelatutPelit1++;
                            MessageBox.Show("Löysit kaikki parit, onnea!");

                        }

                    return;
                }
                
                timer1Vaikea.Start();
            }

        }

        //Timerin asettaminen
        private void timerVaikea_Tick(object sender, EventArgs e)
        {
            timer1Vaikea.Stop();

            ekaKlikkaus.ForeColor = ekaKlikkaus.BackColor;
            tokaKlikkaus.ForeColor = tokaKlikkaus.BackColor;

            ekaKlikkaus = null;
            tokaKlikkaus = null;


        }


        //Siirtyminen pelaajan/pelaajien tietojen tallennukseen
        private void btnTallenna_Click(object sender, EventArgs e)
        {
            try
            {
                TietojenTalletusForm fe = new TietojenTalletusForm(pelatutPelit1, voitot1, tappiot1, tasapelit1, pelatutPelit2, voitot2, tappiot2, tasapelit2);
                fe.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void btnUudestaan_Click(object sender, EventArgs e)
        {
            List<string> kuvakkeet = new List<string>()
        {
            "b", "b", "%", "%", "h", "h", "P", "P", "~", "~", "e", "e", "@", "@", "Y", "Y", "N", "N", "o", "o",
            "O", "O", "s", "s", "Z", "Z", "X", "X", "r", "r", "v", "v", "-", "-", "$", "$"
        };
            foreach (Control control in tblVaikea.Controls)
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
            loydetytParit = 0;
            tlsPelaaja.Text = "Löydetyt parit:" + loydetytParit.ToString();

        }
    }
}

