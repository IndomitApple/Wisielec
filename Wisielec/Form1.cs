using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wisielec
{
    public partial class Form1 : Form
    {
        string slowo;
        int ile_pudel;
        public Form1()
        {
            InitializeComponent();
            losuj_slowo();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string litera = textBox1.Text;
            bool czy_trafiony = false;
            int gdzie_trafiony = 0;
            for (int i = 1; i < 6; i++)
            {
                if (Convert.ToString(slowo[i]) == litera)
                {
                    czy_trafiony = true;
                    gdzie_trafiony = i;
                }

                if (czy_trafiony == false)
                {
                    ile_pudel++;
                    //if (ile_pudel == 1) { pictureBox1.Image = Wisielec.Properties.Resources.r_3_1; }
                    //if (ile_pudel == 1) { pictureBox1.Image = Wisielec.Properties.Resources.r_3_1; }
                    //if (ile_pudel == 1) { pictureBox1.Image = Wisielec.Properties.Resources.r_3_1; }
                    //if (ile_pudel == 1) { pictureBox1.Image = Wisielec.Properties.Resources.r_3_1; }
                    //if (ile_pudel == 1) { pictureBox1.Image = Wisielec.Properties.Resources.r_3_1; }
                    //if (ile_pudel == 1) { pictureBox1.Image = Wisielec.Properties.Resources.r_3_1; }
                }

                if (czy_trafiony == true)
                {
                    if (gdzie_trafiony == 0) label2.Text = litera;
                    if (gdzie_trafiony == 1) label3.Text = litera;
                    if (gdzie_trafiony == 2) label4.Text = litera;
                    if (gdzie_trafiony == 3) label5.Text = litera;
                    if (gdzie_trafiony == 4) label6.Text = litera;
                    if (gdzie_trafiony == 5) label7.Text = litera;
                    if (gdzie_trafiony == 6) label8.Text = litera;
                }

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void losuj_slowo()
        {
            
            string[] slowa = { "krokusy", "liliput", "marchew", "selerek", "krakers", "klakier" };
            int ile_slow = slowa.Length;

            Random gen = new Random();
            int indeks_slowa = gen.Next(0, ile_slow);
            slowo = slowa[indeks_slowa];
            label2.Text = Convert.ToString(slowo[0]); //Pierwsze pole _ ustawia jako pierwsza literę wylosowanego wyrazu
            label8.Text = Convert.ToString(slowo[6]); //Ostatnie pole _ ustawia jako ostatnią (siódmą) literę wylosowanego wyrazu
        }
    }
}
