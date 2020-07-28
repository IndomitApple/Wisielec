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
        ///Zmienna zawierające wylosowane do gry słowo
        public int ile_pudel;
        ///Liczba "pudeł" czyli błędnych trafień
        public Form1()
        {
            InitializeComponent();
            losuj_slowo();
            ///Metoda przygotowująca stan gry po jej uruchomieniu
        }

        private void label1_Click(object sender, EventArgs e)
            ///Po kliknięciu przycisku "Sprawdź"
        {
            string litera = textBox1.Text; 
            ///Z textBox1 pobieramy literę, którą chcemy sprawdzić czy jest w słowie
            bool czy_trafiony = false;
            ///Czy litera jest w słowie, czy nie?
            int gdzie_trafiony = 0;
            ///Którą z kolei litere trafiliśmy?
            for (int i = 1; i < 6; i++)
             ///Ta pętla sprawdza czy w wylosowanym słowie jest litera którą podaliśmy
            {
                if (Convert.ToString(slowo[i]) == litera)
                    ///Jeśli tak, przypisuje do zmiennej gdzie_trafiony którą z kolei litere trafiliśmy
                {
                    czy_trafiony = true;
                    gdzie_trafiony = i;
                }



                if (czy_trafiony == true)
                    ///Jeśli trafiliśmy, w odpowiedni label o treści _ wstawia literę którą trafiliśmy, w odp. miejscu
                {

                    switch (gdzie_trafiony)
                    {
                        case 0:
                            label2.Text = litera;
                            break;
                        case 1:
                            label3.Text = litera;
                            break;
                        case 2:
                            label4.Text = litera;
                            break;
                        case 3:
                            label5.Text = litera;
                            break;
                        case 4:
                            label6.Text = litera;
                            break;
                        case 5:
                            label7.Text = litera;
                            break;
                        case 6:
                            label8.Text = litera;
                            break;
                        default:
                            break;

                    }

                }

            }
            if (czy_trafiony == false)
                ///Jeśli nie trafiliśmy litery, dodaje pudło i zmienia wyświetlaną grafikę
            {
                ile_pudel++;
                switch (ile_pudel)
                {
                    case 0:
                        pictureBox1.Image = Wisielec.Properties.Resources._3;
                        break;
                    case 1:
                        pictureBox1.Image = Wisielec.Properties.Resources._3;
                        break;
                    case 2:
                        pictureBox1.Image = Wisielec.Properties.Resources._3;
                        break;
                    case 3:
                        pictureBox1.Image = Wisielec.Properties.Resources._3;
                        break;
                    default:
                        break;

                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        public string losuj_slowo()
        {
            
            string[] slowa = { "krokusy", "liliput", "marchew", "selerek", "krakers", "klakier" }; //Słowa z których będzie wylosowane słowo do gry
            int ile_slow = slowa.Length;
            ///Długość tabeli ze słowami, czyli ilość możliwych słów

            Random gen = new Random();
            ///Deklaracja generatora losowego
            int indeks_slowa = gen.Next(0, ile_slow);
            ///Tu jest losowany indeks słowa które jest wybrane do gry
            slowo = slowa[indeks_slowa];
            ///Słowo o wylosowanym indeksie jest przypisane do zmiennej "słowo"
            label2.Text = Convert.ToString(slowo[0]);
            ///Pierwsze pole _ ustawia jako pierwsza literę wylosowanego wyrazu
            label8.Text = Convert.ToString(slowo[6]);
            ///Ostatnie pole _ ustawia jako ostatnią (siódmą) literę wylosowanego wyrazu
            return slowo;
        }
    }
}
