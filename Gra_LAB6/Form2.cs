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
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form2 : Form
    {
        private int gameTime;
        private Button[,] buttons;
        private char[,] gameBoard; 
        private int numDydelfs; 
        private int discoveredDydelfs = 0; 

        public Form2(int boardSizeX, int boardSizeY, int gameTime, int numDydelfs, int numCrocodiles)
        {
            InitializeComponent();

            this.gameTime = gameTime;
            this.numDydelfs = numDydelfs;

            this.gameTime = gameTime;

            timerLabel = new Label();
            timerLabel.Location = new Point(10, 10);
            this.Controls.Add(timerLabel);

            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += new EventHandler(GameTimer_Tick);
            gameTimer.Start();

            buttons = new Button[boardSizeX, boardSizeY];
            gameBoard = new char[boardSizeX, boardSizeY];

            Random rand = new Random();
            for (int i = 0; i < numDydelfs; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(boardSizeX);
                    y = rand.Next(boardSizeY);
                } while (gameBoard[x, y] != '\0');

                gameBoard[x, y] = 'D';
            }

            for (int i = 0; i < numCrocodiles; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(boardSizeX);
                    y = rand.Next(boardSizeY);
                } while (gameBoard[x, y] != '\0');

                gameBoard[x, y] = 'K';
            }

            for (int x = 0; x < boardSizeX; x++)
            {
                for (int y = 0; y < boardSizeY; y++)
                {
                    buttons[x, y] = new Button();
                    buttons[x, y].Size = new Size(50, 50);
                    buttons[x, y].Location = new Point(10 + x * 50, 50 + y * 50); 
                    buttons[x, y].Click += Button_Click; 
                    this.Controls.Add(buttons[x, y]);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton.Enabled)
            {
                clickedButton.Enabled = false;

                clickedButton.BackColor = Color.Gray;

                int x = (clickedButton.Location.X - 10) / 50; 
                int y = (clickedButton.Location.Y - 50) / 50;
                if (gameBoard[x, y] == 'D')
                {
                    clickedButton.Text = "Dydelf";
                    discoveredDydelfs++; 
                 
                    if (discoveredDydelfs == numDydelfs)
                    {
                        gameTimer.Stop();
                        MessageBox.Show("Wygrałeś!");
                        this.Enabled = false; 
                        this.Close(); 
                    }
                }
                else if (gameBoard[x, y] == 'K')
                {
                    clickedButton.Text = "Krokodyl";
                    
                    gameTimer.Stop();
                    MessageBox.Show("Przegrałeś! Trafiłeś na Krokodyla.");
                    this.Enabled = false; 
                    this.Close(); 
                }
                else
                {
                    clickedButton.Text = "Puste pole";
                }
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            gameTime--;
            timerLabel.Text = "Czas: " + gameTime; 
            if (gameTime <= 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Koniec gry!");
                this.Enabled = false; 
                this.Close();
            }
        }
    }




}
