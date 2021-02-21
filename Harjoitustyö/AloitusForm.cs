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
    public partial class AloitusForm : Form
    {

        public AloitusForm()
        {
            InitializeComponent();
        }


        //Määritellään yksinpeli vai kaksinpeli
        public void rdBtnYksin_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Visible = true;
                groupBox3.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 
        }

        public void rdBtnKaksin_CheckedChanged(object sender, EventArgs e)
        {
            try { 
            groupBox3.Visible = true;
            groupBox2.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        // Valitaan 12 korttia
        public void btn12Kaksin_Click(object sender, EventArgs e)
        {
            try { 
                Kaksin12Form kf12 = new Kaksin12Form();
                kf12.Show();

                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Valitaan 20 korttia
        public void btn20Kaksin_Click(object sender, EventArgs e)
        {

            {
                try { 
                Kaksin20Form1 kf20 = new Kaksin20Form1();
                kf20.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        // Valitaan 36 korttia
        public void btn36Kaksin_Click(object sender, EventArgs e)
        {
            try {
                Kaksin36Form kf36 = new Kaksin36Form();
                kf36.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Poistutaan ohjelmasta
        private void btnExit_Click(object sender, EventArgs e)
        {
            try { 
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn12Yksin_Click(object sender, EventArgs e)
        {
            try
            {
                Yksin12Form yf12 = new Yksin12Form();
                yf12.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn20Yksin_Click(object sender, EventArgs e)
        {
            try
            {
                Yksin20Form yf20 = new Yksin20Form();
                yf20.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn36Yksin_Click(object sender, EventArgs e)
        {
            try
            {
                Yksin36Form yf36 = new Yksin36Form();
                yf36.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
