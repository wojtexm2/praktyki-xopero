namespace program2__słonie_i_obiekty_
{
    public partial class Form1 : Form
    {
        Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLloyd_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void buttonLucinda_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void buttonZamien_Click(object sender, EventArgs e)
        {
            Elephant tempElephant = lloyd;
            lloyd = lucinda;
            lucinda = tempElephant;
        }

        private void buttonZepsuj_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }
    }
}