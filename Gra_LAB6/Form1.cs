namespace Gra_LAB6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int boardSizeX = Form3.boardSizeX;
            int boardSizeY = Form3.boardSizeY;
            int gameTime = Form3.gameTime;
            int numDydelfs = Form3.numDydelfs;
            int numCrocodiles = Form3.numCrocodiles;

            Form2 form2 = new Form2(boardSizeX, boardSizeY, gameTime, numDydelfs, numCrocodiles);
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
