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
        string slowo; //Zmienna zawierające wylosowane do gry słowo
        public Form1()
        {
            InitializeComponent();
            losuj_slowo(); //Metoda przygotowująca stan gry po jej uruchomieniu
        }

        private void label1_Click(object sender, EventArgs e) //Po kliknięciu przycisku "Sprawdź"
        {

       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void losuj_slowo()
        {
            
            string[] slowa = { "krokusy", "liliput", "marchew", "selerek", "krakers", "klakier" }; //Słowa z których będzie wylosowane słowo do gry
            int ile_slow = slowa.Length; //Długość tabeli ze słowami, czyli ilość możliwych słów

            Random gen = new Random(); //Deklaracja generatora losowego
            int indeks_slowa = gen.Next(0, ile_slow); //Tu jest losowany indeks słowa które jest wybrane do gry
            slowo = slowa[indeks_slowa]; //Słowo o wylosowanym indeksie jest przypisane do zmiennej "słowo"
            labelTest1.Text = slowo;
        }
    }
}
