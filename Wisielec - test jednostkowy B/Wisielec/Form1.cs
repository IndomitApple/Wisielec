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
        int ile_pudel; //Liczba "pudeł" czyli błędnych trafień
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click_1(object sender, EventArgs e)
        {
            ile_pudel++;
            if (ile_pudel == 1) { pictureBox1.Image = Wisielec.Properties.Resources._3; }
            if (ile_pudel == 2) { pictureBox1.Image = Wisielec.Properties.Resources._6; }
            if (ile_pudel == 3) { pictureBox1.Image = Wisielec.Properties.Resources._9; }
            if (ile_pudel == 4) { pictureBox1.Image = Wisielec.Properties.Resources._11; }
        }
    }
}
