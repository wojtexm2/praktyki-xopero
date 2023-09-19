namespace Program_1
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            dinnerParty.SetHealthyOption(true);
            dinnerParty.CalculateCostOfDecorations(false);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(checkBoxOpcjaZdrowa.Checked);
            labelKoszt.Text = Cost.ToString("c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDownIloscOsob_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDownIloscOsob.Value;
            DisplayDinnerPartyCost();
        }

        private void checkBoxDekoracjeFantazyjne_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(true);
            DisplayDinnerPartyCost();
        }

        private void checkBoxOpcjaZdrowa_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(checkBoxOpcjaZdrowa.Checked);
            DisplayDinnerPartyCost();
        }
    }
}