using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Harjoitustyö
{
    public partial class TietojenTalletusForm : Form
    {

        //Pelaaja-tietueen alustaminen
        public struct Pelaaja
        {
            public string nimi;
            public int pelatutPelit;
            public int voitot;
            public int tappiot;
            public int tasapelit;
            public string Nimi { get { return nimi; } }
            public int Voitot { get { return voitot; } }
            public int Tappiot { get { return tappiot; } }
            public int Tasapelit { get { return tasapelit; } }
            public int PelatutPelit { get { return pelatutPelit; } }

        }

        public List<Pelaaja> pelaajat;

        //Tietojen välittäminen Helppoformilta tämän formin käyttöön
        public TietojenTalletusForm(int pelaajan1Pelit, int pelaajan1Voitot, int pelaajan1Tappiot, int pelaajan1Tasapelit, int pelaajan2Pelit, int pelaajan2Voitot, int pelaajan2Tappiot, int pelaajan2Tasapelit)
        {
           
            InitializeComponent();
            try { 
            label1.Text = pelaajan1Pelit.ToString();
            label2.Text = pelaajan1Voitot.ToString();
            label5.Text = pelaajan1Tappiot.ToString();
            label4.Text = pelaajan1Tasapelit.ToString();
            label6.Text = pelaajan2Pelit.ToString();
            label3.Text = pelaajan2Voitot.ToString();
            label7.Text = pelaajan2Tappiot.ToString();
            label8.Text = pelaajan2Tasapelit.ToString();

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            dgPelaajat.DataSource = pelaajat;

            try { 
            //Jos tiedosto jo esiintyy, tuodaan siinä oleva tieto datagridviewiin
            if (File.Exists("c:\\temp\\pelaajanpelit.xml"))
            {
                pelaajat = DeserializeXML();
                dgPelaajat.DataSource = pelaajat;
            }
            else
            {
                pelaajat = new List<Pelaaja>();
            }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Tiedostoa ei löydy : " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Tietojen tallentaminen datagridviewistä xml-tiedostoon
        private void btnKirjoita_Click(object sender, EventArgs e)
        {
            try { 
            SerializeXML(pelaajat);
            MessageBox.Show("Tiedot tallennettu onnistuneesti!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Pelaajan 1 tietojen lisääminen datagridviewiin
        public void btnLisaa1_Click(object sender, EventArgs e)
        {
            bool onListalla = false;

            try {
            int a = 0;
            int.TryParse(label1.Text, out a);

            int b = 0;
            int.TryParse(label2.Text, out b);

            int c = 0;
            int.TryParse(label4.Text, out c);

            int d = 0;
            int.TryParse(label5.Text, out d);

            Pelaaja p;
            p.nimi = tbPelaaja1.Text;
            p.pelatutPelit = a;
            p.voitot = b;
            p.tappiot = d;
            p.tasapelit = c;

                foreach (DataGridViewRow row in dgPelaajat.Rows) //Tarkistetaan onko lisättävä nimimerkki jo listalla
                {
                    if (row.Cells[0] != null && row.Cells[0].Value.ToString() == tbPelaaja1.Text)
                    {
                        onListalla = true;
                        break;
                    }
                }

                if (onListalla)
                    MessageBox.Show("Nimi on jo listalla, valitse uusi nimimerkki");
                else
                {
                    pelaajat.Add(p);
                    dgPelaajat.DataSource = null;
                    dgPelaajat.DataSource = pelaajat;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Pelaajan 2 tietojen lisääminen datagridviewiin
        private void btnLisaa2_Click(object sender, EventArgs e)
        {   
            bool onListalla = false;

            try { 
            int i = 0;
            int.TryParse(label6.Text, out i);
            int f = 0;
            int.TryParse(label3.Text, out f);
            int g = 0;
            int.TryParse(label7.Text, out g);
            int h = 0;
            int.TryParse(label8.Text, out h);

            Pelaaja p;
            p.nimi = tbPelaaja2.Text;
            p.pelatutPelit = i;
            p.voitot = f;
            p.tappiot = g;
            p.tasapelit = h;

                foreach (DataGridViewRow row in dgPelaajat.Rows)        //Tarkistetaan onko lisättävä nimimerkki jo listalla
                {
                    if (row.Cells[0] != null && row.Cells[0].Value.ToString() == tbPelaaja2.Text)
                    {
                        onListalla = true;
                        break;
                    }
                }

                if (onListalla)
                    MessageBox.Show("Nimi on jo listalla, valitse uusi nimimerkki");
                else { 

                pelaajat.Add(p);
            dgPelaajat.DataSource = null;
            dgPelaajat.DataSource = pelaajat;
                }
        }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Pelaaja-listan serialisointi xml-muotoon
        public void SerializeXML(List<Pelaaja> input)
        {
            try { 
            System.Xml.Serialization.XmlSerializer serializer = new
            XmlSerializer(input.GetType());
            StreamWriter sw = new StreamWriter("c:\\temp\\pelaajanpelit.xml");
            serializer.Serialize(sw, input);
            sw.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Tiedostoa ei löytynyt : " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //XML-tiedoston deserialisointi ja tietojen lisääminen datagridviewiin
        public List<Pelaaja> DeserializeXML()
        {
            
            if (File.Exists("c:\\temp\\pelaajanpelit.xml"))
            {
                StreamReader stream = new StreamReader("c:\\temp\\pelaajanpelit.xml");
                XmlSerializer ser = new
                XmlSerializer(typeof(List<Pelaaja>));
                object obj = ser.Deserialize(stream);
                stream.Close();
                return (List<Pelaaja>)obj;  
            }
            else { 
                return null;
                throw new Exception("Tiedostoa ei löydy!");
            }
            
        }

        //Näytetään pelitilastot erillisellä Formilla
        private void näytäTilastotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TilastoFormi tf = new TilastoFormi(pelaajat);
            tf.Show();
        }


        //Formin sulkeminen
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


        //TextBoxiin voidaan syöttää kirjaimia ja numeroita sekä välilyöntejä
        private void tbPelaaja1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try { 
            if(!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //TextBoxiin voidaan syöttää kirjaimia ja numeroita sekä välilyöntejä
        private void tbPelaaja2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try { 
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
