namespace Dzień_na_wyścigach
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        Guy[] guys = { };
        Greyhound[] hounds = new Greyhound[4];

        public Form1()
        {
            InitializeComponent();
            hounds[0] = new Greyhound() { MyPictureBox = pictureBoxHound1, MyRandom = random };
            hounds[1] = new Greyhound() { MyPictureBox = pictureBox3, MyRandom = random };
            hounds[2] = new Greyhound() { MyPictureBox = pictureBox4, MyRandom = random };
            hounds[3] = new Greyhound() { MyPictureBox = pictureBox5, MyRandom = random };
            for (int i = 0; i < hounds.Length; i++)
            {
                hounds[i].TakeStartingPoistion();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void minimumBetLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            bool hasWon = false;
            int winningNumber;

        }

        private void houndTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < hounds.Length; i++)
            {
                if (hounds[i].Run())
                {
                    houndTimer.Enabled = false;
                }

            }
        }
    }
}