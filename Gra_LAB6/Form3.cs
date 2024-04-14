using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_LAB6
{
    public partial class Form3 : Form
    {
        public static int boardSizeX;
        public static int boardSizeY;
        public static int gameTime;
        public static int numDydelfs; 
        public static int numCrocodiles;

        
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int boardSizeX = int.Parse(textBox1.Text);
            int boardSizeY = int.Parse(textBox2.Text);
            int gameTime = int.Parse(textBox3.Text);
            int numDydelfs = int.Parse(textBox4.Text);
            int numCrocodiles = int.Parse(textBox5.Text);

            if (boardSizeX < 3 || boardSizeX > 10 || boardSizeY < 3 || boardSizeY > 10)
            {
                MessageBox.Show("Rozmiar planszy musi być od 3x3 do 10x10.");
                return;
            }

            if (gameTime < 10 || gameTime > 60)
            {
                MessageBox.Show("Czas gry musi wynosić od 10 do 60 sekund.");
                return;
            }

            if (numDydelfs < 1 || numDydelfs > 6)
            {
                MessageBox.Show("Liczba Dydelfów musi wynosić od 1 do 6.");
                return;
            }

            if (numCrocodiles < 0 || numCrocodiles > 1)
            {
                MessageBox.Show("Liczba Krokodyli musi wynosić od 0 do 1.");
                return;
            }

            Form3.boardSizeX = boardSizeX;
            Form3.boardSizeY = boardSizeY;
            Form3.gameTime = gameTime;
            Form3.numDydelfs = numDydelfs;
            Form3.numCrocodiles = numCrocodiles;

            this.Close();
        }

    }
}
