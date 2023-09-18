namespace Dzień_na_wyścigach
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        Guy[] guys = new Guy[3];
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

            guys[0] = new Guy() { Name = "Janek", Cash = 50, MyRadioButton = firstRadioButton, MyLabel = firstBetLabel };
            guys[1] = new Guy() { Name = "Bartek", Cash = 75, MyRadioButton = secondRadioButton, MyLabel = secondBetLabel };
            guys[2] = new Guy() { Name = "Arek", Cash = 45, MyRadioButton = thirdRadioButton, MyLabel = thirdBetLabel };

            guys[0].MyBet = new Bet() { Bettor = guys[0] };
            guys[1].MyBet = new Bet() { Bettor = guys[1] };
            guys[2].MyBet = new Bet() { Bettor = guys[2] };

            for (int i=0; i < guys.Length; i++)
            {
                guys[i].ClearBet();
                guys[i].MyRadioButton.Text = guys[i].Name + " ma " + guys[i].Cash + " zł";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            houndTimer.Enabled = true;
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