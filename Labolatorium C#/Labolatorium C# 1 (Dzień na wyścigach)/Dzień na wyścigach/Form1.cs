namespace Dzień_na_wyścigach
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        Guy[] guys = new Guy[3];
        Greyhound[] hounds = new Greyhound[4];
        bool raceGoing = false;

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

            for (int i = 0; i < guys.Length; i++)
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
            bool everyoneBetted = true;
            for (int i = 0; i < guys.Length; i++)
            {
                if (guys[i].MyBet.Ammount <= 0)
                {
                    everyoneBetted = false;
                    MessageBox.Show(guys[i].Name + " nie zawarł zakładu!", "Zakłady");
                }
            }
            if (everyoneBetted)
            {
                //START WYŚCIGU
                houndTimer.Enabled = true;
                raceGoing = true;
            }
        }

        private void houndTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < hounds.Length; i++)
            {
                if (hounds[i].Run())
                {
                    //KONIEC WYŚCIGU
                    int winningHound = i;
                    //Reset gry
                    houndTimer.Enabled = false;
                    raceGoing = false;
                    MessageBox.Show("Wygrał pies numer " + (winningHound + 1) + "!");
                    for (int i2 = 0; i2 < hounds.Length; i2++)
                    {
                        hounds[i2].TakeStartingPoistion();
                    }
                    for (int i2 = 0; i2 < guys.Length; i2++)
                    {
                        guys[i2].Collect(winningHound);
                        guys[i2].ClearBet();
                    }
                    break;
                }

            }
        }

        private void buttonBet_Click(object sender, EventArgs e)
        {
            if (!raceGoing)
            {
                bool noneChecked = true;
                int hound = (int)numericUpDownDogId.Value - 1;
                int ammount = (int)betAmmount.Value;
                Guy someGuy;
                for (int i = 0; i < guys.Length; i++)
                {
                    someGuy = guys[i];
                    if (someGuy.MyRadioButton.Checked)
                    {
                        noneChecked = false;
                        if (someGuy.PlaceBet(ammount))
                        {
                            someGuy.MyBet.Ammount = ammount;
                            someGuy.MyBet.Dog = hound;
                            someGuy.MyLabel.Text = someGuy.Name + " stawia " + ammount + " zł na charta numer " + (hound + 1);
                        }
                    }
                }
                if (noneChecked)
                {
                    MessageBox.Show("Zaznacz jakąś osobę", "Zaznaczanie");

                }
            }
            else
            {
                MessageBox.Show("Nie można zawierać zakładów w trakcie wyścigu!", "Zakłady");
            }
        }

        private void firstRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            labelName.Text = guys[0].Name;
        }

        private void secondRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            labelName.Text = guys[1].Name;
        }

        private void thirdRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            labelName.Text = guys[2].Name;
        }
    }
}