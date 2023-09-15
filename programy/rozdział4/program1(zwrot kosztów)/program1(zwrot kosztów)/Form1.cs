namespace program1_zwrot_kosztów_
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate = 0.39;
        double amountOwed;
        public Form1()
        {
            InitializeComponent();
        }

        private void poczStanLicznikaLabel_Click(object sender, EventArgs e)
        {

        }

        private void kosztaDoZwrotuLabelWyswietl_Click(object sender, EventArgs e)
        {

        }

        private void obliczButton_Click(object sender, EventArgs e)
        {
            startingMileage = (int)poczStanLicznika.Value;
            endingMileage = (int)konStanLicznika.Value;
            if (startingMileage < endingMileage)
            {
                milesTraveled = endingMileage -= startingMileage;
                amountOwed = milesTraveled *= reimburseRate;
                kosztaDoZwrotuLabelWyswietl.Text = amountOwed.ToString() + " zł";
            }
            else
            {
                MessageBox.Show("Nieprawidłowe wartości!");
            }
        }
    }
}